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
    public partial class customize : Form
    {
        int number;

        public customize()
        {
            InitializeComponent();
        }

        public void no(int n)
        {
            number = n;

        }
        public void AddControls(Form f)
        {
            customizePNL.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            customizePNL.Controls.Add(f);
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            profile p = new profile();
            this.Close();
            p.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }
        int sum = 0;
        int mutton = 0, water = 0, coke = 0, Chicken = 0, beef = 0;

        void Sum()
        {

            mutton = Convert.ToInt32(Mutton.Text) * 1200;
            water = Convert.ToInt32(Water.Text) * 15;
            coke = Convert.ToInt32(Coke.Text) * 20;
            Chicken = Convert.ToInt32(chicken.Text) * 60;
            beef = Convert.ToInt32(Beef.Text) * 900;

            sum = mutton + water + coke + beef + Chicken;
            if (number == 0)
            {
                CSUM = sum + 47000;
            }
            else if (number == 1)
            {
                CSUM = sum + 217500;
            }
            else if (number == 2)
            {
                CSUM = sum + 298500;
            }

        }


        int CSUM = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            Sum();
            Payment p = new Payment();
            p.money(CSUM);
            p.Show();
            this.Close();


        }

        private void person_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rice_TextChanged(object sender, EventArgs e)
        {

        }

        private void chicken_TextChanged(object sender, EventArgs e)
        {


        }

        private void Beef_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mutton_TextChanged(object sender, EventArgs e)
        {



        }

        private void Coke_TextChanged(object sender, EventArgs e)
        {

        }

        private void Water_TextChanged(object sender, EventArgs e)
        {

        }

        private void customizePNL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            welcome welcome = new welcome();
            welcome.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            this.Close();
            m.Show();
        }
    }
}
