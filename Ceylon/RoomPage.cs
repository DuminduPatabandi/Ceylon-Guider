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
    public partial class RoomPage : Form
    {
        public RoomPage()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            //RoomDisplay roomDisplay = new RoomDisplay();
            Application.Exit();

            new RoomDisplay().Show();
            //this.Hide();
        }
    }
}
