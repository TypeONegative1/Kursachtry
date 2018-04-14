namespace Kursachtry
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FullName = new System.Windows.Forms.TextBox();
            this.NickName = new System.Windows.Forms.TextBox();
            this.PlayerID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SignatureHero = new System.Windows.Forms.TextBox();
            this.WinRate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RatingSolo = new System.Windows.Forms.ComboBox();
            this.RateStars = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrimaryRole = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(145, 83);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(262, 20);
            this.FullName.TabIndex = 0;
            this.FullName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NickName
            // 
            this.NickName.Location = new System.Drawing.Point(145, 123);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(262, 20);
            this.NickName.TabIndex = 1;
            this.NickName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PlayerID
            // 
            this.PlayerID.Location = new System.Drawing.Point(145, 159);
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.Size = new System.Drawing.Size(262, 20);
            this.PlayerID.TabIndex = 4;
            this.PlayerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Full Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "NickName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rating (solo)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PlayerID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "PrimaryRole";
            // 
            // SignatureHero
            // 
            this.SignatureHero.Location = new System.Drawing.Point(145, 200);
            this.SignatureHero.Name = "SignatureHero";
            this.SignatureHero.Size = new System.Drawing.Size(262, 20);
            this.SignatureHero.TabIndex = 13;
            // 
            // WinRate
            // 
            this.WinRate.Location = new System.Drawing.Point(145, 242);
            this.WinRate.Name = "WinRate";
            this.WinRate.Size = new System.Drawing.Size(262, 20);
            this.WinRate.TabIndex = 14;
            this.WinRate.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.WinRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "SignatureHero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "WinRate(%)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Stars";
            // 
            // RatingSolo
            // 
            this.RatingSolo.FormattingEnabled = true;
            this.RatingSolo.Items.AddRange(new object[] {
            "Herald",
            "Guardian",
            "Crusader",
            "Archon",
            "Legend",
            "Ancient",
            "Divine"});
            this.RatingSolo.Location = new System.Drawing.Point(145, 385);
            this.RatingSolo.Name = "RatingSolo";
            this.RatingSolo.Size = new System.Drawing.Size(262, 21);
            this.RatingSolo.TabIndex = 20;
            // 
            // RateStars
            // 
            this.RateStars.FormattingEnabled = true;
            this.RateStars.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★",
            "★★★★",
            "★★★★★"});
            this.RateStars.Location = new System.Drawing.Point(145, 430);
            this.RateStars.Name = "RateStars";
            this.RateStars.Size = new System.Drawing.Size(262, 21);
            this.RateStars.TabIndex = 21;
            this.RateStars.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 471);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PrimaryRole
            // 
            this.PrimaryRole.FormattingEnabled = true;
            this.PrimaryRole.Items.AddRange(new object[] {
            "MidLane",
            "HardLane",
            "Roam",
            "Support",
            "Carry"});
            this.PrimaryRole.Location = new System.Drawing.Point(145, 282);
            this.PrimaryRole.Name = "PrimaryRole";
            this.PrimaryRole.Size = new System.Drawing.Size(262, 79);
            this.PrimaryRole.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 628);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RateStars);
            this.Controls.Add(this.RatingSolo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrimaryRole);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WinRate);
            this.Controls.Add(this.SignatureHero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlayerID);
            this.Controls.Add(this.NickName);
            this.Controls.Add(this.FullName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worksheet for player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox NickName;
        private System.Windows.Forms.TextBox PlayerID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SignatureHero;
        private System.Windows.Forms.TextBox WinRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RatingSolo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox RateStars;
        private System.Windows.Forms.CheckedListBox PrimaryRole;
    }
}

