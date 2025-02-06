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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace biyerdhum
{
    public partial class staffEntry : Form
    {
        public staffEntry()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            adminMenu ad = new adminMenu();
            this.Close();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                string insertQuery = "INSERT INTO staffReg (id, name, password, address, phone) VALUES (@id, @name, @password, @address, @phone)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@id", textBox5.Text);
                    cmd.Parameters.AddWithValue("@name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@password", textBox4.Text);
                    cmd.Parameters.AddWithValue("@address", textBox1.Text);
                    cmd.Parameters.AddWithValue("@phone", textBox3.Text);
                    
                    
                    
                    
                    
                   

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }










            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
