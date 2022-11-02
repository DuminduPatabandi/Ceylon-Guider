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
    public partial class RoomEdit : Form
    {
        DBAccess dBAccess = new DBAccess();
        public RoomEdit()
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
            String Hotel_Name = txtName.Text;
            String Phone = txtRoomContact.Text;
            String Room_Type = txtRoomType.Text;
            String Price = txtRoomPrice.Text;





            SqlCommand insertComand = new SqlCommand("insert into Rooms(Hotel_Name,Phone,Room_Type,Price) values( @Hotel_Name, @Phone, @Room_Type, @Price)");

            insertComand.Parameters.AddWithValue("Hotel_Name", Hotel_Name);
            insertComand.Parameters.AddWithValue("Phone", Phone);
            insertComand.Parameters.AddWithValue("Room_Type", Room_Type);
            insertComand.Parameters.AddWithValue("Price", Price);



            int row = dBAccess.executeQuery(insertComand);
        }
    }
}
