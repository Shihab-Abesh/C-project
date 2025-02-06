namespace biyerdhum
{
    partial class staffMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffMenu));
            panel1 = new Panel();
            button5 = new Button();
            button3 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel_staff = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(2, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 565);
            panel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.LightYellow;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(34, 419);
            button5.Margin = new Padding(2, 3, 2, 3);
            button5.Name = "button5";
            button5.Size = new Size(153, 36);
            button5.TabIndex = 25;
            button5.Text = "Log Out ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightYellow;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(15, 305);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(183, 36);
            button3.TabIndex = 23;
            button3.Text = "CHECK PAYMENT ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightYellow;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(34, 204);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(153, 36);
            button1.TabIndex = 21;
            button1.Text = "CUSTOMER LIST";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 181);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 189);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(3, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 109);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel_staff
            // 
            panel_staff.BackgroundImage = (Image)resources.GetObject("panel_staff.BackgroundImage");
            panel_staff.BackgroundImageLayout = ImageLayout.Center;
            panel_staff.Location = new Point(237, 16);
            panel_staff.Name = "panel_staff";
            panel_staff.Size = new Size(921, 565);
            panel_staff.TabIndex = 2;
            // 
            // staffMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 600);
            Controls.Add(panel_staff);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "staffMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "STAFF";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button3;
        private Button button1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel_staff;
    }
}