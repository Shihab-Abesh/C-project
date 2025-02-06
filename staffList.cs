using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace biyerdhum
{


    public partial class staffList : Form
    {
        public staffList()
        {
            InitializeComponent();
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetDataBySearch();
        }

        public void GetData()
        {
            string qry = "select id, name, password, address,phone from staffReg ";

            ListBox lb = new ListBox();
            lb.Items.Add(id);
            lb.Items.Add(name);
            lb.Items.Add(password);
            lb.Items.Add(address);
            lb.Items.Add(phone);

            MainClass.LoadData(qry, dataGridView1, lb);
        }
        public void GetDataBySearch()
        {
            string qry = "select id, name, password, address,phone from staffReg where name like '%" + searchbox.Text + "%' ";

            ListBox lb = new ListBox();
            lb.Items.Add(id);
            lb.Items.Add(name);
            lb.Items.Add(password);
            lb.Items.Add(address);
            lb.Items.Add(phone);

            MainClass.LoadData(qry, dataGridView1, lb);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            adminMenu am = new adminMenu();
            this.Close();
            am.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            adminMenu adminMenu = new adminMenu();
            adminMenu.Show();
            this.Hide();
        }

        private void staffList_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
