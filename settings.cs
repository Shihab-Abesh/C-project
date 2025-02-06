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
    public partial class settings : Form
    {
        public string currentName;
        public settings()
        {

            currentName = customerLogin.Id;
            InitializeComponent();
            InformationDataTable();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.CellClick += dataGridView_CellContentClick;
        }
        private string connectionString = "Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False";


        public void InformationDataTable()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM customerReg WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", currentName);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dataGridView.DataSource = table;
                }
            }
        }






        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                name.Text = row.Cells["name"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
                phone.Text = row.Cells["phone"].Value.ToString();
                password.Text = row.Cells["password"].Value.ToString();
                dob.Value = DateTime.Parse(row.Cells["dob"].Value.ToString());
                gender.Text = row.Cells["gender"].Value.ToString();
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }



        private void dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            string newName = name.Text;
            string newEmail = email.Text;
            string newPhone = phone.Text;
            string newPassword = password.Text;
            DateTime newDob = dob.Value;
            string newGender = gender.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE customerReg SET name = @NewName, email = @Email, phone = @Phone, password = @Password, dob = @Dob, gender = @Gender WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                   
                    cmd.Parameters.AddWithValue("@NewName", newName);
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                    cmd.Parameters.AddWithValue("@Phone", newPhone);
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Dob", newDob);
                    cmd.Parameters.AddWithValue("@Gender", newGender);
                    cmd.Parameters.AddWithValue("@id", currentName);  

                  
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InformationDataTable();  
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string selectedPhone = phone.Text;

            if (string.IsNullOrEmpty(selectedPhone))
            {
                MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM customerReg WHERE phone = @Phone";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Phone", selectedPhone);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InformationDataTable(); 
                        ClearTextBoxes();
                        welcome    welcome = new welcome();
                        welcome.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

      
        private void ClearTextBoxes()
        {
            name.Text = "";
            email.Text = "";
            phone.Text = "";
            password.Text = "";
            gender.Text = "";
            dob.Value = DateTime.Now;  // Reset to current date
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            menu welcome = new menu();
            welcome.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            this.Close();
            m.Show();
        }

        
    }
}
  
