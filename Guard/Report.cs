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
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace Guard
{
    public partial class Report : Form
    {
        // Create dataset object
        DataSet ds = new DataSet();

        // Another dataset object
        DataSet dt2 = new DataSet();

        // A DataTable object
        DataTable dt = new DataTable();

        

        public Report()
        {
            InitializeComponent();

            GetStats();
            FindAverages();
            WeeklyAverage();
            GenChart();
            GenTrend();


        }

        private void GetStats()
        {


            // Create a connection to the DB
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3");
            m_dbConnection.Open();

            // Create our adapters
            var adapter0 = new SQLiteDataAdapter("SELECT year, COUNT(timestamp) AS totals FROM Gregorian GROUP BY year", m_dbConnection);


            // Fill the dataset object
            adapter0.Fill(ds);


            // Show this in the Data Grid View
            annualDGV.DataSource = ds.Tables[0].DefaultView;


            // Close the connection to the DB
            m_dbConnection.Close();
        }

        private void FindAverages()
        {
            // This is lazy, should fix

            // Define variables
            var thisMonth = DateTime.Today;
            var lastMonth = DateTime.Today.AddMonths(-1);
            var thirdMonth = DateTime.Today.AddMonths(-2);
            var fourthMonth = DateTime.Today.AddMonths(-3);
            var fifthMonth = DateTime.Today.AddMonths(-4);
            var sixthMonth = DateTime.Today.AddMonths(-5);
            var seventhMonth = DateTime.Today.AddMonths(-6);
            var thisYear = DateTime.Today.Year.ToString("yyyy", CultureInfo.InvariantCulture);
            var lastYear = DateTime.Today.AddYears(-1);
            Int64 threeAvg = 0;
            Int64 sixAvg = 0;
            Int64 weekAvg = 0;

            // Create a connection to the DB
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3");
            m_dbConnection.Open();
            
            // Check for special cases! (switch case pitched a fit so if/else it is for now
            if (thisMonth.ToString("MMMM", CultureInfo.InvariantCulture) == "January")
            {
                string currMonth = thisMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string prevMonth = lastMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string thrdMonth = thirdMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string frthMonth = fourthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string ffthMonth = fifthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string sxthMonth = sixthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string svnhMonth = seventhMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string currYear = thisMonth.ToString("yyyy", CultureInfo.InvariantCulture);
                string prevYear = lastYear.ToString("yyyy", CultureInfo.InvariantCulture);

                SQLiteCommand FindThreeMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE (month = '" + prevMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                                + "OR (month = '" + thrdMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                                + "OR (month = '" + frthMonth + "'" + "AND year=" + prevYear + ")", m_dbConnection);

                SQLiteCommand FindSixMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE (month = '" + prevMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                                + "OR (month = '" + thrdMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                                + "OR (month = '" + frthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                                + "OR (month = '" + ffthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                                + "OR (month = '" + sxthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                                + "OR (month = '" + svnhMonth + "'" + "AND year=" + prevYear + ")", m_dbConnection);

                SQLiteDataReader threeMonth = FindThreeMonth.ExecuteReader();
                while (threeMonth.Read())
                {
                    threeAvg = threeMonth.GetInt64(1);
                }

                SQLiteDataReader sixMonth = FindSixMonth.ExecuteReader();
                while (sixMonth.Read())
                {
                    sixAvg = sixMonth.GetInt64(1);
                }

                //weekAvg = threeAvg / 15;
                threeAvg = threeAvg / 3;
                sixAvg = sixAvg / 6;

                sixMonthAvgLabel.Text = sixAvg.ToString();
                threeMonthAvgLabel.Text = threeAvg.ToString();
                //fiveWeekAvgLabel.Text = weekAvg.ToString();
            }
            
            if (thisMonth.ToString("MMMM", CultureInfo.InvariantCulture) == "February")
            {
                string currMonth = thisMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string prevMonth = lastMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string thrdMonth = thirdMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string frthMonth = fourthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string ffthMonth = fifthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string sxthMonth = sixthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string svnhMonth = seventhMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string currYear = thisMonth.ToString("yyyy", CultureInfo.InvariantCulture);
                string prevYear = lastYear.ToString("yyyy", CultureInfo.InvariantCulture);

                SQLiteCommand FindThreeMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE (month = '" + prevMonth + "'" + "AND year=" + currYear + ")"
                                                                                                                + "OR (month = '" + thrdMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                                + "OR (month = '" + frthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                                + " GROUP BY month", m_dbConnection);

                SQLiteCommand FindSixMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE (month = '" + prevMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + thrdMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                + "OR (month = '" + frthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                + "OR (month = '" + ffthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                + "OR (month = '" + sxthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                + "OR (month = '" + svnhMonth + "'" + "AND year=" + prevYear + ")", m_dbConnection);

                SQLiteDataReader threeMonth = FindThreeMonth.ExecuteReader();
                while (threeMonth.Read())
                {
                    threeAvg = threeMonth.GetInt64(1);
                }

                SQLiteDataReader sixMonth = FindSixMonth.ExecuteReader();
                while (sixMonth.Read())
                {
                    sixAvg = sixMonth.GetInt64(1);
                }

                //weekAvg = threeAvg / 15;
                threeAvg = threeAvg / 3;
                sixAvg = sixAvg / 6;

                threeMonthAvgLabel.Text = threeAvg.ToString();
                sixMonthAvgLabel.Text = sixAvg.ToString();
                //fiveWeekAvgLabel.Text = weekAvg.ToString();
            }

            if (thisMonth.ToString("MMMM", CultureInfo.InvariantCulture) == "March")
            {
                string currMonth = thisMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string prevMonth = lastMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string thrdMonth = thirdMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string frthMonth = fourthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string ffthMonth = fifthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string sxthMonth = sixthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string svnhMonth = seventhMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string currYear = thisMonth.ToString("yyyy", CultureInfo.InvariantCulture);
                string prevYear = lastYear.ToString("yyyy", CultureInfo.InvariantCulture);

                SQLiteCommand FindThreeMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE (month = '" + prevMonth + "'" + "AND year=" + currYear + ")"
                                                                                                                + "OR (month = '" + thrdMonth + "'" + "AND year=" + currYear + ")"
                                                                                                                + "OR (month = '" + frthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                                + " GROUP BY month", m_dbConnection);

                SQLiteCommand FindSixMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE (month = '" + prevMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + thrdMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + frthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                + "OR (month = '" + ffthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                + "OR (month = '" + sxthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                + "OR (month = '" + svnhMonth + "'" + "AND year=" + prevYear + ")", m_dbConnection);

                SQLiteDataReader threeMonth = FindThreeMonth.ExecuteReader();
                while (threeMonth.Read())
                {
                    threeAvg = threeMonth.GetInt64(1);
                }

                SQLiteDataReader sixMonth = FindSixMonth.ExecuteReader();
                while (sixMonth.Read())
                {
                    sixAvg = sixMonth.GetInt64(1);
                }

                //weekAvg = threeAvg / 15;
                threeAvg = threeAvg / 3;
                sixAvg = sixAvg / 6;

                threeMonthAvgLabel.Text = threeAvg.ToString();
                sixMonthAvgLabel.Text = sixAvg.ToString();
                //fiveWeekAvgLabel.Text = weekAvg.ToString();
            }

            if (thisMonth.ToString("MMMM", CultureInfo.InvariantCulture) == "April")
            {
                string currMonth = thisMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string prevMonth = lastMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string thrdMonth = thirdMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string frthMonth = fourthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string ffthMonth = fifthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string sxthMonth = sixthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string svnhMonth = seventhMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string currYear = thisMonth.ToString("yyyy", CultureInfo.InvariantCulture);
                string prevYear = lastYear.ToString("yyyy", CultureInfo.InvariantCulture);

                SQLiteCommand FindThreeMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE (month = '" + prevMonth + "'" + "AND year=" + currYear + ")"
                                                                                                                + "OR (month = '" + thrdMonth + "'" + "AND year=" + currYear + ")"
                                                                                                                + "OR (month = '" + frthMonth + "'" + "AND year=" + currYear + ")"
                                                                                                                + " GROUP BY month", m_dbConnection);

                SQLiteCommand FindSixMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE (month = '" + prevMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + thrdMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + frthMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + ffthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                + "OR (month = '" + sxthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                + "OR (month = '" + svnhMonth + "'" + "AND year=" + prevYear + ")", m_dbConnection);

                SQLiteDataReader threeMonth = FindThreeMonth.ExecuteReader();
                while (threeMonth.Read())
                {
                    threeAvg = threeMonth.GetInt64(1);
                }

                SQLiteDataReader sixMonth = FindSixMonth.ExecuteReader();
                while (sixMonth.Read())
                {
                    sixAvg = sixMonth.GetInt64(1);
                }

                //weekAvg = threeAvg / 15;
                threeAvg = threeAvg / 3;
                sixAvg = sixAvg / 6;

                threeMonthAvgLabel.Text = threeAvg.ToString();
                sixMonthAvgLabel.Text = sixAvg.ToString();
               //fiveWeekAvgLabel.Text = weekAvg.ToString();
            }

            if (thisMonth.ToString("MMMM", CultureInfo.InvariantCulture) == "May")
            {
                string currMonth = thisMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string prevMonth = lastMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string thrdMonth = thirdMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string frthMonth = fourthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string ffthMonth = fifthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string sxthMonth = sixthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string svnhMonth = seventhMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string currYear = thisMonth.ToString("yyyy", CultureInfo.InvariantCulture);
                string prevYear = lastYear.ToString("yyyy", CultureInfo.InvariantCulture);

                SQLiteCommand FindThreeMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE (month = '" + prevMonth + "'" + "AND year=" + currYear + ")"
                                                                                                                + "OR (month = '" + thrdMonth + "'" + "AND year=" + currYear + ")"
                                                                                                                + "OR (month = '" + frthMonth + "'" + "AND year=" + currYear + ")"
                                                                                                                + " GROUP BY month", m_dbConnection);

                SQLiteCommand FindSixMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE (month = '" + prevMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + thrdMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + frthMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + ffthMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + sxthMonth + "'" + "AND year=" + prevYear + ")"
                                                                                                + "OR (month = '" + svnhMonth + "'" + "AND year=" + prevYear + ")", m_dbConnection);

                SQLiteDataReader threeMonth = FindThreeMonth.ExecuteReader();
                while (threeMonth.Read())
                {
                    threeAvg = threeMonth.GetInt64(1);
                }

                SQLiteDataReader sixMonth = FindSixMonth.ExecuteReader();
                while (sixMonth.Read())
                {
                    sixAvg = sixMonth.GetInt64(1);
                }

                //weekAvg = threeAvg / 15;
                threeAvg = threeAvg / 3;
                sixAvg = sixAvg / 6;

                threeMonthAvgLabel.Text = threeAvg.ToString();
                sixMonthAvgLabel.Text = sixAvg.ToString();
                //fiveWeekAvgLabel.Text = weekAvg.ToString();
            }

            if (thisMonth.ToString("MMMM", CultureInfo.InvariantCulture) == "June")
            {
                string currMonth = thisMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string prevMonth = lastMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string thrdMonth = thirdMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string frthMonth = fourthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string ffthMonth = fifthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string sxthMonth = sixthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string svnhMonth = seventhMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string currYear = thisMonth.ToString("yyyy", CultureInfo.InvariantCulture);
                string prevYear = lastYear.ToString("yyyy", CultureInfo.InvariantCulture);

                SQLiteCommand FindThreeMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE (month = '" + prevMonth + "'" + "AND year=" + currYear + ")"
                                                                                                                + "OR (month = '" + thrdMonth + "'" + "AND year=" + currYear + ")"
                                                                                                                + "OR (month = '" + frthMonth + "'" + "AND year=" + currYear + ")"
                                                                                                                + " GROUP BY month", m_dbConnection);

                SQLiteCommand FindSixMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE (month = '" + prevMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + thrdMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + frthMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + ffthMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + sxthMonth + "'" + "AND year=" + currYear + ")"
                                                                                                + "OR (month = '" + svnhMonth + "'" + "AND year=" + prevYear + ")", m_dbConnection);

                SQLiteDataReader threeMonth = FindThreeMonth.ExecuteReader();
                while (threeMonth.Read())
                {
                    threeAvg = threeMonth.GetInt64(1);
                }

                SQLiteDataReader sixMonth = FindSixMonth.ExecuteReader();
                while (sixMonth.Read())
                {
                    sixAvg = sixMonth.GetInt64(1);
                }

                //weekAvg = threeAvg / 15;
                threeAvg = threeAvg / 3;
                sixAvg = sixAvg / 6;

                threeMonthAvgLabel.Text = threeAvg.ToString();
                sixMonthAvgLabel.Text = sixAvg.ToString();
                //fiveWeekAvgLabel.Text = weekAvg.ToString();
            }

            else
            {
                string currMonth = thisMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string prevMonth = lastMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string thrdMonth = thirdMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string frthMonth = fourthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string ffthMonth = fifthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string sxthMonth = sixthMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string svnhMonth = seventhMonth.ToString("MMMM", CultureInfo.InvariantCulture);
                string currYear = thisMonth.ToString("yyyy", CultureInfo.InvariantCulture);
                string prevYear = lastYear.ToString("yyyy", CultureInfo.InvariantCulture);

                SQLiteCommand FindThreeMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE month IN ('" + prevMonth + "'" + ","
                                                                                                                        + "'" + thrdMonth + "'" + ","
                                                                                                                        + "'" + svnhMonth + "'"
                                                                                                                        + ") AND year = " + currYear + "", m_dbConnection);

                SQLiteCommand FindSixMonth = new SQLiteCommand("SELECT month, COUNT(timestamp) AS total FROM Gregorian WHERE month IN ('" + prevMonth + "'" + ","
                                                                                                                        + "'" + thrdMonth + "'" + ","
                                                                                                                        + "'" + frthMonth + "'" + ","
                                                                                                                        + "'" + ffthMonth + "'" + ","
                                                                                                                        + "'" + sxthMonth + "'" + ","
                                                                                                                        + "'" + svnhMonth + "'"
                                                                                                                        + ") AND year = " + currYear + "", m_dbConnection);

                SQLiteDataReader threeMonth = FindThreeMonth.ExecuteReader();
                while (threeMonth.Read())
                {
                    threeAvg = threeMonth.GetInt64(1);
                }

                SQLiteDataReader sixMonth = FindSixMonth.ExecuteReader();
                while (sixMonth.Read())
                {
                    sixAvg = sixMonth.GetInt64(1);
                }

                //weekAvg = threeAvg / 15;
                threeAvg = threeAvg / 3;
                sixAvg = sixAvg / 6;

                threeMonthAvgLabel.Text = threeAvg.ToString();
                sixMonthAvgLabel.Text = sixAvg.ToString();
                //fiveWeekAvgLabel.Text = weekAvg.ToString();
            }

            m_dbConnection.Close();
        }

        private void WeeklyAverage()
        {
            Int64 ttsearch = 0;
            Int64 result = 0;

            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3");
            m_dbConnection.Open();

            // Create UnixTimestamp
            GuardTime gt = new GuardTime();
            var now = DateTime.Today;

            ttsearch = gt.DateToEpoch(now);
            ttsearch = ttsearch - 2592000;

            SQLiteCommand findInstances = new SQLiteCommand("SELECT COUNT(datetime) FROM dates WHERE datetime > " + ttsearch, m_dbConnection);

            SQLiteDataReader getInstances = findInstances.ExecuteReader();

            while (getInstances.Read())
            {
                result = getInstances.GetInt64(0);
            }

            result = result / 5;

            fiveWeekAvgLabel.Text = result.ToString();

            m_dbConnection.Close();
            
        }

        private void GenChart()
        {
            // Create a connection to the DB
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3");
            m_dbConnection.Open();

            var adapter = new SQLiteDataAdapter("SELECT * FROM (SELECT greg_id, month, year, COUNT(*) AS total FROM Gregorian GROUP BY month, year ORDER BY greg_id DESC LIMIT 12) ORDER BY greg_id ASC", m_dbConnection);

            adapter.Fill(dt2);

            m_dbConnection.Close();

            reportChart.DataSource = dt2;
            reportChart.Series["Series1"].ChartType = SeriesChartType.Line;
            reportChart.Series["Series1"].IsValueShownAsLabel = true;

            reportChart.Series["Series1"].XValueMember = "month";
            reportChart.Series["Series1"].YValueMembers = "total";
            reportChart.DataBind();



        }

        private void GenTrend()
        {
            // Get Current Month
            string currMonth = DateTime.Today.ToString("MMMM", CultureInfo.InvariantCulture);

            // Get Previous Month
            string prevMonth = DateTime.Today.AddMonths(-1).ToString("MMMM", CultureInfo.InvariantCulture);

            // Get Current Year
            string currYear = DateTime.Today.ToString("yyyy", CultureInfo.InvariantCulture);

            Int64 monthlyTotal = 0;
            Int64 prevTotal = 0;

            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3");
            m_dbConnection.Open();

            // Grab value from 3 month trend
            string threeMonthAVG_str = threeMonthAvgLabel.Text;
            Int64 threeMonthAVG = Convert.ToInt64(threeMonthAVG_str);
            //Int64 fiveWeekAVG = Convert.ToInt64(fiveWeekAvgLabel.Text);

            // Get months count
            SQLiteCommand currentMonthTotal = new SQLiteCommand("SELECT month, COUNT(*) AS total FROM Gregorian WHERE month = '" + currMonth + "' AND year = " + currYear + " LIMIT 1", m_dbConnection);

            // If January
            if (currMonth == "January")
            {
                string prevYear = DateTime.Today.AddYears(-1).ToString("yyyy", CultureInfo.InvariantCulture);

                SQLiteCommand prevMonthTotal = new SQLiteCommand("SELECT month, COUNT(*) AS total FROM Gregorian WHERE month = '" + prevMonth + "' AND year = " + prevYear + " LIMIT 1", m_dbConnection);
                SQLiteDataReader getPrevTotal = prevMonthTotal.ExecuteReader();

                while (getPrevTotal.Read())
                {
                    prevTotal = getPrevTotal.GetInt64(1);
                }
            }

            // If not January
            else
            {
                SQLiteCommand prevMonthTotal = new SQLiteCommand("SELECT month, COUNT(*) AS total FROM Gregorian WHERE month = '" + prevMonth + "' AND year = " + currYear + " LIMIT 1", m_dbConnection);
                SQLiteDataReader getPrevTotal = prevMonthTotal.ExecuteReader();
                
                while (getPrevTotal.Read())
                {
                    prevTotal = getPrevTotal.GetInt64(1);
                }
            }

            SQLiteDataReader getMonthlyTotal = currentMonthTotal.ExecuteReader();

            while (getMonthlyTotal.Read())
            {
                monthlyTotal = getMonthlyTotal.GetInt64(1);
            }

            // Check if current total is approaching past 3 month average
            double warningThresh = threeMonthAVG - 5;
            double criticalThresh = threeMonthAVG - 2;
            double thresh = threeMonthAVG - 1;
            double currWeekAvg = (monthlyTotal / 5);
            //double weeklySuggestion = Math.Round(currWeekAvg - fiveWeekAVG, 0);

            if (monthlyTotal < warningThresh)
            {
                trendOutLabel.Text = "Trending Down by " + (thresh - monthlyTotal);
                adviceTextBox.Text = "You are on track to continue trending downwards. You have " + (warningThresh - monthlyTotal) + " times left before you exceed your 3 month average and " + (prevTotal - monthlyTotal) + " times left this month before you endanger your trend.";
            }

            else if ((monthlyTotal >= warningThresh) & (monthlyTotal < criticalThresh))
            {
                trendOutLabel.Text = "Trending Slightly Down by " + (thresh - monthlyTotal);
                adviceTextBox.Text = "You are approaching your three month average. You have " + (thresh - monthlyTotal) + " times left before you exceed your 3 month average and " + (prevTotal - monthlyTotal) + " times left this month before you endanger your trend.";
            }

           else if ((monthlyTotal >= criticalThresh) & (monthlyTotal < thresh))
            {
                trendOutLabel.Text = "Trending Steady";
                adviceTextBox.Text = "You have hit your three month average. You have " + (prevTotal - monthlyTotal) + "times left before you trend upwards.";
            }

            else if (monthlyTotal == threeMonthAVG)
            {
                trendOutLabel.Text = "Trending Steady";
                adviceTextBox.Text = "You have hit your three month average.";

                if (monthlyTotal > prevTotal)
                {
                    adviceTextBox.Text += " You trending upwards at a rate of + " + (monthlyTotal - prevTotal) + " times this month";
                }

                else if (monthlyTotal == prevTotal)
                {
                    adviceTextBox.Text += " You are trending steady. Instances are equal with last months.";
                }

                else
                {
                    adviceTextBox.Text += " You are still trending downwards from last month at a rate of -" + (prevTotal - monthlyTotal) + " times this month";
                }

            }

            else
            {
                trendOutLabel.Text = "Trending Up by " + (monthlyTotal - prevTotal) ;
                
                if (monthlyTotal >= prevTotal)
                {
                    adviceTextBox.Text = "You have exceeded your three month average and are trending upwards at a rate of +" + (monthlyTotal - prevTotal) + " times this month";
                }

                else
                {
                    adviceTextBox.Text = "You have exceeded your three month average. You have " + (prevTotal - monthlyTotal) + " times left before you trend upwards.";
                }
            }

            bool test1 = (monthlyTotal > warningThresh);

        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            //Do nothing
        }
    }
}
