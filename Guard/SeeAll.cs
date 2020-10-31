using System;
using System.IO;
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
    public partial class SeeAll : Form
    {
        // Create our dataset object
        DataSet ds = new DataSet();

        int test = 0;

        // Making the top panel Draggable in order to create a nicer UI.
        bool drag = false;
        Point start_point = new Point(0, 0);

        // This allows the top panel to function as an actual windows header bar.
        private void seeAllTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        // Now we allow the top panel to drag the windows around on the users screen.
        private void seeAllTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
                this.Update();
            }
        }

        // When the user lets go odf the mouse, set drag back to false
        private void seeAllTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        // CLOSE BUTTON
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // BEGIN MAIN SEE ALL CODE
        public SeeAll()
        {
            InitializeComponent();

            // Call refresh stats to update things like record counts etc...
            RefreshStats();

            // Call refresh table to update our DataGridView
            RefreshTable();
        }


        
        // Refreshes Some Stats
        private void RefreshStats()
        {
            // Issue a COUNT query for the Dates table.
            SQLize countDates = new SQLize("SELECT COUNT(date_id) FROM Dates");

            // Run that command
            countDates.Count_Query();

            // Set the output of SQLize's Get_Out method to the numEntries Label.text
            numEntriesLabel.Text = countDates.Get_Out(); 
        }

        // Refresh the table by updating the gregorian table in sqlite and then reading it into the table.
        private void RefreshTable()
        {
            // Initialize Guardtime
            GuardTime guard = new GuardTime();

            // Populate the Gregorian Table
            SQLize GenerateTimes = new SQLize("SELECT datetime FROM (SELECT * FROM Dates ORDER BY date_id DESC) ORDER BY date_id");

            // Call PopulateTimestamps to update the Gregorian table
            GenerateTimes.PopulateTimestamps();

            
            // Create a connection to the DB.
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=GuardDB.sqlite;Version=3;");
            m_dbConnection.Open();
        
            // Create our adapter
            var adapter = new SQLiteDataAdapter("SELECT day_of_week, month, day, year, timestamp FROM Gregorian", m_dbConnection);

            // Fill the dataset object
            adapter.Fill(ds);

            // Close the connection to the DB
            m_dbConnection.Close();


            // Show this in the Data Grid View
            guardDatesDGV.DataSource = ds.Tables[0].DefaultView;

            
        }

        //This button exports the database contents as it is shown in Guard (AKA non-epoch time)
        private void exportFriendlyButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Create a stream writer object
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                // Create a string builder object
                StringBuilder str = new StringBuilder();

                // Hardcoded Column headers for now (Needs a fixin'!)
                str.Append("Day Of Week" + ",");
                str.Append("Month" + ",");
                str.Append("Day" + ",");
                str.Append("Year" + ",");
                str.Append("Time" + ",");
                str.Append(System.Environment.NewLine);

                // Start looping through the dataset we imported!

                
                foreach (DataTable table in ds.Tables) // for every table in the dataset
                {
                    foreach (DataRow row in table.Rows) // for every row in each table
                    {
                        foreach (DataColumn column in table.Columns) // for every column in that table
                        {
                            object item = row[column]; // an object called item is the combination of the row and the column

                            str.Append(item.ToString() + ","); // append it!
                            
                        }

                        str.Replace(",", System.Environment.NewLine, str.Length - 1, 1); // after every row, insert a new line character instead!

                    }
                }


                // Dump the contents of str into the CSV file.
                sw.Write(str);
                
                // Close the StreamWriter object!
                sw.Close();

                // Let the User know stuff happened!
                MessageBox.Show("Saved Successfully!");

            }


        }

        private void guardDatesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // User clicks on Report Button
        private void reportButton_Click(object sender, EventArgs e)
        {
            Report r2 = new Report();
            r2.ShowDialog();
        }
    }
}
