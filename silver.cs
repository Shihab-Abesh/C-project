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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            this.Hide();
            m.Show();
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            this.Hide();
            m.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            profile p = new profile();
            this.Close();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customize customize = new customize();
            customize.no(0);
            customize.Show();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
