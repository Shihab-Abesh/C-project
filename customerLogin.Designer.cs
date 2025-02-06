namespace biyerdhum
{
    partial class customerLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerLogin));
            panel1 = new Panel();
            label1 = new Label();
            groupBox3 = new GroupBox();
            role = new ComboBox();
            groupBox2 = new GroupBox();
            customerPass = new TextBox();
            groupBox1 = new GroupBox();
            customerEmail = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(560, 17);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 571);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(29, 135);
            label1.Name = "label1";
            label1.Size = new Size(82, 26);
            label1.TabIndex = 15;
            label1.Text = "LOG IN";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(role);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(63, 182);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(229, 66);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "ROLE";
            // 
            // role
            // 
            role.FormattingEnabled = true;
            role.Items.AddRange(new object[] { "ADMIN", "CUSTOMER", "STAFF" });
            role.Location = new Point(17, 27);
            role.Name = "role";
            role.Size = new Size(198, 28);
            role.TabIndex = 0;
            role.Text = "SELECT ROLE";
            role.SelectedIndexChanged += role_SelectedIndexChanged_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(customerPass);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(63, 382);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(229, 59);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "PASSWORD";
            // 
            // customerPass
            // 
            customerPass.Location = new Point(13, 24);
            customerPass.Margin = new Padding(3, 4, 3, 4);
            customerPass.Name = "customerPass";
            customerPass.Size = new Size(209, 27);
            customerPass.TabIndex = 1;
            customerPass.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(customerEmail);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(63, 284);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 59);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOGIN";
            // 
            // customerEmail
            // 
            customerEmail.Location = new Point(13, 20);
            customerEmail.Margin = new Padding(3, 4, 3, 4);
            customerEmail.Name = "customerEmail";
            customerEmail.Size = new Size(209, 27);
            customerEmail.TabIndex = 0;
            customerEmail.TextChanged += textBox1_TextChanged_1;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(63, 469);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(229, 47);
            button1.TabIndex = 9;
            button1.Text = "LOG IN ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(120, 185, 133);
            label4.Location = new Point(219, 530);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 7;
            label4.Text = "Registration\r\n";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 530);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 6;
            label3.Text = "Don't have an account ? ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(68, 27);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 84);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(14, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(517, 571);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // customerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 603);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "customerLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox customerEmail;
        private GroupBox groupBox3;
        private Label label1;
        private ComboBox role;
        private TextBox customerPass;
    }
}
