using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Guard
{
    public partial class Settings : Form
    {
        // For making the panel draggable
        bool drag3 = false;
        Point start_point3 = new Point(0, 0);

        // Initialize the form
        public Settings()
        {
            InitializeComponent();
        }

        // Allow the top panel to function as an actual windows header bar.
        private void topPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            drag3 = true;
            start_point3 = new Point(e.X, e.Y);
        }

        // Now we allow the top panel to drag the windows around on the users screen.
        private void topPanel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag3)
            {
                Point r = PointToScreen(e.Location);
                this.Location = new Point(r.X - start_point3.X, r.Y - start_point3.Y);
                this.Update();
            }
        }

        // When the user lets go of the mouse, set the drag back to false
        private void topPanel3_MouseUp(object sender, MouseEventArgs e)
        {
            drag3 = false;
        }

        // CLOSE BUTTON
        private void closeButtonPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void addPrevButton_Click(object sender, EventArgs e)
        {
            // not used
        }

        // ABOUT BUTTON
        private void aboutButton_Click(object sender, EventArgs e)
        {
            Form1 f4 = new Form1();
            f4.ShowDialog();
        }

        // DEFAULT BUTTON
        // 
        // When the default button is clicked, Guard updates a text file which contains configuration
        //    information. This information pertains to the settings used to calculate the "Next Release"
        //    time which can also be thought of as the next time a user is allowed to indulge in a craving.
        //
        // Default settings place this as 36 hours.
        private void btnUseDefault_Click(object sender, EventArgs e)
        {
            // Since this is default, we can simply pass the default settings without having to check
            //    any input boxes.
            // Since the default is 36 hours, we pass the values ("0", "0", "86400", "43200", "0", "default")
            //    which corresponds to the number of seconds in 0 days, 0 months, 1 day, 12 hours, 0 minutes 
            //    and "default" because we need to indicate which config file is being updated.
            CreateCFG("0", "0", "86400", "43200", "0", "default");
        }

        // CUSTOM BUTTON
        // 
        // When the custom button is clicked, Guard updates a text file which contains configuration
        //    information. This information pertains to the settings used to calculate the "Next Release"
        //    time which can also be thought of as the next time a user is allowed to indulge in a craving.
        //
        // Custom settings take user defined values, se we need to check boxes and sanitize input before
        //    passing this information to the CreateCFG method.
        private void btnUseCustom_Click(object sender, EventArgs e)
        {
            // First lets get some holder values.
            string c_years = txtBoxC_Years.Text;
            string c_months = txtBoxC_Months.Text;
            string c_days = txtBoxC_Days.Text;
            string c_hours = txtBoxC_Hours.Text;
            string c_minutes = txtBoxC_Minutes.Text;

            // Now lets fix any empty boxes.
            c_years = LetsCheck(c_years);
            c_months = LetsCheck(c_months);
            c_days = LetsCheck(c_days);
            c_hours = LetsCheck(c_hours);
            c_minutes = LetsCheck(c_minutes);

            // Now lets run a sanity check on that information and double check that the user hasn't input
            //    any "dirty" data (eg: non-numerical data)
            c_years = SanityCheck(c_years, "Years");
            c_months = SanityCheck(c_months, "Months");
            c_days = SanityCheck(c_days, "Days");
            c_hours = SanityCheck(c_hours, "Hours");
            c_minutes = SanityCheck(c_minutes, "Minutes");

            // Once the data is cleaned, we need to change everything over to seconds so we can use these
            //    values in our calculations since we're using EpochTime now. This means switching these to
            //    Int64 values.
            //
            // GuardTime has a method to do this, so initialze GuardTime
            GuardTime guard = new GuardTime();

            // Now convert the values
            //    The Gregorian Input function expects you to tell it whether we are converting years, months
            //    days, hours, or minutes as the second argument.
            string ec_years = guard.GregorianInputToEpoch(c_years, "years");
            string ec_months = guard.GregorianInputToEpoch(c_months, "monhts");
            string ec_days = guard.GregorianInputToEpoch(c_days, "days");
            string ec_hours = guard.GregorianInputToEpoch(c_hours, "hours");
            string ec_minutes = guard.GregorianInputToEpoch(c_minutes, "minutes");

            // Once the data is cleaned, update the config file!
            CreateCFG(ec_years, ec_months, ec_days, ec_hours, ec_minutes, "custom");

            // Inform the user of the changes
            MessageBox.Show("Config file updated with the following settings:" + "\n" + c_years + " Years"
                                                                               + "\n" + c_months + " Months"
                                                                               + "\n" + c_days + " Days"
                                                                               + "\n" + c_hours + " Hours"
                                                                               + "\n" + c_minutes + " Minutes"
                                                                               , "Switched To Custom Config");            

        }

        // CUSTOM PLUS BUTTON
        //
        // When the custom plus button is clicked, Guard updates a text file which contains configuration
        //    information. This information pertains to the settings used to calculate the "Next Release"
        //    time which can also be thought of as the next time a user is allowed to indulge in a craving.
        //
        // Custom plus settings take user defined values, se we need to check boxes and sanitize input before
        //    passing this information to the CreateCFG method.
        private void btnUsePlus_Click(object sender, EventArgs e)
        {
            // First lets get some holder values
            string p_years = txtBoxC_Years.Text;
            string p_months = txtBoxP_Months.Text;
            string p_days = txtBoxP_Days.Text;
            string p_hours = txtBoxP_Hours.Text;
            string p_minutes = txtBoxP_Minutes.Text;

            // Now lets fix any empty boxes.
            p_years = LetsCheck(p_years);
            p_months = LetsCheck(p_months);
            p_days = LetsCheck(p_days);
            p_hours = LetsCheck(p_hours);
            p_minutes = LetsCheck(p_minutes);

            // Now lets run a sanity check on that information and double check that the user hasn't input
            //    any "dirty" data (eg: non-numerical data)
            p_years = SanityCheck(p_years, "Years");
            p_months = SanityCheck(p_months, "Months");
            p_days = SanityCheck(p_days, "Days");
            p_hours = SanityCheck(p_hours, "Hours");
            p_minutes = SanityCheck(p_minutes, "Minutes");

            // Once the data is cleaned, we need to change everything over to seconds so we can use these
            //    values in our calculations since we're using EpochTime now. This means switching these to
            //    Int64 values.
            //
            // GuardTime has a method to do this, so initialze GuardTime
            GuardTime guard = new GuardTime();

            // Now convert the values
            //    The Gregorian Input function expects you to tell it whether we are converting years, months
            //    days, hours, or minutes as the second argument. 
            string ep_years = guard.GregorianInputToEpoch(p_years, "years");
            string ep_months = guard.GregorianInputToEpoch(p_months, "months");
            string ep_days = guard.GregorianInputToEpoch(p_days, "days");
            string ep_hours = guard.GregorianInputToEpoch(p_hours, "hours");
            string ep_minutes = guard.GregorianInputToEpoch(p_minutes, "minutes");

            // Now that the values are properly set, we can write them to the CFG.
            CreateCFG(ep_years, ep_months, ep_days, ep_hours, ep_minutes, "customplus");

            // Inform the user of the changes
            MessageBox.Show("Config file updated with the following settings:" + "\n" + p_years + " Years"
                                                                               + "\n" + p_months + " Months"
                                                                               + "\n" + p_days + " Days"
                                                                               + "\n" + p_hours + " Hours"
                                                                               + "\n" + p_minutes + " Minutes"
                                                                               , "Switched To Custom+ Config");

        }

        // CREATECFG
        //
        // This method will create or update the config file based on the parameters it is given.
        //    This method expects STRINGS to be passed to it which indicate the amount of time to
        //       be set as well as the type of configuration file being set.
        private void CreateCFG(string years, string months, string days, string hours, string minutes, string cfg_type)
        {
            // Create a stream writer to delete the contents of the config file if it exists already
            //    (which it should unless the user deleted it).
            FileStream fs = File.Create("guard_config.txt");

            // Close the file stream for data integrity and to avoid any "weird errors"
            fs.Close();

            // Now we create a stream writer to open the now blank file and write the configuration
            //    settings that we have been passed. Use WriteLineAsync to avoid having to newline
            //    all this stuff.
            StreamWriter sw = new StreamWriter("guard_config.txt");
            sw.WriteLineAsync("Years = " + years);
            sw.WriteLineAsync("Months = " + months);
            sw.WriteLineAsync("Days = " + days);
            sw.WriteLineAsync("Hours = " + hours);
            sw.WriteLineAsync("Minutes = " + minutes);

            // Now we add one further line to indicate what type of configuration scheme this is.
            sw.WriteLineAsync(cfg_type);

            // Close the stream writer object.
            sw.Close();

            // Display a message to the user to let them know that the process happened.
            MessageBox.Show("Config File Updated.");
        }

        // LETSCHECK
        //
        // This method checks to see whether the given input is empty and will default the value
        //    to 0 if it detects an empty input.
        private string LetsCheck(string isEmpty)
        {
            // CHECK FOR NULL/EMPTY BOX
            // Check for null input, which, in this case would be an empty string.
            if (isEmpty == "")
            {
                // If there are empty strings, then the user has not input anything into
                //    some of the boxes, in which case we assume they meant 0.
                isEmpty = "0";
            }

            // Return the string
            return isEmpty;
        }

        // SANITYCHECK
        //
        // This method checks to make sure an input is sane (ie: is numerical). If it is
        //    numerical then it will simply return the check string AS IS. IF, however, it
        //    detects that the check string contains "bad input" (eg: non-numerical data)
        //    then it will display a message warning the user of the issue. In order to warn
        //    the user the method asks for a string to indicate the name of the input being
        //    checked - this name is what will be displayed to the user!
        private string SanityCheck (string checkString, string nameOfVar)
        {
            // First lets declare an integer to check
            int checkMe;

            // Now declare a boolean value and set it equal to the output of int.TryParse.
            //    If this boolean turns out False, we have a problem. Otherwise - we have
            //    no problems.
            bool isNumeric = int.TryParse(checkString, out checkMe);

            // So now, if the isNumeric is False, we have a problem.
            if (isNumeric == false)
            {
                // Immediately set the value to 0 just in case
                checkString = "0";

                // Warn the user what just happened so they can correct it!
                MessageBox.Show("The box " + nameOfVar + " does not appear to contain numbers. Please ensure you have not entered spaces, letters, or symbols into this box and try again. " +
                    "As a precaution this value was set to zero.", nameOfVar + " Error");
            }

            // Return the string
            return checkString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ignore Me
        }

    }


}
