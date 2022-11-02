using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceylon
{
    public partial class DestinationDisplay : Form
    {
        public DestinationDisplay()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new Rooms().Show();
            this.Close();
        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Hanthana_Mountain_Range");
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
