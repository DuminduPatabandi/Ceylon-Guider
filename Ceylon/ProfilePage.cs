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
    public partial class ProfilePage : Form
    {
 
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new RoomEdit().Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new FoodEdit().Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new TransportEdit().Show();
            this.Hide();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            new TravelEdit().Show();
            this.Hide();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            new DestinationsEdit().Show();
            this.Hide();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            txtUserName.Text = UserLogName.UserName;
            txtMail.Text = UserLogName.Email;
        }
    }
}
