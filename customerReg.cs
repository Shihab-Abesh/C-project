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
    public partial class customerReg : Form
    {
        public customerReg()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                string insertQuery = "INSERT INTO customerReg (id,name, email, phone, password, dob, gender,activestatus) VALUES (@ID,@name, @email, @phone, @password, @dob, @gender,@Activestatus)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@ID", idTextBox.Text);
                    cmd.Parameters.AddWithValue("@name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@email", textBox1.Text);
                    cmd.Parameters.AddWithValue("@phone", textBox3.Text);
                    cmd.Parameters.AddWithValue("@password", textBox4.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@gender", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Activestatus", "Inactive");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


     




            customerLogin cl = new customerLogin();
            this.Hide();
            cl.Show();
        }
        */
        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the values from the form controls
            string id = idTextBox.Text;
            string name = textBox2.Text;
            string email = textBox1.Text;
            string phone = textBox3.Text;
            string password = textBox4.Text;
            DateTime dob = dateTimePicker1.Value;
            string gender = comboBox1.SelectedItem.ToString();
            string activestatus = "Inactive";  // Default status

            // Check if the ID already exists before proceeding with registration
            if (IsIdExist(id))
            {
                MessageBox.Show("This ID already exists. Please use a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsemailExist(email))
            {
                MessageBox.Show("This Email already exists. Please use a unique Email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
                RegisterCustomer(id, name, email, phone, password, dob, gender, activestatus);
           
        }

        // Method to check if the ID already exists in the database
        private bool IsIdExist(string id)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM customerReg WHERE id = @ID ";
                using (SqlCommand cmd = new SqlCommand(checkQuery, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;  // Return true if ID exists, false otherwise
                }
            }
        }

        private bool IsemailExist( string email)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM customerReg WHERE email = @email";
                using (SqlCommand cmd = new SqlCommand(checkQuery, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;  // Return true if ID exists, false otherwise
                }
            }
        }

        // Method to register the customer if the ID doesn't exist
        private void RegisterCustomer(string id, string name, string email, string phone, string password, DateTime dob, string gender, string activestatus)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                string insertQuery = "INSERT INTO customerReg (id, name, email, phone, password, dob, gender, activestatus) " +
                                     "VALUES (@ID, @name, @email, @phone, @password, @dob, @gender, @Activestatus)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@Activestatus", activestatus);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    customerLogin cl = new customerLogin();
                    this.Hide();
                    cl.Show();
                }
            }
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            customerLogin cl = new customerLogin();
            this.Hide();
            cl.Show();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void customerReg_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
