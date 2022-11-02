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
    public partial class FoodDisplay : Form
    {
        public FoodDisplay()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrderMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ordered Successfully","Information",MessageBoxButtons.OKCancel);
        }

        private void btnOrderMe2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ordered Successfully", "Information", MessageBoxButtons.OKCancel);
        }

        private void btnOrderMe3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ordered Successfully", "Information", MessageBoxButtons.OKCancel);
        }

        private void btnOrderMe4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ordered Successfully", "Information", MessageBoxButtons.OKCancel);
        }

        private void FoodDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
