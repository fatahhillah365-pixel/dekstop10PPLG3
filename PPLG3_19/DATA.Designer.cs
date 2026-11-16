namespace PPLG3_19
{
    partial class DATA
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            total = new TextBox();
            numericUpDown1 = new NumericUpDown();
            groupBox1 = new GroupBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btngmbr = new Button();
            btnnota = new Button();
            btnclear = new Button();
            btnlgt = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 30);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 0;
            label1.Text = "DATA PENJUALAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 1;
            label2.Text = "NAMA SOFTWARE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(111, 17);
            label3.TabIndex = 2;
            label3.Text = "JUMLAH BARANG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 180);
            label4.Name = "label4";
            label4.Size = new Size(118, 17);
            label4.TabIndex = 3;
            label4.Text = "HARGA SOFTWARE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 220);
            label5.Name = "label5";
            label5.Size = new Size(89, 17);
            label5.TabIndex = 4;
            label5.Text = "TOTAL HARGA";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Python", "Java", "C#" });
            comboBox1.Location = new Point(149, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "100000", "200000", "300000", "400000", "500000" });
            comboBox2.Location = new Point(149, 174);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            // 
            // total
            // 
            total.Location = new Point(149, 214);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(121, 23);
            total.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(149, 137);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(35, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(35, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 150);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 19);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 0;
            label6.Text = "TAMPIL DATA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.phiyton;
            pictureBox1.Location = new Point(368, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btngmbr
            // 
            btngmbr.Location = new Point(368, 90);
            btngmbr.Name = "btngmbr";
            btngmbr.Size = new Size(110, 23);
            btngmbr.TabIndex = 11;
            btngmbr.Text = "PILIH GAMBAR";
            btngmbr.UseVisualStyleBackColor = true;
            btngmbr.Click += btngmbr_Click;
            // 
            // btnnota
            // 
            btnnota.Location = new Point(388, 303);
            btnnota.Name = "btnnota";
            btnnota.Size = new Size(90, 46);
            btnnota.TabIndex = 12;
            btnnota.Text = "BELI DAN NOTA";
            btnnota.UseVisualStyleBackColor = true;
            btnnota.Click += btnnota_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(388, 355);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(90, 34);
            btnclear.TabIndex = 13;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnlgt
            // 
            btnlgt.Location = new Point(388, 400);
            btnlgt.Name = "btnlgt";
            btnlgt.Size = new Size(90, 34);
            btnlgt.TabIndex = 14;
            btnlgt.Text = "Log Out";
            btnlgt.UseVisualStyleBackColor = true;
            btnlgt.Click += btnlgt_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.java;
            pictureBox2.Location = new Point(368, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.OIP;
            pictureBox3.Location = new Point(368, 119);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(110, 118);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // DATA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 481);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnlgt);
            Controls.Add(btnclear);
            Controls.Add(btnnota);
            Controls.Add(btngmbr);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(total);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DATA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DATA";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox total;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox1;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btngmbr;
        private Button btnnota;
        private Button btnclear;
        private Button btnlgt;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}