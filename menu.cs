using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace biyerdhum
{
    public partial class menu : Form
    {

        public menu()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            customerLogin cl = new customerLogin();
            this.Hide();
            cl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerLogin cl = new customerLogin();
            this.Hide();
            cl.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gold g = new gold();
            this.Hide();
            g.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Platinum P = new Platinum();
            this.Hide();
            P.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            customerLogin cl = new customerLogin();
            this.Hide();
            cl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customize c = new customize();
            c.Show();
            this.Hide();
        }
      
        private void pictureBox7_Click(object sender, EventArgs e)
        {
           settings s=new settings();
            s.Show();
            this.Close();

        }

        private void name_Click(object sender, EventArgs e)
        {
           
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void testlabel_Click(object sender, EventArgs e)
        {
       
        }

        private void menu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
