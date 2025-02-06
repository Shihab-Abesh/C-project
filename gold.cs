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
    public partial class gold : Form
    {
        public gold()
        {
            InitializeComponent();
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            this.Close();
            m.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            this.Close();
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

            customize c = new customize();
            c.no(1);
            c.Show();
            this.Close();
        }
    }
}
