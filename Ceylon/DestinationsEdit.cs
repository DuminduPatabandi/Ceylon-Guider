using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ceylon
{
    public partial class DestinationsEdit : Form
    {
        DBAccess dBAccess = new DBAccess();
        public DestinationsEdit()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new ProfilePage().Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            String Destination_Name = txtDestination.Text;
            String District = txtDistrict.Text;
            String PageLink = txtLink.Text;



            SqlCommand insertComand = new SqlCommand("insert into Destination(Destination_Name,District,PageLink) values( @Destination_Name, @District, @PageLink)");

            insertComand.Parameters.AddWithValue("Destination_Name", Destination_Name);
            insertComand.Parameters.AddWithValue("District", District);
            insertComand.Parameters.AddWithValue("PageLink", PageLink);



            int row = dBAccess.executeQuery(insertComand);
        }
    }
}
