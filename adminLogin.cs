using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biyerdhum
{
    public partial class adminLogin : Form
    {

        public adminLogin()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            welcome wl = new welcome();
            wl.Show();
            this.Close();
        }
        private bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            int atIndex = email.IndexOf('@');
            int dotIndex = email.LastIndexOf('.');

            return (atIndex > 0 && dotIndex > atIndex + 1 && dotIndex < email.Length - 1);
        }

        private bool IsPasswordValid(string password)
        {
            return password.Length >= 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userEmail = adminId.Text;
            string userPass = adminPass.Text;
            if (!IsEmailValid(userEmail) && userEmail != "admin")
            {
                txtError.Visible = true;
                txtError.Text = "Invalid email address";
                return;
            }

            if (!IsPasswordValid(userPass) && userPass != "admin")
            {
                txtError.Visible = true;
                txtError.Text = "Password should have at least 4 characters";
                return;
            }

            if (string.IsNullOrEmpty(adminId.Text) || string.IsNullOrEmpty(adminPass.Text))
            {
                txtError.Visible = true;
                txtError.Text = "Please input Email and Password";
            }
            else if (userEmail == "admin" && userPass == "admin")
            {
                txtError.Visible = false;
                adminMenu ad = new adminMenu();
                ad.Show();
                this.Hide();
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtError_Click(object sender, EventArgs e)
        {

        }
    }
}
