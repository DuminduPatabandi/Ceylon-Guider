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
    public partial class AdvisorPage : Form
    {
        public AdvisorPage()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            TravelAdvisorDisplay travel = new TravelAdvisorDisplay();
            travel.Show();
            this.Close();
        }
    }
}
