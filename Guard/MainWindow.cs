using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Guard
{
    public partial class MainWindow : Form
    {
        // Generating our Countdown requires a DateTime Object up here
        DateTime goal = new DateTime();
        DateTime lastEvent = new DateTime();

        // Making the top panel Draggable in order to create a nicer UI.
        bool drag = false;
        Point start_point = new Point(0, 0);

        // Important for timers
        //public string goalDate { get; private set; }
        //public long goalDateInt { get; private set; }
        string goalDate = "";
        Int64 goalDateInt = 0;
        Int64 eventDateInt = 0;

        // Initialize the main window
        public MainWindow()
        {
            InitializeComponent();
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            // Stays Empty
        }

        // This allows the top panel to function as an actual windows header bar.
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        // Now we allow the top panel to drag the window around on the users screen.
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
                this.Update();
            }
        }

        // When the user lets go of the mouse, set drag back to false
        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        // Make a close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Initialize a timer so we can generate our live clock
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString();
            timer1.Start();

        }

        // Initialize another timer so we can generate our countdown
        void countDown_Tick(object sender, EventArgs e)
        {
            // Use TimeSpan for the countdown.
            //    Subtract our goal date from the current time.
            TimeSpan ts = goal.Subtract(DateTime.Now);

            // Output this to the countdown label.
            timeLeftLabel.Text = ts.ToString("%d") + " Days " + ts.ToString("%h") + " Hours " + ts.ToString("%m") + " Minutes " + ts.ToString("%s") + " Seconds";
        }

        // Initialize one more timer so we can count elapsed time
        void timeSince_Tick(object sender, EventArgs e)
        {
            // Declare a DateTime of now
            DateTime now = DateTime.Now;

            // Set the timespan equal to the time now, minus the time of the last event.
            TimeSpan ts = now - lastEvent;

            // Output this to the Time Since Label
            timeSinceLabel.Text = ts.ToString("%d") + " Days " + ts.ToString("%h") + " Hours " + ts.ToString("%m") + " Minutes " + ts.ToString("%s") + " Seconds";

        }

        // MAIN CODE BODY BEGIN
        //    Guard is a rough, prototype application for tracking addiction or other habits
        //    that a user might wish to be rid of. It is a simple program that tracks dates
        //    on which a user might "cave in" to a craving and then assists by allowing them
        //    a date on which they are allowed to partake in a craving. The time spans
        //    gradually move farther apart based on user settings - allowing for an easier time
        //    of quitting. 
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // CREATE & CONNECT TO DB
            // 
            // First we need to create our tables if they don't exist.
            // We use the SQLize class and create some objects first.
            SQLize datesTable = new SQLize("CREATE TABLE IF NOT EXISTS Dates (date_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, datetime INTEGER NOT NULL)");
            SQLize achTable = new SQLize("CREATE TABLE IF NOT EXISTS Achievements (ach_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, best_time INTEGER NOT NULL)");

            // Next we use the Run_Command for the SQLize class to run the commands.
            datesTable.Run_Command();
            achTable.Run_Command();

            // Call RefreshData function to refresh the data
            RefreshData();

            // RUN THE TIMERS
            RefreshGoalDate();
            RefreshCountdown();
            RefreshElapsed();
        }

        // ADD PREVIOUS BUTTON
        //
        // If the user clicks the button to add an event that happened in the past
        //    then open a new form.
        private void addPrevButton_Click(object sender, EventArgs e)
        {
            AddPrevious f2 = new AddPrevious();
            f2.ShowDialog();

            // Refresh the data when the user closes the window.
            RefreshData();

            // Refresh our timers
            RefreshGoalDate();
            RefreshCountdown();
            RefreshElapsed();
        }

        // SETTINGS BUTTON
        //
        // When a user clicks the settings icon, a new form is launched
        //    which contains the primary settings for the app.
        private void button1_Click(object sender, EventArgs e)
        {
            Settings f3 = new Settings();
            f3.ShowDialog();

            // When the window closes , refresh stuff
            RefreshData();
            RefreshGoalDate();
            RefreshCountdown();
            RefreshElapsed();
        }

        // ADD NOW BUTTON
        //
        // When a user clicks the 'Add Now' button, the current date and
        //    time are entered into the Dates table as a unix timestamp.
        private void addNowButton_Click(object sender, EventArgs e)
        {
            // Delcare some variables we need
            Int64 unixTimeThen = 0;
            Int64 compare = 0;
            Int64 highest = 0;

            // When button is clicked
            Int64 unixTimeNow = DateTimeOffset.Now.ToUnixTimeSeconds();

            // Create a new SQLize instance to get the last date
            SQLize retrieveDate = new SQLize("SELECT * FROM Dates ORDER BY datetime DESC LIMIT 1");

            // Store this data briefly with the Read_OneDateInt function of SQLizer
            unixTimeThen = retrieveDate.Read_OneDateInt();

            // Check the difference between unixTimeNow and unixTimeThen with GuardTime
            // But ONLY if the value of unixTimeThen is not 0 which would indicate
            // that there are no records. We need at least one date entry in the dates
            // table to perform calculations!
            if (unixTimeThen != 0)
            {
                GuardTime guard = new GuardTime();
                compare = guard.CalcUnixTimeSpan(unixTimeThen, unixTimeNow);

                // Create one more SQLize instance to grab the last time span from the achievements table
                SQLize retrieveBest = new SQLize("SELECT * FROM Achievements ORDER BY best_time DESC LIMIT 1");
                highest = retrieveBest.Read_OneDateInt();
            
                // If the the highest time is 0, then there are no records which means we should add one!
                if (highest == 0)
                {
                    // Create a new SQLize instance
                    SQLize add = new SQLize("INSERT INTO Achievements (best_time) VALUES(" + compare + ")");

                    // Run that command
                    add.Run_Command();
                }

                // If the highest time is not 0, then determine if we should insert a new best time.
                if (compare > highest && highest != 0)
                {
                    // Create a new SQLize instance
                    SQLize add = new SQLize("INSERT INTO Achievements (best_time) VALUES(" + compare + ")");

                    // Run that command
                    add.Run_Command();
                }
            }


            // Issue an Insert statement to the Dates table.
            SQLize insert = new SQLize("INSERT INTO Dates (datetime) VALUES (" + unixTimeNow + ")");

            // Tell SQLize to run the command.
            insert.Run_Command();

            // Call Refresh Data
            RefreshData();

            // Refresh our timers
            RefreshGoalDate();
            RefreshCountdown();
            RefreshElapsed();

        }

        private void RefreshData()
        {
            // Clear the textboxes
            achTextBox.Clear();
            datesTextBox.Clear();

            // Initialize GuardTime.
            GuardTime guard = new GuardTime();

            // Issue a new SELECT query for the Achievements table.
            SQLize refreshAch = new SQLize("SELECT * FROM (SELECT * FROM Achievements ORDER BY ach_id DESC LIMIT 14) ORDER BY ach_id");

            // Call Read_Ach to read the data.
            refreshAch.Read_Ach();

            // Set the output of SQLize's Get_Out method to the Achievements textbox.text
            achTextBox.Text = refreshAch.Get_Out();

            // Issue a new SELECT query for the Dates table.
            SQLize refreshDates = new SQLize("SELECT datetime FROM (SELECT * FROM Dates ORDER BY date_id DESC LIMIT 14) ORDER BY date_id");

            // Call Read_Dates to read the data.
            refreshDates.Read_Dates();

            // Set the output of SQLize's Get_Out method to the Dates textbox.text
            datesTextBox.Text = refreshDates.Get_Out();
        }

        // Refresh the goal date label.
        private void RefreshGoalDate()
        {
            GuardTime guard = new GuardTime();

            // Tell GuardTime to set the config.
            guard.setConfig();

            // Initialize SQLize class and pass it the command.
            SQLize calc = new SQLize("SELECT * FROM Dates ORDER BY datetime DESC LIMIT 1");

            // Tell SQLize to return OneDate and set it equal to a string.
            string aDate = calc.Read_OneDate();

            // If the date is null, we don't want to be doing operations on it.
            //    This could happen when Guard starts for the first time.
            if (aDate != null)
            {
                // Parse the string into a 64 bit integer.
                Int64 n;
                Int64.TryParse(aDate, out n);

                // Assign our original date -> necessary for the counting UP process. 
                eventDateInt = n;

                // Tell guard to calculate the release date and set the goalDate string.
                goalDate = guard.CalcReleaseDate(n);

                // set our int value
                goalDateInt = guard.CalcReleaseDateInt(n);

                // Display the goal date without GMT information
                nextGoalLabel.Text = guard.RemoveGMT(goalDate);

            }
        }

        private void RefreshCountdown()
        {
            if (goalDateInt != 0)
            {
                // Call GuardTime
                GuardTime guard = new GuardTime();

                // Tell GuardTime to convert the epoch time into our goal date time object declared at the start of the MainWindow.
                goal = guard.EpochToDateTime(goalDateInt);

                // Create a new timer
                Timer countDown = new Timer();

                // Set the Interval
                countDown.Interval = 100;

                // Set the event handler
                countDown.Tick += new EventHandler(countDown_Tick);

                TimeSpan ts = goal.Subtract(DateTime.Now);


                timeLeftLabel.Text = ts.ToString("");
                countDown.Start();

            }
        }

        private void RefreshElapsed()
        {
            if (goalDateInt != 0)
            {
                // Call GuardTime
                GuardTime guard = new GuardTime();

                // Tell GuardTime to give us the DateTime of the last event and set that to our lastEvent dateTime.
                lastEvent = guard.EpochToDateTime(eventDateInt);

                // Create a new timer
                Timer timeSince = new Timer();

                // Set the Interval
                timeSince.Interval = 100;

                // Set the event handler
                timeSince.Tick += new EventHandler(timeSince_Tick);

                // Declare a DateTime of now
                DateTime now = DateTime.Now;

                // Set the timespan equal to the time now, minus the time of the last event.
                TimeSpan ts = now - lastEvent;

                timeSinceLabel.Text = ts.ToString("");
                timeSince.Start();

            }
        }

        private void BestTimeCheck()
        {

        }

        private void nextGoalLabel_Click(object sender, EventArgs e)
        {
            //Do Nothing
        }

        private void currentTimeLabel_Click(object sender, EventArgs e)
        {
            // Do Nothing
        }

        private void currentTimeTitleLabel_Click(object sender, EventArgs e)
        {
            // Do Nothing
        }
    }
}

