namespace biyerdhum
{
    partial class profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        public void data (String name, String email, String phone, String gender)
        {
            
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            profile_panel = new Panel();
            profile_name = new Label();
            label18 = new Label();
            ProfileG = new Label();
            profileNum = new Label();
            profile_email = new Label();
            profileDOB = new Label();
            button3 = new Button();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            profileName = new Label();
            label9 = new Label();
            label8 = new Label();
            profile_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // profile_panel
            // 
            profile_panel.Controls.Add(profile_name);
            profile_panel.Controls.Add(label18);
            profile_panel.Controls.Add(ProfileG);
            profile_panel.Controls.Add(profileNum);
            profile_panel.Controls.Add(profile_email);
            profile_panel.Controls.Add(profileDOB);
            profile_panel.Controls.Add(button3);
            profile_panel.Controls.Add(button2);
            profile_panel.Controls.Add(pictureBox3);
            profile_panel.Controls.Add(label13);
            profile_panel.Controls.Add(label12);
            profile_panel.Controls.Add(label11);
            profile_panel.Controls.Add(label10);
            profile_panel.Controls.Add(profileName);
            profile_panel.Controls.Add(label9);
            profile_panel.Controls.Add(label8);
            profile_panel.Location = new Point(-2, 1);
            profile_panel.Name = "profile_panel";
            profile_panel.Size = new Size(409, 622);
            profile_panel.TabIndex = 0;
            profile_panel.Paint += profile_panel_Paint;
            // 
            // profile_name
            // 
            profile_name.AutoSize = true;
            profile_name.Location = new Point(158, 180);
            profile_name.Name = "profile_name";
            profile_name.Size = new Size(46, 20);
            profile_name.TabIndex = 46;
            profile_name.Text = "name";
            profile_name.Click += label1_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(212, 453);
            label18.Name = "label18";
            label18.Size = new Size(87, 25);
            label18.TabIndex = 45;
            label18.Text = "Activate";
            // 
            // ProfileG
            // 
            ProfileG.AutoSize = true;
            ProfileG.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfileG.Location = new Point(159, 396);
            ProfileG.Name = "ProfileG";
            ProfileG.Size = new Size(58, 25);
            ProfileG.TabIndex = 44;
            ProfileG.Text = "Male";
            ProfileG.Click += ProfileG_Click;
            // 
            // profileNum
            // 
            profileNum.AutoSize = true;
            profileNum.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileNum.Location = new Point(159, 344);
            profileNum.Name = "profileNum";
            profileNum.Size = new Size(87, 25);
            profileNum.TabIndex = 43;
            profileNum.Text = "Number";
            profileNum.Click += profileNum_Click;
            // 
            // profile_email
            // 
            profile_email.AutoSize = true;
            profile_email.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profile_email.Location = new Point(159, 237);
            profile_email.Name = "profile_email";
            profile_email.Size = new Size(58, 25);
            profile_email.TabIndex = 42;
            profile_email.Text = "mail ";
            profile_email.Click += label15_Click;
            // 
            // profileDOB
            // 
            profileDOB.AutoSize = true;
            profileDOB.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileDOB.Location = new Point(159, 291);
            profileDOB.Name = "profileDOB";
            profileDOB.Size = new Size(61, 25);
            profileDOB.TabIndex = 41;
            profileDOB.Text = "Date ";
            profileDOB.Click += label14_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(120, 194, 133);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(74, 525);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(240, 47);
            button3.TabIndex = 40;
            button3.Text = "Edit ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(220, 580);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(9, 11);
            button2.TabIndex = 39;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(74, 31);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(278, 117);
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(57, 453);
            label13.Name = "label13";
            label13.Size = new Size(137, 25);
            label13.TabIndex = 37;
            label13.Text = "Active Status:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(57, 397);
            label12.Name = "label12";
            label12.Size = new Size(85, 25);
            label12.TabIndex = 36;
            label12.Text = "Gender:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(60, 344);
            label11.Name = "label11";
            label11.Size = new Size(88, 25);
            label11.TabIndex = 35;
            label11.Text = "Phone:  ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(60, 291);
            label10.Name = "label10";
            label10.Size = new Size(101, 25);
            label10.TabIndex = 34;
            label10.Text = "Birthday: ";
            // 
            // profileName
            // 
            profileName.AutoSize = true;
            profileName.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileName.Location = new Point(159, 176);
            profileName.Name = "profileName";
            profileName.Size = new Size(0, 25);
            profileName.TabIndex = 33;
            profileName.Click += profileName_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(57, 237);
            label9.Name = "label9";
            label9.Size = new Size(68, 25);
            label9.TabIndex = 32;
            label9.Text = "Email:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(57, 176);
            label8.Name = "label8";
            label8.Size = new Size(71, 25);
            label8.TabIndex = 31;
            label8.Text = "Name:";
            label8.Click += label8_Click;
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 710);
            Controls.Add(profile_panel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PROFILE";
            profile_panel.ResumeLayout(false);
            profile_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel profile_panel;
        private Label label18;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox3;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        public Label ProfileG;
        public Label profileNum;
        public Label profile_email;
        public Label profileDOB;
        public Label profileName;
        public Label profile_name;
    }
}