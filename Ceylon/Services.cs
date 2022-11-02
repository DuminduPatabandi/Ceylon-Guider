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
    public partial class Rooms : Form
    {
        
        public Rooms()
        {
            InitializeComponent();
            this.FormLoader.Controls.Clear();
            RoomPage rooms = new RoomPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.FormLoader.Controls.Add(rooms);
            rooms.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            this.FormLoader.Controls.Clear();
            RoomPage rooms = new RoomPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.FormLoader.Controls.Add(rooms);
            rooms.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.FormLoader.Controls.Clear();
            Transport wheel = new Transport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.FormLoader.Controls.Add(wheel);
            wheel.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.FormLoader.Controls.Clear();
            FoodPage eat = new FoodPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.FormLoader.Controls.Add(eat);
            eat.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.FormLoader.Controls.Clear();
            AdvisorPage man = new AdvisorPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.FormLoader.Controls.Add(man);
            man.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.FormLoader.Controls.Clear();
            TrafficPage jam = new TrafficPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.FormLoader.Controls.Add(jam);
            jam.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.FormLoader.Controls.Clear();
            MapPage map = new MapPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.FormLoader.Controls.Add(map);
            map.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.FormLoader.Controls.Clear();
            DestinationPage yan = new DestinationPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.FormLoader.Controls.Add(yan);
            yan.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            new Search().Show();
            this.Hide();
        }
    }
}
