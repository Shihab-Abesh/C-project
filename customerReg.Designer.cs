namespace biyerdhum
{
    partial class customerReg
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerReg));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            imageList1 = new ImageList(components);
            idGroupBox = new GroupBox();
            idTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            idGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(397, 16);
            pictureBox1.Margin = new Padding(3, 0, 3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 641);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(idGroupBox);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 641);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBox4);
            groupBox4.Location = new Point(40, 414);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(278, 60);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Password";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 28);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(251, 27);
            textBox4.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new Point(40, 344);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(275, 63);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Phone";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(13, 28);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(249, 27);
            textBox3.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(42, 277);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(275, 59);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 28);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 27);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(40, 205);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(278, 64);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 28);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 27);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Location = new Point(227, 602);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 17;
            label3.Text = "Log In";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(61, 602);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 16;
            label2.Text = "already have an account?";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male ", "Female ", "Other" });
            comboBox1.Location = new Point(190, 494);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(127, 28);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Gender";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.AccessibleName = "dtdtd";
            button1.BackColor = Color.GreenYellow;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(38, 537);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(290, 43);
            button1.TabIndex = 9;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(35, 494);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 105);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 7;
            label1.Text = "Sign Up";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(35, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(280, 97);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // idGroupBox
            // 
            idGroupBox.Controls.Add(idTextBox);
            idGroupBox.Location = new Point(39, 134);
            idGroupBox.Margin = new Padding(3, 4, 3, 4);
            idGroupBox.Name = "idGroupBox";
            idGroupBox.Padding = new Padding(3, 4, 3, 4);
            idGroupBox.Size = new Size(278, 64);
            idGroupBox.TabIndex = 19;
            idGroupBox.TabStop = false;
            idGroupBox.Text = "ID";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(13, 28);
            idTextBox.Margin = new Padding(3, 4, 3, 4);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(249, 27);
            idTextBox.TabIndex = 0;
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // customerReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(914, 726);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "customerReg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "customerReg";
            Load += customerReg_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            idGroupBox.ResumeLayout(false);
            idGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private ImageList imageList1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox4;
        private TextBox textBox4;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private GroupBox idGroupBox;
        private TextBox idTextBox;
    }
}