using System;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace biyerdhum



{
    public partial class customerLogin : Form
    {

        public static string name, email, phone, dob, gender,Id,activestatus;


        public customerLogin()
        {
            InitializeComponent();
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



        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            role.Items.Add("ADMIN");
            role.Items.Add("STAFF");
            role.Items.Add("CUSTOMER");
            role.SelectedIndex = 0;
            // Form load logic can go here
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String chiken = role.SelectedItem.ToString();
            if (chiken == "ADMIN")
            {
                string userEmail = customerEmail.Text;
                string userPass = customerPass.Text;
                if (!IsEmailValid(userEmail) && userEmail != "admin")
                {
                    MessageBox.Show("Invalid email address", "Role Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsPasswordValid(userPass) && userPass != "admin")
                {
                    MessageBox.Show("Password should have at least 4 characters", "WRONG PASS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(customerEmail.Text) || string.IsNullOrEmpty(customerPass.Text))
                {
                    MessageBox.Show("Please input Email and Password", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (userEmail == "admin" && userPass == "admin")
                {
                    adminMenu ad = new adminMenu();
                    ad.Show();
                    this.Hide();
                }

            }
            else if (chiken == "STAFF")
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();


                    string checkUserQuery = "SELECT COUNT(*) FROM staffReg WHERE id = @Id AND password = @Password";

                    using (SqlCommand cmd = new SqlCommand(checkUserQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", customerEmail.Text);
                        cmd.Parameters.AddWithValue("@Password", customerPass.Text);


                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                        if (userCount > 0)
                        {

                            MessageBox.Show("Login Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            staffMenu sf= new staffMenu();
                            sf.Show();
                            this.Hide();

                        }
                        else
                        {

                            MessageBox.Show("Invalid id or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (chiken == "CUSTOMER")
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-12TGIKC;Initial Catalog=customerReg;Integrated Security=True;Encrypt=False"))
                {
                      con.Open();

                        // Corrected SQL query to fetch user details
                        string checkUserQuery = "SELECT id,name, email, phone, dob, gender,activestatus FROM customerReg WHERE email = @Email AND password = @Password";

                        using (SqlCommand cmd = new SqlCommand(checkUserQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@Email", customerEmail.Text);
                            cmd.Parameters.AddWithValue("@Password", customerPass.Text);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())  // Check if the user exists
                                {
                                // Retrieve user information from the reader
                                    Id = reader["id"].ToString();
                                    name = reader["name"].ToString();
                                    email = reader["email"].ToString();
                                    phone = reader["phone"].ToString();
                                    dob = reader["dob"].ToString();
                                    gender = reader["gender"].ToString();
                                    activestatus= reader["activestatus"].ToString();

                                if (activestatus == "Active")
                                    {
                                        // Navigate to the menu form
                                        menu m = new menu();
                                        m.Show();
                                        this.Hide();
                                   
                                    }
                                else if(activestatus == "Inactive")
                                {
                                    MessageBox.Show("Currently your account is inactive.For active you account contract with our admin panel.Email:ABCD");
                                }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                   
                }
            }

          
        

        private void label4_Click(object sender, EventArgs e)
        {
            customerReg cr = new customerReg();  
            cr.Show();  
            this.Hide();  
        }

       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            welcome welcome = new welcome(); 
            this.Hide();   
            welcome.Show();  
        }

     
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void role_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}