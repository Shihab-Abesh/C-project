namespace biyerdhum
{
    partial class staffList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffList));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            searchbox = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(searchbox);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(106, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 149);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(446, 8);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 4;
            label1.Text = "Search ";
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(790, 359);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(604, 38);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 41);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // searchbox
            // 
            searchbox.Location = new Point(446, 35);
            searchbox.Multiline = true;
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(138, 44);
            searchbox.TabIndex = 1;
            searchbox.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(179, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 111);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, password, address, phone });
            dataGridView1.Location = new Point(106, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(696, 316);
            dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // password
            // 
            password.HeaderText = "password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.Width = 125;
            // 
            // address
            // 
            address.HeaderText = "address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.Width = 125;
            // 
            // phone
            // 
            phone.HeaderText = "phone";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.Width = 125;
            // 
            // staffList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 565);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "staffList";
            Text = "staffList";
            Load += staffList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox searchbox;
        private PictureBox pictureBox2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn phone;
        private Label label1;
        private PictureBox pictureBox3;
    }
}