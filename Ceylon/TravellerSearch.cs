﻿using System;
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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new Rooms().Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
