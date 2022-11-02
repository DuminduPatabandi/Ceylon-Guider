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
    public partial class Register1 : Form
    {
        DBAccess dBAccess = new DBAccess();
        public Register1()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {



            String First_Name = txtFirstName.Text;
            String Last_Name = txtSecondName.Text;
            String User_Name = txtUsername.Text;
            String NIC = txtNic.Text;





            SqlCommand insertComand = new SqlCommand("insert into UserTable(First_Name,Last_Name,User_Name,NIC) values( @First_Name, @Last_Name, @User_Name, @NIC)");
           
            insertComand.Parameters.AddWithValue("First_Name", First_Name);
            insertComand.Parameters.AddWithValue("Last_Name", Last_Name);
            insertComand.Parameters.AddWithValue("User_Name", User_Name);
            insertComand.Parameters.AddWithValue("NIC", NIC);



            int row = dBAccess.executeQuery(insertComand);


            RegisterMe registerMe = new RegisterMe();
            registerMe.Show();
            this.Close();

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
