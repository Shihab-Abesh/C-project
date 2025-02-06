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
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            this.Close();
            w.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            staffEntry se = new staffEntry();
            this.Close();
            se.Show();
        }

        public void AddControls(Form f)
        {
            panel_admin.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panel_admin.Controls.Add(f);
            f.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddControls(new staffList());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddControls(new customerList());

        }

        private void admin_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddControls(new transactionn());

        }

        private void panel_admin_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}









    

