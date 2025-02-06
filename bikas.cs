using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace biyerdhum
{
    public partial class bikas : Form
    {
        string m;
        string Phone;
        string bkash;
        string ID = customerLogin.Id;
        public bikas()
        {
            InitializeComponent();
        }


        public void no(int mone)
        {
            m = mone.ToString();
            label4.Text = m;

        }


        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            Phone = phone.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Phone = phone.Text;
            bkash = "bkash";


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
                        MessageBox.Show("Phone no must be 11 degit");
                        return;

                    }


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment successfully.");
                        menu menu = new menu();
                        menu.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No rows were inserted.");
                    }
                }

                /*
                catch (SqlException ex)
                {
                    // Catch SQL errors
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Catch general errors
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                */
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            this.Close();
            m.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Payment p= new Payment();
            p.Show();
            this.Hide();
        }
    }
}
