using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ceylon
{
    public partial class FoodEdit : Form
    {
        DBAccess dBAccess = new DBAccess();
        public FoodEdit()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            new ProfilePage().Show();
            this.Hide();
        }

        private void btnSaveFood_Click(object sender, EventArgs e)
        {
            String Restaurant_Name = txtRestaurant.Text;
            String Food_Type = txtFood.Text;
            String Price = txtFoodPrice.Text;
            String Phone = txtFoodContact.Text;





            SqlCommand insertComand = new SqlCommand("insert into Food(Restaurant_Name,Food_Type,Price,Phone) values( @Restaurant_Name, @Food_Type, @Price, @Phone)");

            insertComand.Parameters.AddWithValue("Restaurant_Name", Restaurant_Name);
            insertComand.Parameters.AddWithValue("Food_Type", Food_Type);
            insertComand.Parameters.AddWithValue("Price", Price);
            insertComand.Parameters.AddWithValue("Phone", Phone);



            int row = dBAccess.executeQuery(insertComand);

        }
    }
}
