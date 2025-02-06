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
    public partial class staffMenu : Form
    {
        public staffMenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            this.Close();
            w.Show();
        }
        public void AddControls(Form f)
        {
            panel_staff.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panel_staff.Controls.Add(f);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddControls(new customerList());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddControls(new transactionn());
        }
    }
}
