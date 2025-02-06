using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biyerdhum
{
    public partial class profile : Form
    {
        string name;



        public profile()
        {

            InitializeComponent();

        }


        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            settings s = new settings();
            this.Close();
            s.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void profileName_Click(object sender, EventArgs e)
        {

        }

        private void profileNum_Click(object sender, EventArgs e)
        {

        }

        private void ProfileG_Click(object sender, EventArgs e)
        {

        }

        private void profile_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            profile_name.Text = customerLogin.name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            profile_name.Visible = true;
        }
    }
}
