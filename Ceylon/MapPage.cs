﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ceylon
{
    public partial class MapPage : Form
    {
        public MapPage()
        {
            InitializeComponent();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.apebodima.com");
        }
    }
}
