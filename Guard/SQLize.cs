using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Guard
{
    class SQLize
    {
        // Declare and initialize some variables to keep C# happy.
        string commandString = "";
        string aReturn = "";
        Int64 aReturnInt = 0;

        // Constructors
        // Sets the command!
        public SQLize (string commandString)
        {
            this.commandString = commandString;
        }



        // METHODS
        
        // GET_OUT()
        // This method returns the aReturn string whose contents is set from
        //    the Read_Dates and Read_Ach methods.
        public string Get_Out()
        {
            return aReturn;
        }

        public Int64 Get_OutInt()
        {
            return aReturnInt;
        }


        // RUN_COMMAND()
        // This method establishes a connection to the Guard Database and executes
        //    a command via SQLiteCommand from System.Data.SQLite.
        public void Run_Command()
        {
            // Create a connection to the DB.
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3;");
            m_dbConnection.Open();

            // Create our command
            SQLiteCommand command = new SQLiteCommand(commandString, m_dbConnection);

            // Execute our command
            command.ExecuteNonQuery();

            // Close the connection to the DB
            m_dbConnection.Close();
        }


        // READ_DATES()
        // This method reads dates from the dates table into the 'aReturn' string and
        //    includes formatting for new lines so that the text can be displayed in
        //    a textbox control.
        public void Read_Dates()
        {
            // Start GuardTime
            GuardTime guard = new GuardTime();
            
            // Create a connection to the DB.
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3;");
            m_dbConnection.Open();

            // Create our command
            SQLiteCommand command = new SQLiteCommand(commandString, m_dbConnection);

            // Start the reader
            SQLiteDataReader reader = command.ExecuteReader();

            // While the reader has data to read, append the text to the 'aReturn' string
            while (reader.Read())
            {
                // Declare holder string
                string holder = "";
                
                // Grab the value and feed it to GuardTime which will convert it to a string that's human readable
                //    and set our holder string to this.
                holder = guard.EpochToDateString(reader.GetInt64(0));

                // Remove the GMT info from the output (it's not really necessary for the user to see and takes up space).
                holder = guard.RemoveGMT(holder);

                // Append the values for every date we encounter.
                aReturn += holder + "\r\n";
            }

            // Close the connection to the DB
            m_dbConnection.Close();

        }

        // PopulateTimeStamps
        //
        // This reads dates from the dates table into the 'aList' List. Effectively copies the Dates Table!
        public void PopulateTimestamps()
        {   
            // Create a counter variable
            int i = 1;

            // Start GuardTime
            GuardTime guard = new GuardTime();

            // Create a connection to the DB.
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3;");
            m_dbConnection.Open();

            // Create our command
            SQLiteCommand command = new SQLiteCommand(commandString, m_dbConnection);

            // Start the reader
            SQLiteDataReader reader = command.ExecuteReader();

            // While the reader has data to read, add the value to the list.
            while (reader.Read())
            {
                // Make some holder values;
                string month;
                string day;
                string day_of_week;
                string year;
                string time;

                // Test value for reader.read
                Int64 test = reader.GetInt64(0);

                // Initialize a DTO
                DateTimeOffset dto = new DateTimeOffset();

                // Get Guard to give us the DTO of the current line
                dto = guard.EpochToDTO(reader.GetInt64(0));

                // Pull the information
                // month = guard.MonthToString(dto.Month);
                month = dto.ToString("MMMM");
                day = dto.Day.ToString();
                day_of_week = dto.DayOfWeek.ToString();
                year = dto.Year.ToString();
                time = dto.TimeOfDay.ToString();              

                // Create a SQLite Command to insert stuff
                SQLiteCommand populate = new SQLiteCommand("INSERT OR IGNORE INTO Gregorian (greg_id, month, day, day_of_week, year, timestamp)" +
                                                           "VALUES (" + i + "," + "'" + month + "'" + "," + "'" + day + "'" + "," + "'" + day_of_week + "'" + "," + "'" + year +
                                                                    "'" + "," + "'" + time + "'" + ")", m_dbConnection);

                // Run that command!
                populate.ExecuteNonQuery();

                // Increment the counter
                i++;
            }

        }

        // READ_ACH()
        // This method reads the achievements from the Achievements table an formats it for use
        //    in a textbox control.
        public void Read_Ach()
        {
            // Start GuardTime
            GuardTime guard = new GuardTime();

            // Create a connection to the DB.
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3;");
            m_dbConnection.Open();

            // Create our command
            SQLiteCommand command = new SQLiteCommand(commandString, m_dbConnection);

            // Start the reader
            SQLiteDataReader reader = command.ExecuteReader();

            // While the reader has data to read, Feed it 
            while (reader.Read())
            {
                // Get our values.
                Int64 bestTime = reader.GetInt64(1);

                // If the record is 0 (ie has no timestamp data) don't do any of this because a best time doesn't exist.
                if (bestTime != 0)
                {
                    // Grab our calculation
                    // ***DEPRECATED*** The resultTime IS bestTime.
                    // 
                    // Int64 resultTime = guard.CalcUnixTimeSpan(startTime, endTime);

                    // Throw this into guards converter
                    string s = guard.EpochLenToString(bestTime);

                    // Concatenate our return string with nicely formatted text using Guards
                    //    pretty print option.
                    aReturn += guard.PrettyPrintAch(s) + "\r\n";

                    // Concatenate our return string.
                    //old method aReturn += guard.EpochLenToString(resultTime) + "\r\n";

                }                               
            }

            // Close the connection to the DB
            m_dbConnection.Close();
        }

        // READ_ONEDATE()
        // This method reads a date from the dates table into the 'aReturn' string.
        public String Read_OneDate()
        {
            // Create a connection to the DB.
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3;");
            m_dbConnection.Open();

            // Create our command
            SQLiteCommand command = new SQLiteCommand(commandString, m_dbConnection);

            // Start the reader
            SQLiteDataReader reader = command.ExecuteReader();

            // While the reader has data to read, append the text to the 'aReturn' string
            while (reader.Read())
            {
                aReturn = reader.GetInt64(1).ToString();
            }


            // Close the connection to the DB
            m_dbConnection.Close();

            return aReturn;
        }

        // READ_ONEDATEINT
        //
        // This returns the Integer value representative of the unix timestamp associated with a date in
        //    the dates table. It's original purpose is to be used to return a date before a new date is
        //    inserted in order to perform best_time calculations.
        public Int64 Read_OneDateInt()
        {
            // Create a connection to the DB
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3;");
            m_dbConnection.Open();

            // Create our command
            SQLiteCommand command = new SQLiteCommand(commandString, m_dbConnection);

            // Start the reader
            SQLiteDataReader reader = command.ExecuteReader();

            // Grab our last date
            while (reader.Read())
            {
                aReturnInt = reader.GetInt64(1);
            }

            // Close the connection to the DB
            m_dbConnection.Close();

            // Return the value;
            return aReturnInt;
        }

        // COUNT_QUERY
        //
        // Used for running count queries or queries in which a SINGLE number will be returned.
        public String Count_Query()
        {
            // Create a connection to the DB
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3;");
            m_dbConnection.Open();

            // Create our command
            SQLiteCommand command = new SQLiteCommand(commandString, m_dbConnection);

            // Start the reader
            SQLiteDataReader reader = command.ExecuteReader();

            // Shove the results into the return string
            while (reader.Read())
            {
                aReturn = reader.GetInt64(0).ToString();
            } 

            // Close the connection to the DB
            m_dbConnection.Close();

            // Return the value;
            return aReturn;
        }


    }
}
