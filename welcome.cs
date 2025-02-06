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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customerLogin cl = new customerLogin();
            this.Hide();
            cl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aboutus au = new aboutus();
            this.Hide();
            au.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contacts c = new Contacts();
            this.Hide();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            staffLogin sl = new staffLogin();
            this.Hide();
            sl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminLogin al = new adminLogin();
            this.Hide();
            al.Show();
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
