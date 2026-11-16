namespace Tugas2Dekstop
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Angka1 = new TextBox();
            Angka2 = new TextBox();
            Hasil = new TextBox();
            Clear = new Button();
            Close = new Button();
            btntambah = new Button();
            btnkurang = new Button();
            btnkali = new Button();
            btnbagi = new Button();
            label4 = new Label();
            segi3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 89);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 0;
            label1.Text = "Angka1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 145);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 1;
            label2.Text = "Angka2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 201);
            label3.Name = "label3";
            label3.Size = new Size(50, 19);
            label3.TabIndex = 2;
            label3.Text = "Hasil";
            // 
            // Angka1
            // 
            Angka1.Location = new Point(153, 89);
            Angka1.Name = "Angka1";
            Angka1.Size = new Size(100, 23);
            Angka1.TabIndex = 3;
            Angka1.TextChanged += Angka1_TextChanged;
            // 
            // Angka2
            // 
            Angka2.Location = new Point(153, 145);
            Angka2.Name = "Angka2";
            Angka2.Size = new Size(100, 23);
            Angka2.TabIndex = 4;
            // 
            // Hasil
            // 
            Hasil.Location = new Point(153, 201);
            Hasil.Name = "Hasil";
            Hasil.ReadOnly = true;
            Hasil.Size = new Size(100, 23);
            Hasil.TabIndex = 5;
            Hasil.TextChanged += Hasil_TextChanged;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Red;
            Clear.Location = new Point(416, 293);
            Clear.Name = "Clear";
            Clear.Size = new Size(84, 43);
            Clear.TabIndex = 6;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Close
            // 
            Close.BackColor = Color.Red;
            Close.Location = new Point(521, 293);
            Close.Name = "Close";
            Close.Size = new Size(84, 43);
            Close.TabIndex = 7;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // btntambah
            // 
            btntambah.BackColor = Color.Silver;
            btntambah.Location = new Point(307, 89);
            btntambah.Name = "btntambah";
            btntambah.Size = new Size(82, 46);
            btntambah.TabIndex = 8;
            btntambah.Text = "+";
            btntambah.UseVisualStyleBackColor = false;
            btntambah.Click += btntambah_Click;
            // 
            // btnkurang
            // 
            btnkurang.BackColor = Color.Silver;
            btnkurang.Location = new Point(307, 175);
            btnkurang.Name = "btnkurang";
            btnkurang.Size = new Size(82, 45);
            btnkurang.TabIndex = 9;
            btnkurang.Text = "-";
            btnkurang.UseVisualStyleBackColor = false;
            btnkurang.Click += btnkurang_Click;
            // 
            // btnkali
            // 
            btnkali.BackColor = Color.Silver;
            btnkali.Location = new Point(416, 89);
            btnkali.Name = "btnkali";
            btnkali.Size = new Size(75, 43);
            btnkali.TabIndex = 10;
            btnkali.Text = "*";
            btnkali.UseVisualStyleBackColor = false;
            btnkali.Click += btnkali_Click;
            // 
            // btnbagi
            // 
            btnbagi.BackColor = Color.Silver;
            btnbagi.Location = new Point(416, 175);
            btnbagi.Name = "btnbagi";
            btnbagi.Size = new Size(75, 45);
            btnbagi.TabIndex = 11;
            btnbagi.Text = "/";
            btnbagi.UseVisualStyleBackColor = false;
            btnbagi.Click += btnbagi_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(184, 27);
            label4.Name = "label4";
            label4.Size = new Size(205, 31);
            label4.TabIndex = 12;
            label4.Text = "CALCULATOR";
            // 
            // segi3
            // 
            segi3.BackColor = Color.Silver;
            segi3.Location = new Point(510, 90);
            segi3.Name = "segi3";
            segi3.Size = new Size(80, 40);
            segi3.TabIndex = 13;
            segi3.Text = "L segi3";
            segi3.UseVisualStyleBackColor = false;
            segi3.Click += segi3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(617, 348);
            Controls.Add(segi3);
            Controls.Add(label4);
            Controls.Add(btnbagi);
            Controls.Add(btnkali);
            Controls.Add(btnkurang);
            Controls.Add(btntambah);
            Controls.Add(Close);
            Controls.Add(Clear);
            Controls.Add(Hasil);
            Controls.Add(Angka2);
            Controls.Add(Angka1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CALCULATOR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Angka1;
        private TextBox Angka2;
        private TextBox Hasil;
        private Button Clear;
        private new Button Close;
        private Button btntambah;
        private Button btnkurang;
        private Button btnkali;
        private Button btnbagi;
        private Label label4;
        private Button segi3;
    }
}
