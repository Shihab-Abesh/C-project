namespace biyerdhum
{
    partial class cardPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardPay));
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            card = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(card);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 437);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(133, 329);
            label5.Name = "label5";
            label5.Size = new Size(36, 23);
            label5.TabIndex = 26;
            label5.Text = "TK.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(175, 329);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 25;
            label4.Text = "AMOUNT:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(36, 329);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 24;
            label3.Text = "AMOUNT:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 277);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 31);
            textBox1.TabIndex = 21;
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button1
            // 
            button1.BackColor = Color.LightYellow;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(86, 369);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 20;
            button1.Text = "CONFIRM ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(39, 251);
            label2.Name = "label2";
            label2.Size = new Size(38, 23);
            label2.TabIndex = 7;
            label2.Text = "PIN";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(39, 177);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 6;
            label1.Text = "CARD NO";
            label1.Click += label1_Click;
            // 
            // card
            // 
            card.Location = new Point(39, 203);
            card.Margin = new Padding(2, 3, 2, 3);
            card.Multiline = true;
            card.Name = "card";
            card.Size = new Size(218, 31);
            card.TabIndex = 4;
            card.TextChanged += card_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(48, 57);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 109);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Center;
            pictureBox5.Location = new Point(13, 4);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(46, 45);
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // cardPay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 431);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "cardPay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Card Payment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox card;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox5;
    }
}