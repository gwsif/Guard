using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guard
{
    public partial class AddPrevious : Form
    {
        // For making the panel draggable
        bool drag2 = false;
        Point start_point2 = new Point(0, 0);

        // Initialize the form
        public AddPrevious()
        {
            InitializeComponent();
        }

        // Allow the top panel to function as an actual windows header bar
        private void topPanelPrevious_MouseDown(object sender, MouseEventArgs e)
        {
            drag2 = true;
            start_point2 = new Point(e.X, e.Y);
        }

        // Now we allow the top panel to drag the window around on the users screen.
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag2)
            {
                Point q = PointToScreen(e.Location);
                this.Location = new Point(q.X - start_point2.X, q.Y - start_point2.Y);
            }
        }

        // When the user lets go of the mouse, set drag back to false
        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag2 = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Do Nothing
        }

        // CLOSE BUTTON
        private void closeButtonPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ADD BUTTON
        // 
        // When a user clicks this button a new record containing a custom date and time
        //    is inserted into the database and the database is refreshed.
        private void addButton_Click(object sender, EventArgs e)
        {
            // Declare some variables we need
            Int64 unixTimeThen = 0;
            Int64 compare = 0;
            Int64 highest = 0;

            // Begin by creating a new SQLize instance to get the last date
            SQLize retrieveDate = new SQLize("SELECT * FROM Dates ORDER BY datetime DESC LIMIT 1");

            // Store this data briefly with the Read_OneDateInt function of SQLizer
            unixTimeThen = retrieveDate.Read_OneDateInt();

            // Grab our values from the text box
            // Day
            string day = dayComboBox.Text;
            // Month
            string month = monthComboBox.Text;
            // Year
            string year = yearPicker.Text;
            // Time
            string time = timePicker.Text;

            // Parse these values into Guards date format.
            string dateStringRaw = day + " " + month + " " + year + " " + time;
            DateTime inputDate = DateTime.Parse(dateStringRaw);

            // Get ourselves a datetime offset.
            DateTimeOffset dto = new DateTimeOffset(inputDate);

            // Turn this into a unix timestamp!
            Int64 unixTimeNow = dto.ToUnixTimeSeconds();

            // Check the difference between unixTimeNow and unixTimeThen with GuardTime
            // But ONLY if the value of unixTimeThen is not 0 which would indicate
            // that there are no records. We need at least one date entry in the dates
            // table to perform calculations!
            if (unixTimeThen != 0)
            {
                // Check the difference between unixTimeNow and unixTimeThen with GuardTime
                GuardTime guard = new GuardTime();
                compare = guard.CalcUnixTimeSpan(unixTimeThen, unixTimeNow);

                // Create one more SQLize instance to grab the last time span from the achievements table
                SQLize retrieveBest = new SQLize("SELECT * FROM Achievements ORDER BY best_time DESC LIMIT 1");
                highest = retrieveBest.Read_OneDateInt();

                // If the highest time is 0, then there are no records whcih means we should add one!
                if (highest == 0)
                {
                    // Create a new SQLize instance
                    SQLize add = new SQLize("INSERT INTO Achievements (best_time) VALUES(" + compare + ")");

                    // Run that command
                    add.Run_Command();
                }

                // Determine if we should insert a new best time
                // If the highest time is not 0, then determine if we should insert a new best time!
                if (compare > highest && highest != 0)
                {
                    // Create a new SQLize instance
                    SQLize add = new SQLize("INSERT INTO Achievements (best_time) VALUES(" + compare + ")");

                    // Run that command
                    add.Run_Command();
                }

            }


            // Create our date
            //string dateStringNew = "\'" + unixTimeNow.ToString() + "\'";

            // Issue an insert statement to the Dates table
            SQLize insert = new SQLize("INSERT INTO Dates (datetime) VALUES (" + unixTimeNow + ")");

            // Tell SQLize to run the command.
            insert.Run_Command();

        }
    }
}
