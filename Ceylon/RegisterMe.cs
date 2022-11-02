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
    public partial class RegisterMe : Form
    {
        DBAccess dBAccess = new DBAccess();
        public RegisterMe()
        {
            InitializeComponent();
        }

        private void RegisterMe_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            String Email = txtEmail.Text;
            String Phone = txtPhone.Text;
            String Password = txtPwd.Text;
            String Confirm_Password = txtConfirmpwd.Text;
            String User_Name = txtUsername.Text;


            SqlCommand insertComand = new SqlCommand("Update UserTable set Email = '" + Email + "',Phone='" + Phone + "' ,Password = '" + Password + "', Confirm_Password = '" + Confirm_Password + "' where User_Name='"+ User_Name + "'");


            insertComand.Parameters.AddWithValue("Email", Email);
            insertComand.Parameters.AddWithValue("Phone", Phone);
            insertComand.Parameters.AddWithValue("Password", Password);


            if(Confirm_Password!=Password)
            {
                MessageBox.Show("Does not match with password","Warning",MessageBoxButtons.OKCancel);
                txtConfirmpwd.Clear();
            }
            else
            {
                insertComand.Parameters.AddWithValue("Confirm_Password", Confirm_Password);
                MessageBox.Show("Registered Successfully", "information", MessageBoxButtons.OKCancel);
                lblDisplay.Text = "Registered Successfully";
                UserLogName.Email = txtEmail.Text;
                new Login().Show();
                this.Hide();
            }

            int row = dBAccess.executeQuery(insertComand);


        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
