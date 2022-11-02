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
    public partial class TransportEdit : Form
    {
        DBAccess dBAccess = new DBAccess();
        public TransportEdit()
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
            String License_no = txtPlate.Text;
            String Phone = txtVphone.Text;
            String Vehicle_Type = txtVtype.Text;






            SqlCommand insertComand = new SqlCommand("insert into Transport(License_no,Phone,Vehicle_Type) values( @License_no, @Phone, @Vehicle_Type)");

            insertComand.Parameters.AddWithValue("License_no", License_no);
            insertComand.Parameters.AddWithValue("Phone", Phone);
            insertComand.Parameters.AddWithValue("Vehicle_Type", Vehicle_Type);



            int row = dBAccess.executeQuery(insertComand);
        }
    }
}
