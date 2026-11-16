namespace pendaftaran
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
            judul = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            Close = new Button();
            Clear = new Button();
            Daftar = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tempatL = new Label();
            TanggalL = new Label();
            kelamin = new Label();
            nohp = new Label();
            Alamat = new Label();
            NamaL = new Label();
            noDaftar = new Label();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            label8 = new Label();
            monthCalendar1 = new MonthCalendar();
            groupBox3 = new GroupBox();
            Data = new Label();
            Show = new Button();
            Hide = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // judul
            // 
            judul.AutoSize = true;
            judul.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            judul.Location = new Point(250, 9);
            judul.Name = "judul";
            judul.Size = new Size(312, 48);
            judul.TabIndex = 0;
            judul.Text = "Formulir Pendaftaran Siswa Baru\r\n                    Tahun 2025\r\n";
            judul.Click += judul_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Close);
            groupBox1.Controls.Add(Clear);
            groupBox1.Controls.Add(Daftar);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(tempatL);
            groupBox1.Controls.Add(TanggalL);
            groupBox1.Controls.Add(kelamin);
            groupBox1.Controls.Add(nohp);
            groupBox1.Controls.Add(Alamat);
            groupBox1.Controls.Add(NamaL);
            groupBox1.Controls.Add(noDaftar);
            groupBox1.Location = new Point(43, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(397, 456);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kolom Pendaftaran";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 429);
            label1.Name = "label1";
            label1.Size = new Size(252, 19);
            label1.TabIndex = 20;
            label1.Text = "© || Muhammad Ahsan Fataillah || 19\r\n";
            label1.Click += label1_Click;
            // 
            // Close
            // 
            Close.Location = new Point(282, 384);
            Close.Name = "Close";
            Close.Size = new Size(74, 23);
            Close.TabIndex = 19;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(198, 384);
            Clear.Name = "Clear";
            Clear.Size = new Size(78, 23);
            Clear.TabIndex = 18;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Daftar
            // 
            Daftar.Location = new Point(236, 355);
            Daftar.Name = "Daftar";
            Daftar.Size = new Size(75, 23);
            Daftar.TabIndex = 17;
            Daftar.Text = "Daftar";
            Daftar.UseVisualStyleBackColor = true;
            Daftar.Click += Daftar_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(265, 220);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 19);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perempuan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(165, 220);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 19);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Laki-Laki";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Januari  ", "Februari  ", "Maret  ", "April  ", "Mei  ", "Juni  ", "Juli  ", "Agustus  ", "September  ", "Oktober  ", "November  ", "Desember  " });
            comboBox3.Location = new Point(208, 265);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(68, 23);
            comboBox3.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1945  ", "1946  ", "1947  ", "1948  ", "1949  ", "1950  ", "1951  ", "1952  ", "1953  ", "1954  ", "1955  ", "1956  ", "1957  ", "1958  ", "1959  ", "1960  ", "1961  ", "1962  ", "1963  ", "1964  ", "1965  ", "1966  ", "1967  ", "1968  ", "1969  ", "1970  ", "1971  ", "1972  ", "1973  ", "1974  ", "1975  ", "1976  ", "1977  ", "1978  ", "1979  ", "1980  ", "1981  ", "1982  ", "1983  ", "1984  ", "1985  ", "1986  ", "1987  ", "1988  ", "1989  ", "1990  ", "1991  ", "1992  ", "1993  ", "1994  ", "1995  ", "1996  ", "1997  ", "1998  ", "1999  ", "2000  ", "2001  ", "2002  ", "2003  ", "2004  ", "2005  ", "2006  ", "2007  ", "2008  ", "2009  ", "2010  ", "2011  ", "2012  ", "2013  ", "2014  ", "2015  ", "2016  ", "2017  ", "2018  ", "2019  ", "2020  ", "2021  ", "2022  ", "2023  ", "2024  ", "2025  " });
            comboBox2.Location = new Point(282, 265);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(91, 23);
            comboBox2.TabIndex = 13;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBox1.Location = new Point(165, 265);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(37, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(165, 312);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(208, 23);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(165, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(208, 23);
            textBox4.TabIndex = 10;
            textBox4.KeyPress += keyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(165, 104);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 55);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged_1;
            textBox1.KeyPress += keyPress;
            // 
            // tempatL
            // 
            tempatL.AutoSize = true;
            tempatL.Location = new Point(24, 315);
            tempatL.Name = "tempatL";
            tempatL.Size = new Size(76, 15);
            tempatL.TabIndex = 6;
            tempatL.Text = "Tempat Lahir";
            // 
            // TanggalL
            // 
            TanggalL.AutoSize = true;
            TanggalL.Location = new Point(24, 273);
            TanggalL.Name = "TanggalL";
            TanggalL.Size = new Size(78, 15);
            TanggalL.TabIndex = 5;
            TanggalL.Text = "Tanggal Lahir";
            // 
            // kelamin
            // 
            kelamin.AutoSize = true;
            kelamin.Location = new Point(25, 224);
            kelamin.Name = "kelamin";
            kelamin.Size = new Size(78, 15);
            kelamin.TabIndex = 4;
            kelamin.Text = "Jenis Kelamin";
            // 
            // nohp
            // 
            nohp.AutoSize = true;
            nohp.Location = new Point(27, 173);
            nohp.Name = "nohp";
            nohp.Size = new Size(68, 15);
            nohp.TabIndex = 3;
            nohp.Text = "NO HP/WA";
            // 
            // Alamat
            // 
            Alamat.AutoSize = true;
            Alamat.Location = new Point(24, 104);
            Alamat.Name = "Alamat";
            Alamat.Size = new Size(93, 15);
            Alamat.TabIndex = 2;
            Alamat.Text = "Alamat Lengkap";
            Alamat.Click += label3_Click_1;
            // 
            // NamaL
            // 
            NamaL.AutoSize = true;
            NamaL.Location = new Point(24, 63);
            NamaL.Name = "NamaL";
            NamaL.Size = new Size(87, 15);
            NamaL.TabIndex = 1;
            NamaL.Text = "Nama Lengkap";
            // 
            // noDaftar
            // 
            noDaftar.AutoSize = true;
            noDaftar.Location = new Point(24, 28);
            noDaftar.Name = "noDaftar";
            noDaftar.Size = new Size(90, 15);
            noDaftar.TabIndex = 0;
            noDaftar.Text = "No Pendaftaran";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(monthCalendar1);
            groupBox2.Location = new Point(472, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 232);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kalender";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(119, 36);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(120, 23);
            textBox6.TabIndex = 2;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 39);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 1;
            label8.Text = "Tanggal Daftar";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 63);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Data);
            groupBox3.Location = new Point(472, 303);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(265, 218);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tampil Data";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // Data
            // 
            Data.AutoSize = true;
            Data.Location = new Point(25, 19);
            Data.Name = "Data";
            Data.Size = new Size(31, 15);
            Data.TabIndex = 0;
            Data.Text = "Data";
            Data.Click += Data_Click;
            // 
            // Show
            // 
            Show.Location = new Point(727, 120);
            Show.Name = "Show";
            Show.Size = new Size(75, 23);
            Show.TabIndex = 4;
            Show.Text = "Show";
            Show.UseVisualStyleBackColor = true;
            Show.Click += Show_Click;
            // 
            // Hide
            // 
            Hide.Location = new Point(727, 161);
            Hide.Name = "Hide";
            Hide.Size = new Size(75, 23);
            Hide.TabIndex = 5;
            Hide.Text = "Hide";
            Hide.UseVisualStyleBackColor = true;
            Hide.Click += Hide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(814, 555);
            Controls.Add(Hide);
            Controls.Add(Show);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(judul);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion  

        private Label judul;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label tempatL;
        private Label TanggalL;
        private Label kelamin;
        private Label nohp;
        private Label Alamat;
        private Label NamaL;
        private Label noDaftar;
        private Button Close;
        private Button Clear;
        private Button Daftar;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private Label label8;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private Button Show;
        private Button Hide;
        private Label Data;
    }
}
