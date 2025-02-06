namespace biyerdhum
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            dataGridView = new DataGridView();
            dob = new DateTimePicker();
            update = new Button();
            name = new TextBox();
            email = new TextBox();
            phone = new TextBox();
            password = new TextBox();
            gender = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            DeleteButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(74, 103);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(681, 90);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // dob
            // 
            dob.Location = new Point(293, 485);
            dob.Name = "dob";
            dob.Size = new Size(260, 27);
            dob.TabIndex = 6;
            dob.ValueChanged += dob_ValueChanged;
            // 
            // update
            // 
            update.BackColor = Color.LawnGreen;
            update.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.Location = new Point(121, 541);
            update.Name = "update";
            update.Size = new Size(205, 68);
            update.TabIndex = 7;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // name
            // 
            name.Location = new Point(315, 212);
            name.Name = "name";
            name.Size = new Size(208, 27);
            name.TabIndex = 8;
            name.Text = "hello";
            name.TextChanged += name_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(318, 267);
            email.Name = "email";
            email.Size = new Size(205, 27);
            email.TabIndex = 9;
            email.Text = "email";
            email.TextChanged += email_TextChanged;
            // 
            // phone
            // 
            phone.Location = new Point(318, 322);
            phone.Name = "phone";
            phone.Size = new Size(205, 27);
            phone.TabIndex = 10;
            phone.Text = "phone";
            phone.TextChanged += phone_TextChanged_1;
            // 
            // password
            // 
            password.Location = new Point(318, 380);
            password.Name = "password";
            password.Size = new Size(205, 27);
            password.TabIndex = 11;
            password.Text = "password";
            password.TextChanged += password_TextChanged;
            // 
            // gender
            // 
            gender.Location = new Point(318, 434);
            gender.Name = "gender";
            gender.Size = new Size(208, 27);
            gender.TabIndex = 12;
            gender.Text = "gender";
            gender.TextChanged += gender_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(21, 24);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 29);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(395, 12);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(426, 85);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(438, 541);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(194, 62);
            DeleteButton.TabIndex = 16;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 219);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 17;
            label1.Text = "NAME :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 383);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 18;
            label2.Text = "Pass :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 325);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 19;
            label3.Text = "Phone :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(194, 267);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 20;
            label4.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(194, 441);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 21;
            label5.Text = "Gender :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(194, 490);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 22;
            label6.Text = "DOB :";
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 644);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DeleteButton);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(gender);
            Controls.Add(password);
            Controls.Add(phone);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(update);
            Controls.Add(dob);
            Controls.Add(dataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private DateTimePicker dob;
        private Button update;
        private TextBox name;
        private TextBox email;
        private TextBox phone;
        private TextBox password;
        private TextBox gender;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button DeleteButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}