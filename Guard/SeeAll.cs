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

namespace Guard
{
    public partial class SeeAll : Form
    {
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

            // Call clear on TextBox (to get rid of any placeholder text)
            allDatesTextBox.Clear();

            // Call refresh data to issue the select statement and fill the
            //    textboxes with the proper data.
            RefreshData();
        }


        
        // Same function as in MainWindow.cs, but with no limit on the select statement.
        private void RefreshData()
        {
            // Initialize GuardTime
            GuardTime guard = new GuardTime();

            // Issue a new SELECT query for the Dates table.
            SQLize selectDates = new SQLize("SELECT datetime FROM (SELECT * FROM Dates ORDER BY date_id DESC) ORDER BY date_id");

            // Call selectDates to read the data
            selectDates.Read_Dates();

            // Set the output of SQLize's Get_Out method to the all dates textbox.text
            allDatesTextBox.Text = selectDates.Get_Out();

            // Issue a COUNT query for the Dates table.
            SQLize countDates = new SQLize("SELECT COUNT(date_id) FROM Dates");

            // Run that command
            countDates.Count_Query();

            // Set the output of SQLize's Get_Out method to the numEntries Label.text
            numEntriesLabel.Text = countDates.Get_Out(); 
        }

        // This button exports the database contents as it is shown in Guard (AKA non-epoch time)
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
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(allDatesTextBox.Text);
                sw.Close();

                MessageBox.Show("Saved Successfully!");
            }


        }
    }
}
