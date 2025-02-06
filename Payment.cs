using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biyerdhum
{
    public partial class Payment : Form
    {
        int Money;
        public Payment()
        {


            InitializeComponent();

        }

        public void money(int mo)
        {
            Money = mo;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bikas bikas = new bikas();
            bikas.no(Money);
            bikas.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cardPay cardPay = new cardPay();
            cardPay.no(Money);
            cardPay.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            customize c = new customize();
            this.Close();
            c.Show();
        }
    }
}
