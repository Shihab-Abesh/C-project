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
    public partial class staffLogin : Form
    {
        public staffLogin()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


















            welcome w = new welcome();
            this.Close();
            w.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            {

                {
                    
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False"))
                    {
                        con.Open();

                       
                        string checkUserQuery = "SELECT COUNT(*) FROM staffReg WHERE id = @Id AND password = @Password";

                        using (SqlCommand cmd = new SqlCommand(checkUserQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", textBox1.Text);           
                            cmd.Parameters.AddWithValue("@Password", textBox2.Text);     

                           
                            int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                            if (userCount > 0)
                            {
                                
                                MessageBox.Show("Login Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                                staffMenu sm = new staffMenu(); 
                                sm.Show();

                                
                            }
                            else
                            {
                                
                                MessageBox.Show("Invalid id or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }











            }
        }














        }
    }
//}
