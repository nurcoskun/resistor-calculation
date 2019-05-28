namespace direnc_hesaplama_projesi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb5Renk = new System.Windows.Forms.RadioButton();
            this.rb4Renk = new System.Windows.Forms.RadioButton();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDeger = new System.Windows.Forms.Label();
            this.tbDeger = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "0-Siyah",
            "1-Kahverengi",
            "2-Kırmızı",
            "3-Turuncu",
            "4-Sarı",
            "5-Yeşil",
            "6-Mavi",
            "7-Mor",
            "8-Gri",
            "9-Beyaz"});
            this.listBox1.Location = new System.Drawing.Point(105, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(83, 134);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "0-Siyah",
            "1-Kahverengi",
            "2-Kırmızı",
            "3-Turuncu",
            "4-Sarı",
            "5-Yeşil",
            "6-Mavi",
            "7-Mor",
            "8-Gri",
            "9-Beyaz"});
            this.listBox2.Location = new System.Drawing.Point(194, 136);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(79, 134);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged_1);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "0-Siyah",
            "1-Kahverengi",
            "2-Kırmızı",
            "3-Turuncu",
            "4-Sarı",
            "5-Yeşil",
            "6-Mavi",
            "7-Mor",
            "8-Gri",
            "9-Beyaz"});
            this.listBox3.Location = new System.Drawing.Point(279, 136);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(80, 134);
            this.listBox3.TabIndex = 2;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged_1);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Items.AddRange(new object[] {
            "Siyah x1",
            "Kahverengi x10",
            "Kırmızı x100",
            "Turuncu x1000 = x1K",
            "Sarı x10000 = x10K",
            "Yeşil x100000 = x100K",
            "Mavi x1000000 = x1M",
            "Mor x10000000 = x10M",
            "Gri x100000000 = x100M",
            "Beyaz x1000000000 = x1000M"});
            this.listBox4.Location = new System.Drawing.Point(365, 136);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(172, 134);
            this.listBox4.TabIndex = 3;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb5Renk);
            this.groupBox1.Controls.Add(this.rb4Renk);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(249, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RENK SAYISI SEÇİN";
            // 
            // rb5Renk
            // 
            this.rb5Renk.AutoSize = true;
            this.rb5Renk.Location = new System.Drawing.Point(147, 27);
            this.rb5Renk.Name = "rb5Renk";
            this.rb5Renk.Size = new System.Drawing.Size(70, 19);
            this.rb5Renk.TabIndex = 1;
            this.rb5Renk.Text = "5 Renk";
            this.rb5Renk.UseVisualStyleBackColor = true;
            this.rb5Renk.CheckedChanged += new System.EventHandler(this.rb5Renk_CheckedChanged);
            // 
            // rb4Renk
            // 
            this.rb4Renk.AutoSize = true;
            this.rb4Renk.Checked = true;
            this.rb4Renk.Location = new System.Drawing.Point(26, 27);
            this.rb4Renk.Name = "rb4Renk";
            this.rb4Renk.Size = new System.Drawing.Size(70, 19);
            this.rb4Renk.TabIndex = 0;
            this.rb4Renk.TabStop = true;
            this.rb4Renk.Text = "4 Renk";
            this.rb4Renk.UseVisualStyleBackColor = true;
            this.rb4Renk.CheckedChanged += new System.EventHandler(this.rb4Renk_CheckedChanged);
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Items.AddRange(new object[] {
            "Kahverengi (±%1)",
            "Kırmızı (±%2)",
            "Yeşil (±%0.5)",
            "Mavi (±%0.25)",
            "Mor (±%0.10)",
            "Gri (±%0.05)",
            "Altın (±%5)",
            "Gümüş (±%10)"});
            this.listBox5.Location = new System.Drawing.Point(543, 136);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(110, 134);
            this.listBox5.TabIndex = 5;
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(29, 208);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(56, 13);
            this.textBox3.TabIndex = 27;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(30, 214);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(54, 13);
            this.textBox6.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(29, 226);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 13);
            this.textBox4.TabIndex = 28;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(29, 188);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 13);
            this.textBox2.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(22, 253);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 17);
            this.textBox5.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(24, 147);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 17);
            this.textBox1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 277);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Location = new System.Drawing.Point(299, 313);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(78, 13);
            this.lblDeger.TabIndex = 32;
            this.lblDeger.Text = "Direnç Değeri :";
            // 
            // tbDeger
            // 
            this.tbDeger.BackColor = System.Drawing.SystemColors.Info;
            this.tbDeger.Location = new System.Drawing.Point(400, 310);
            this.tbDeger.Name = "tbDeger";
            this.tbDeger.Size = new System.Drawing.Size(161, 20);
            this.tbDeger.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 44);
            this.button2.TabIndex = 30;
            this.button2.Text = "Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "1.RENK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "2.RENK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "3.RENK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "ÇARPAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "TOLERANS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 372);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.tbDeger);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb5Renk;
        private System.Windows.Forms.RadioButton rb4Renk;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.TextBox tbDeger;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

