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
    public partial class cardPay : Form
    {
        public cardPay()
        {
            InitializeComponent();
        }
        string m;
        string Phone;
        string bkash;
        string ID = customerLogin.Id;

        public void no(int mone)
        {
            m = mone.ToString();
            label4.Text = m;

        }
        private void card_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phone = card.Text;
            bkash = "card";


            string connectionString = "Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {


                con.Open();


                string query = "INSERT INTO data (phoneno, price, method,id) VALUES (@phoneno, @price, @method,@id)";


                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.Add("@phoneno", SqlDbType.VarChar).Value = Phone;
                    cmd.Parameters.Add("@price", SqlDbType.VarChar).Value = m;
                    cmd.Parameters.Add("@method", SqlDbType.VarChar).Value = bkash;
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = ID;


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (Phone.Length != 11)
                    {
                        MessageBox.Show("Card no must be 11 degit");
                        return;

                    }


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment successfull.");
                        menu menu = new menu();
                        menu.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No rows were inserted.");
                    }
                }

            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
            this.Hide();
        }
    }
}
