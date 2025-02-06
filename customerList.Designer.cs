namespace biyerdhum
{
    partial class customerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerList));
            searchBox = new TextBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            role = new ComboBox();
            Update = new Button();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Location = new Point(387, 36);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(143, 40);
            searchBox.TabIndex = 0;
            searchBox.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 101);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(805, 246);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(538, 36);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 41);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 12);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 3;
            label1.Text = "Search ";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(78, 2);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(193, 93);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(role);
            groupBox1.Location = new Point(234, 388);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 82);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status Button";
            // 
            // role
            // 
            role.FormattingEnabled = true;
            role.Items.AddRange(new object[] { "Active", "Inactive" });
            role.Location = new Point(27, 36);
            role.Name = "role";
            role.Size = new Size(253, 28);
            role.TabIndex = 1;
            role.Text = "SELECT ROLE";
            role.SelectedIndexChanged += role_SelectedIndexChanged;
            // 
            // Update
            // 
            Update.BackColor = Color.Chartreuse;
            Update.Location = new Point(304, 476);
            Update.Name = "Update";
            Update.Size = new Size(184, 41);
            Update.TabIndex = 7;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Center;
            pictureBox5.Location = new Point(12, 2);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(46, 45);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // customerList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 565);
            Controls.Add(pictureBox5);
            Controls.Add(Update);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(searchBox);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "customerList";
            Text = "customerList";
            Load += customerList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private DataGridViewButtonColumn dgEdit;
        private GroupBox groupBox1;
        private ComboBox role;
        private Button Update;
        private PictureBox pictureBox5;
    }
}