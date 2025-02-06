using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace biyerdhum
{
    public partial class transactionn : Form
    {
        public transactionn()
        {
            InitializeComponent();
            InformationDataTable();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void InformationDataTable()
        {
            string connectionString = "Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM data"; // Make sure 'data' is your correct table name

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        da.Fill(table);
                        dataGridView.DataSource = table; // Bind the DataTable to the DataGridView
                    }
                }
                catch (Exception ex)
                {
                    // Handle potential errors
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can handle cell click events here if needed
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            adminMenu am = new adminMenu();
            this.Close();
            am.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            adminMenu adminMenu = new adminMenu();  
            adminMenu.Show();
            this.Close();
        }
    }
}
