using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace biyerdhum
{
    public partial class customerList : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False");
        public customerList()
        {

            InitializeComponent();
            InformationDataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        public void InformationDataTable()
        {
            string connectionString = "Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False";



            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();


                string query = "SELECT * FROM customerReg";


                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    da.Fill(table);


                    dataGridView1.DataSource = table;
                }
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //GetDataBySearch();
        }

        /*

                public void GetData()
                {
                    string qry = "select name, email , phone, dob,gender from customerReg ";

                    ListBox lb = new ListBox();
                    lb.Items.Add(dgname);
                    lb.Items.Add(dgemail);
                    lb.Items.Add(phone);
                    lb.Items.Add(dob);
                    lb.Items.Add(gender);
                    MainClass.LoadData(qry, dataGridView1, lb);
                }

                public void GetDataBySearch()
                {
                    string qry = "select name, email , phone, dob,gender from customerReg where name like '%" + searchBox.Text + "%' ";

                    ListBox lb = new ListBox();
                    lb.Items.Add(dgname);
                    lb.Items.Add(dgemail);
                    lb.Items.Add(phone);
                    lb.Items.Add(dob);
                    lb.Items.Add(gender);

                    MainClass.LoadData(qry, dataGridView1, lb);
                }
                */

        private void customerList_Load(object sender, EventArgs e)
        {
            //GetData();

        }
        string id;  // Declare id as a class-level variable

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Ensure the clicked row is valid
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];  // Get the clicked row

                id = row.Cells["id"].Value.ToString();  

               
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (dataGridView1.CurrentCell.OwningColumn.Name == "dgDelete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    string qry = "Delete from customerReg where email=" + dataGridView1.CurrentRow.Cells["dgemail"].Value;

                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);

                    MessageBox.Show("Deleted Successfully!");
                    GetData();
                }
            }
            */

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {


            String Activestatus = role.SelectedItem.ToString();



            string connectionString = "Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE customerReg SET activestatus = @activestatus WHERE id = @id";


                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@activestatus", Activestatus);
                    cmd.Parameters.AddWithValue("@id", id);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InformationDataTable();
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            adminMenu adminMenu = new adminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
