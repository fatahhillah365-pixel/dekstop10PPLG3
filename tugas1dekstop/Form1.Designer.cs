namespace tugas1dekstop
{
    partial class Form1
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
            Nama = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            wa = new TextBox();
            Hobby = new TextBox();
            alamat = new TextBox();
            Kelas = new ComboBox();
            lakilaki = new RadioButton();
            perempuan = new RadioButton();
            label7 = new Label();
            tombolclose = new Button();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tombolclear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Nama
            // 
            Nama.Location = new Point(167, 76);
            Nama.Multiline = true;
            Nama.Name = "Nama";
            Nama.Size = new Size(211, 23);
            Nama.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 84);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "NAMA LENGKAP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(330, 29);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 2;
            label2.Text = "BIODATA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 120);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 3;
            label3.Text = "KELAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 162);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 4;
            label4.Text = "JENIS KELAMIN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 215);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 5;
            label5.Text = "NO.WA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 264);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 6;
            label6.Text = "HOBBY";
            // 
            // wa
            // 
            wa.Location = new Point(167, 207);
            wa.Name = "wa";
            wa.Size = new Size(211, 23);
            wa.TabIndex = 7;
            // 
            // Hobby
            // 
            Hobby.Location = new Point(167, 256);
            Hobby.Name = "Hobby";
            Hobby.Size = new Size(211, 23);
            Hobby.TabIndex = 8;
            // 
            // alamat
            // 
            alamat.Location = new Point(167, 285);
            alamat.Multiline = true;
            alamat.Name = "alamat";
            alamat.Size = new Size(211, 65);
            alamat.TabIndex = 9;
            // 
            // Kelas
            // 
            Kelas.FormattingEnabled = true;
            Kelas.Items.AddRange(new object[] { "10 PPLG 1", "10 PPLG 2", "10 PPLG 3" });
            Kelas.Location = new Point(167, 112);
            Kelas.Name = "Kelas";
            Kelas.Size = new Size(211, 23);
            Kelas.TabIndex = 10;
            // 
            // lakilaki
            // 
            lakilaki.AutoSize = true;
            lakilaki.Location = new Point(167, 158);
            lakilaki.Name = "lakilaki";
            lakilaki.Size = new Size(76, 19);
            lakilaki.TabIndex = 11;
            lakilaki.TabStop = true;
            lakilaki.Text = "LAKI LAKI\r\n";
            lakilaki.UseVisualStyleBackColor = true;
            // 
            // perempuan
            // 
            perempuan.AutoSize = true;
            perempuan.Location = new Point(284, 158);
            perempuan.Name = "perempuan";
            perempuan.Size = new Size(94, 19);
            perempuan.TabIndex = 12;
            perempuan.TabStop = true;
            perempuan.Text = "PEREMPUAN";
            perempuan.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 309);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 13;
            label7.Text = "ALAMAT RUMAH";
            // 
            // tombolclose
            // 
            tombolclose.BackColor = Color.Red;
            tombolclose.Location = new Point(702, 415);
            tombolclose.Name = "tombolclose";
            tombolclose.Size = new Size(86, 32);
            tombolclose.TabIndex = 14;
            tombolclose.Text = "CLOSE";
            tombolclose.UseVisualStyleBackColor = false;
            tombolclose.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pm_1737800713778_cmp;
            pictureBox1.Location = new Point(538, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // tombolclear
            // 
            tombolclear.BackColor = Color.Red;
            tombolclear.Location = new Point(605, 415);
            tombolclear.Name = "tombolclear";
            tombolclear.Size = new Size(91, 32);
            tombolclear.TabIndex = 16;
            tombolclear.Text = "CLEAR";
            tombolclear.UseVisualStyleBackColor = false;
            tombolclear.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(814, 457);
            Controls.Add(tombolclear);
            Controls.Add(pictureBox1);
            Controls.Add(tombolclose);
            Controls.Add(label7);
            Controls.Add(perempuan);
            Controls.Add(lakilaki);
            Controls.Add(Kelas);
            Controls.Add(alamat);
            Controls.Add(Hobby);
            Controls.Add(wa);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nama);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nama;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox wa;
        private TextBox Hobby;
        private TextBox alamat;
        private ComboBox Kelas;
        private RadioButton lakilaki;
        private RadioButton perempuan;
        private Label label7;
        private Button tombolclose;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button tombolclear;
    }
}
