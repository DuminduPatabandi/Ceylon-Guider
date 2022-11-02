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
    public partial class Login : Form
    {
        DBAccess obj2 = new DBAccess();
        DataTable dt = new DataTable();
        public Login()
        {
            InitializeComponent();
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Register1 register=new Register1();
            register.Show();
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            String User_Name = txtUserName.Text;
            String Password = txtPwd.Text;

            String quary = "Select * from UserTable Where User_Name  = '" + User_Name + "' AND Password = '" + Password + "'";

            obj2.readDatathroughAdapter(quary, dt);

            if (dt.Rows.Count == 1)
            {

                obj2.closeConn();

                this.Hide();
                ProfilePage welcome = new ProfilePage();
                welcome.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password or Username","Warning",MessageBoxButtons.OKCancel);
                txtUserName.Clear();
                txtPwd.Clear();
            }
        }
    }
}
