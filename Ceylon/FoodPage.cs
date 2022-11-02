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
    public partial class FoodPage : Form
    {
        public FoodPage()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            FoodDisplay foodPage = new FoodDisplay();
            foodPage.Show();
            this.Close();
            Rooms rooms = new Rooms();
            rooms.Close();
        }
    }
}
