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
    public partial class Form1 : Form
    {
        // For making the panel draggable
        bool drag4 = false;
        Point start_point4 = new Point(0, 0);

        // Initialize the form
        public Form1()
        {
            InitializeComponent();
        }

        // Allow the top panel to function as an actual windows header bar.
        private void topPanel4_MouseDown(object sender, MouseEventArgs e)
        {
            drag4 = true;
            start_point4 = new Point(e.X, e.Y);
        }

        // Now we allow the top panel to drag the windows around on the users screen.
        private void topPanel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag4)
            {
                Point s = PointToScreen(e.Location);
                this.Location = new Point(s.X - start_point4.X, s.Y - start_point4.Y);
                this.Update();
            }
        }

        // When the user lets go of the mouse, set the drag back to false
        private void topPanel4_MouseUp(object sender, MouseEventArgs e)
        {
            drag4 = false;
        }

        // CLOSE BUTTON
        private void closeButtonPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
