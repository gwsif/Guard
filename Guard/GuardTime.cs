using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Globalization;

namespace Guard
{
    class GuardTime
    {
        // Parameters
        int tracker;
        string config_type;
        string dateStringRaw;
        string holder;

        Int64 years;
        Int64 months;
        Int64 days;
        Int64 hours;
        Int64 minutes;

        string s_month;
        string s_day;
        string s_year;
        string s_time;

        // Constructors
        // Sets the params
        public GuardTime(int years, int months, int days, int hours, int minutes)
        {
            this.years = years;
            this.months = months;
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }

        public GuardTime(string s_month, string s_day, string s_year, string s_time)
        {
            this.s_month = s_month;
            this.s_day = s_day;
            this.s_year = s_year;
            this.s_time = s_time;

        }

        public GuardTime()
        {

        }

        public void setConfig()
        {
            // If the file does NOT exist, then create it and set it's properties
            //    to the default values.
            if (!File.Exists("guard_config.txt"))
            {            
                // Create a stream writer to create the config file.
                FileStream fs = File.Create("guard_config.txt");
                fs.Close();

                // Create a stream writer to open the file and write the default configs.
                StreamWriter sw = new StreamWriter("guard_config.txt");
                sw.WriteLineAsync("Years = " + 0);
                sw.WriteLineAsync("Months = " + 0);
                sw.WriteLineAsync("Days = " + 86400);
                sw.WriteLineAsync("Hours = " + 43200);
                sw.WriteLineAsync("Minutes = " + 0);

                // Write a line to indicate which type of file this is
                sw.WriteLineAsync("default");

                // Close the file
                sw.Close();
            }

            // Read the contents of the file into an array
            string[] lines = File.ReadLines("guard_config.txt").ToArray();

            // Assign our raw strings using Regex which will pull the numbers out
            Int64 years = Convert.ToInt64(Regex.Match(lines[0], @"\d+").Value);
            Int64 months = Convert.ToInt64(Regex.Match(lines[1], @"\d+").Value);
            Int64 days = Convert.ToInt64(Regex.Match(lines[2], @"\d+").Value);
            Int64 hours = Convert.ToInt64(Regex.Match(lines[3], @"\d+").Value);
            Int64 minutes = Convert.ToInt64(Regex.Match(lines[4], @"\d+").Value);

            // Set the values
            this.years = years;
            this.months = months;
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;

            // Set our config type
            config_type = lines[5];
        }

        // Methods

        //RETURNGUARDDATETIME
        //
        // This method takes string parameters that represent a date (IE: 06 May 2019) and time
        //    and then returns a DateTime object that is properly formatted to Guard's defined
        //    DateTime specs.
        public DateTime ReturnGuardDateTime()
        {
            // Create a string that is representative of the date
            string dateStringRaw = s_day + " " + s_month + " " + s_year + " " + s_time;

            // Turn this into a DateTime Object
            DateTime inputDate = DateTime.Parse(dateStringRaw);

            // Return the DateTime Object
            return inputDate;

        }

        //RETURNGUARDDATESTRING
        //
        // This method takes string parameters that represent a date (IE: 06 May 2019) and time
        //    and then returns a string that is properly formatted to Guards defined DateTime
        //    specs.
        public string ReturnGuardDateString()
        {
            // set dateStringRaw so that it is representative of the date we were fed.
            dateStringRaw = s_day + " " + s_month + " " + s_year + " " + s_time;

            // Set the holder string to the dateStringRaw value
            holder = dateStringRaw;

            // Return the date string
            return dateStringRaw;
        }

        //TOGUARDDATETIME
        //
        // This method takes a string (from the database) and then returns the parsed DateTime object.
        public DateTime ToGuardDateTime(String rawDate)
        {
            if (rawDate == null)
            {
                DateTime nullDate = DateTime.ParseExact("01 January 1990 12:00:00 AM", "dd MMMM yyy hh:mm:ss tt", System.Globalization.CultureInfo.CurrentCulture);
                return nullDate;

            }

                DateTime aDate = DateTime.ParseExact(rawDate, "dd MMMM yyyy hh:mm:ss tt", System.Globalization.CultureInfo.CurrentCulture);

                return aDate;
            
            
        }


        //ADDAPOSTROPHES
        //
        // This method takes the raw date string and adds apostrophes around it so that it can be
        //    inserted into Guards Database.
        public string AddApostrophes()
        {
            // Create a new string that contains our holder
            string sqlString = "\'" + holder.ToString() + "\'";

            // Return our formatted string
            return sqlString;
        }

        //CALCRELEASEDATE
        //
        // This method takes a unix Timestamp Int 64 input that represents the starting event and then calculates 
        //    the release date based on config settings and returns a String that represents the 
        //    release date. It is intended to be used in tandem with ToGuardDateTime().
        public string CalcReleaseDate(Int64 unixInputDate)
        {            
            // Declare and initialize some local variables
            Int64 bestTime = 0;
            Int64 newStartPoint = 0;
            String returnString = "";

            // Go ahead and add our config times.
            newStartPoint = unixInputDate + years + months + days + hours + minutes;

            // If the config indicates that we should use our last achievement time in the calculations then
            //    we need to pull it and use it.
            if (config_type == "default" || config_type == "custom")
            {
                // Create a DB connection (we'll do this here for now, but eventually it should be abstracted into SQLizer)
                SQLiteConnection m_dbConnection;
                m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3;");
                m_dbConnection.Open();

                // Create a DB Command to get the latest achievement.
                SQLiteCommand getAch = new SQLiteCommand("SELECT * FROM Achievements ORDER BY best_time DESC LIMIT 1", m_dbConnection);

                // Create a data reader to get the value from the achievements table.
                SQLiteDataReader achReader = getAch.ExecuteReader();
                while (achReader.Read())
                {
                    // Grab the last time (which should be the highest time)
                    bestTime = achReader.GetInt64(1);
                }

                // Feed our start and end points into the CalcUnixTimeSpan function and have it calculate the time span for us.
                // ***NOTE THIS METHOD IS DEPRECATED***
                // elapsedTime IS now BestTime
                //
                //Int64 elapsedTime = CalcUnixTimeSpan(startPoint, endPoint);

                // Create a new timestamp based on the addition of the elapsed time and our original date
                Int64 goalDate = newStartPoint + bestTime;

                // Feed this goalDate timestamp into the EpochToDateString method and return whatever it spits out.
                returnString = EpochToDateString(goalDate);
            }
            else
            {
                // If the user is using custom plus settings then they only want to use a fixed interval, so don't bother
                //    looking through the achievements, just format the Epoch date and return it.
                returnString = EpochToDateString(newStartPoint);
            }


            return returnString;
                
            
        }

        // CALCRELEASEDATEINT
        //
        // This method is the same as CalcReleaseDate but instead returns a unix epoch time that is equivalent to the release date
        //    rather than a formatted string.
        public Int64 CalcReleaseDateInt(Int64 unixInputDate)
        {
            // Declare and initialize some local variables
            Int64 bestTime = 0;
            Int64 newStartPoint = 0;
            Int64 returnInt = 0;

            // Go ahead and add our config times.
            newStartPoint = unixInputDate + years + months + days + hours + minutes;

            // If the config indicates that we should use our last achievement time in the calculations then
            //    we need to pull it and use it.
            if (config_type == "default" || config_type == "custom")
            {
                // Create a DB connection (we'll do this here for now, but eventually it should be abstracted into SQLizer)
                SQLiteConnection m_dbConnection;
                m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3;");
                m_dbConnection.Open();

                // Create a DB Command to get the latest achievement.
                SQLiteCommand getAch = new SQLiteCommand("SELECT * FROM Achievements ORDER BY best_time DESC LIMIT 1", m_dbConnection);

                // Create a data reader to get the value from the achievements table.
                SQLiteDataReader achReader = getAch.ExecuteReader();
                while (achReader.Read())
                {
                    // Grab our start and end points
                    bestTime = achReader.GetInt64(1);
                }

                // Feed our start and end points into the CalcUnixTimeSpan function and have it calculate the time span for us.
                // ***NOTE THIS METHOD IS DEPRECATED***
                // elapsedTime IS now BestTime
                //
                // Feed our start and end points into the CalcUnixTimeSpan function and have it calculate the time span for us.
                // Int64 elapsedTime = CalcUnixTimeSpan(startPoint, endPoint);

                // Create a new timestamp based on the addition of the elapsed time and our original date
                Int64 goalDate = newStartPoint + bestTime;

                // Set the Return value equal to this new time stamp
                returnInt = goalDate;
            }
            else
            {
                // If the user is using custom plus settings then they only want to use a fixed interval, so don't bother
                //    looking through the achievements, just set the return int with the custom config settings added.
                returnInt = newStartPoint;
            }

            // return the return int.
            return returnInt;
        }

        // EPOCHLENTOSTRING
        //
        // This method takes an Int64 which represents a unix time and returns the length of time that 
        //    has elapsed as a string. 
        public string EpochLenToString (Int64 unixTime)
        {
            // Declare our return string
            string returnString = "";

            // Declare variables that define our times.
            // MAY NOT BE NECESSARY!
            uint secondsInYear = 31536000; //old value was 31557600
            uint secondsInMonth = 2592000;
            uint secondsInDay = 86400;
            uint secondsInHour = 3600;
            uint secondsInMinute = 60;

            // Use TimeSpan
            // Code courtesy of Farhad Jabiyev from StackOverflow
            //    -> https://stackoverflow.com/questions/23026148/how-to-convert-seconds-into-yearmonthday-hourminutesseconds-time
            //
            TimeSpan diff = TimeSpan.FromSeconds(unixTime);
            returnString = string.Format(CultureInfo.CurrentCulture, "{0} Years,{1} Months,{2} Days,{3} Hours,{4} Minutes,{5} Seconds", 
                                         diff.Days/365, 
                                         (diff.Days - (diff.Days / 365) * 365)/30,
                                         (diff.Days - (diff.Days / 365) * 365) - ((diff.Days - (diff.Days / 365) * 365) / 30)*30,
                                         diff.Hours,
                                         diff.Minutes,
                                         diff.Seconds);


            // Return the formatted string
            return returnString;
        }

        //EPOCHTODATESTRING
        //
        // This method takes an epoch time and converts it to a string that represents the date in human
        //    readable format.
        public string EpochToDateString(Int64 unixTime)
        {
            // Declare a return string
            string returnString = "";

            // As of .Net 4.6 we now have access to Unix time conversions. Handy for this exact thing.
            DateTimeOffset dto = DateTimeOffset.FromUnixTimeSeconds(unixTime).ToLocalTime();

            // Set our string value
            returnString = dto.ToString();

            // Return the string
            return returnString;
        }

        // DATETOEPOCH
        //
        // This method takes a DateTime object that is fed to it and converts it to an 64-bit Integer that is equivalent
        //    to the unix timestamp of the DateTime object.
        public Int64 DateToEpoch(DateTime inputDate)
        {
            // Set our Epoch time equal to the date we were fed minus the epoch start time (Jan 1, 1970).
            Int64 unixEpoch = (Int64)(inputDate.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

            // Return the Integer that represents the Epoch Time
            return unixEpoch;
        }

        // CALCUNIXTIMESPAN
        //
        // This method takes two 64-bit integers, which represent a start and a stop time and returns
        //    an integer representative of the elapsed time in Unix Time. 
        public Int64 CalcUnixTimeSpan(Int64 start, Int64 end)
        {
            //Declare a holder
            Int64 returnInt = 0;

            // As long as we were given an actual end-point then it is assumed we have a valid end-point.
            //    We should also be checking elsewhere before we are given start and end points, but "in
            //    case of fire, break glass" methodology is being used here. Better safe than sorry.
            if (end != 0)
            {
                returnInt = end - start;
            }

            return returnInt;
        }

        // GREGORIANINPUTTOEPOCH
        // Takes input such as Years, Months, Days, Hours, & Minutes and changes them into seconds so that
        //    they may be used for calculations on Unix Epoch Time. Requires the "type" of time being input
        //    to be passed
        public String GregorianInputToEpoch(String aString, String name)
        {
            // Declare and initialize a return string
            String returnString = "";

            // Declare an out Integer for TryParse.
            Int64 n = 0;

            // Check the value we are being passed an depending on which type it is, convert the value into seconds.
            switch (name)
            {
                // If it's a year, parse the string and multiply the value by the number of seconds in a year.
                case "years":
                    Int64.TryParse(aString, out n);
                    n = n * 31536000; //old value was 31557600
                    break;

                case "months":
                    Int64.TryParse(aString, out n);
                    n = n * 2592000;
                    break;

                case "days":
                    Int64.TryParse(aString, out n);
                    n = n * 86400;
                    break;

                case "hours":
                    Int64.TryParse(aString, out n);
                    n = n * 3600;
                    break;

                case "minutes":
                    Int64.TryParse(aString, out n);
                    n = n * 60;
                    break;
            }

            returnString = n.ToString();

            // Return the string
            return returnString;
        }

        // EPOCHTODATETIME
        //
        // Takes a unix timestamp and returns a datetime object that is equivalent to the timestamp.
        public DateTime EpochToDateTime(Int64 unixTime)
        {
            // Declare a return object
            DateTime formattedTime = new DateTime();

            // As of .NET 4.6 we have the ability to convert unix timestamps natively. So no wories.
            DateTimeOffset dto = DateTimeOffset.FromUnixTimeSeconds(unixTime).ToLocalTime();

            // Format this time
            formattedTime = dto.DateTime;

            // Return the formatted time.
            return formattedTime;
           
        }

        // REMOVEGMT
        //
        // Takes a string representing a timestamp and removes the GMT information from it.
        // Useful for simplifying UI.
        public string RemoveGMT(string hasGMT)
        {
            // Calling split on null, assumes whitespace to be the splitting character.
            // Our output strings look like this ""5/16/2019 12:06:04 AM -05:00"
            // So what we want to do is split each of these into an array, remove the "-05:00"
            // portion and then reassemble and return the string.
            string[] arrOfDate = hasGMT.Split(null);

            // As we can see the date should be at position 0, the time at 1, the AM/PM marker at 3, and
            //    the GMT that we want to remove at 4 - so lets reassemble the string, omitting position
            //    4.
            string withoutGMT = arrOfDate[0] + " " + arrOfDate[1] + " " + arrOfDate[2];

            return withoutGMT;
        }

        //PRETTYPRINTACH
        //
        // Takes a string representing an achievement time as generated by EpochLenToString() and then
        //    removes erroneous data (IE: if there's 0 years and 0 months, don't display those sections.
        public string PrettyPrintAch(string inputString)
        {
            // Create and initialize a holder string
            string holder = "";

            // Call string split on the comma character which is used by EpochLenToString as a delimiter.
            string[] arrOfDate = inputString.Split(',');

            // Now we can loop over it
            foreach (string s in arrOfDate)
            {

                // If the first digit is found to have a value other than zero then add it to our string
                if (s.Substring(0,1) != "0")
                {
                    holder += s + " ";

                }

                // If the first digit is a zero, double check to make sure that the second character isn't a number,
                //    in other words, lets not omit something like 04 days just because it starts with a zero.
                else if (s.Substring(1, 1) != null && Int32.TryParse(s.Substring(1, 1), out int n) == true)
            {
                    holder += s + " ";
            }

            }

            // Return the newly formatted string                      
            return holder;

            // COMPAREDATES
            //
            // 
        }
    }
}
