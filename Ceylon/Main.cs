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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new Search().Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
