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
    public partial class TravelEdit : Form
    {
        DBAccess dBAccess = new DBAccess();
        public TravelEdit()
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
            String Name = txtTadviser.Text;
            String id = txtTid.Text;
            String Phone = txtTContact.Text;
            





            SqlCommand insertComand = new SqlCommand("insert into Travel_Advisor(Name,id,Phone) values( @Name, @id, @Phone)");

            insertComand.Parameters.AddWithValue("Name", Name);
            insertComand.Parameters.AddWithValue("id", id);
            insertComand.Parameters.AddWithValue("Phone", Phone);
          


            int row = dBAccess.executeQuery(insertComand);
        }
    }
}
