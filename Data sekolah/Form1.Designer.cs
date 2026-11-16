namespace Data_sekolah
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
            noid = new Label();
            NAMA = new Label();
            KLS = new Label();
            AGM = new Label();
            JNS = new Label();
            HOBI = new Label();
            ALMT = new Label();
            id = new TextBox();
            nma = new TextBox();
            alamt = new TextBox();
            kels = new ComboBox();
            agma = new ComboBox();
            Laki = new RadioButton();
            PR = new RadioButton();
            ftsl = new CheckBox();
            raket = new CheckBox();
            lari = new CheckBox();
            volly = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // judul
            // 
            judul.AutoSize = true;
            judul.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            judul.Location = new Point(231, 9);
            judul.Name = "judul";
            judul.Size = new Size(370, 26);
            judul.TabIndex = 0;
            judul.Text = "PENDATAAN DATA SEKOLAH A";
            judul.Click += judul_Click;
            // 
            // noid
            // 
            noid.AutoSize = true;
            noid.Location = new Point(50, 60);
            noid.Name = "noid";
            noid.Size = new Size(99, 15);
            noid.TabIndex = 1;
            noid.Text = "MASUKAN NO ID";
            // 
            // NAMA
            // 
            NAMA.AutoSize = true;
            NAMA.Location = new Point(50, 109);
            NAMA.Name = "NAMA";
            NAMA.Size = new Size(106, 15);
            NAMA.TabIndex = 2;
            NAMA.Text = "MASUKAN NAMA ";
            // 
            // KLS
            // 
            KLS.AutoSize = true;
            KLS.Location = new Point(50, 149);
            KLS.Name = "KLS";
            KLS.Size = new Size(40, 15);
            KLS.TabIndex = 3;
            KLS.Text = "KELAS";
            // 
            // AGM
            // 
            AGM.AutoSize = true;
            AGM.Location = new Point(50, 184);
            AGM.Name = "AGM";
            AGM.Size = new Size(50, 15);
            AGM.TabIndex = 4;
            AGM.Text = "AGAMA";
            // 
            // JNS
            // 
            JNS.AutoSize = true;
            JNS.Location = new Point(50, 218);
            JNS.Name = "JNS";
            JNS.Size = new Size(88, 15);
            JNS.TabIndex = 5;
            JNS.Text = "JENIS KELAMIN";
            // 
            // HOBI
            // 
            HOBI.AutoSize = true;
            HOBI.Location = new Point(50, 259);
            HOBI.Name = "HOBI";
            HOBI.Size = new Size(35, 15);
            HOBI.TabIndex = 6;
            HOBI.Text = "HOBI";
            // 
            // ALMT
            // 
            ALMT.AutoSize = true;
            ALMT.Location = new Point(50, 322);
            ALMT.Name = "ALMT";
            ALMT.Size = new Size(54, 15);
            ALMT.TabIndex = 7;
            ALMT.Text = "ALAMAT";
            // 
            // id
            // 
            id.Location = new Point(199, 60);
            id.Name = "id";
            id.Size = new Size(222, 23);
            id.TabIndex = 8;
            id.TextChanged += id_TextChanged;
            id.KeyPress += NOMOR;
            // 
            // nma
            // 
            nma.Location = new Point(199, 101);
            nma.Name = "nma";
            nma.Size = new Size(222, 23);
            nma.TabIndex = 9;
            // 
            // alamt
            // 
            alamt.Location = new Point(199, 314);
            alamt.Multiline = true;
            alamt.Name = "alamt";
            alamt.Size = new Size(222, 41);
            alamt.TabIndex = 10;
            // 
            // kels
            // 
            kels.DropDownStyle = ComboBoxStyle.DropDownList;
            kels.FormattingEnabled = true;
            kels.Items.AddRange(new object[] { "10 PPLG 01", "10 PPLG 02", "10 PPLG 03" });
            kels.Location = new Point(199, 146);
            kels.Name = "kels";
            kels.Size = new Size(108, 23);
            kels.TabIndex = 11;
            kels.SelectedIndexChanged += kels_SelectedIndexChanged;
            // 
            // agma
            // 
            agma.DropDownStyle = ComboBoxStyle.DropDownList;
            agma.FormattingEnabled = true;
            agma.Items.AddRange(new object[] { "Islam", "Hindu", "Buddha", "Kristen", "Konghucu" });
            agma.Location = new Point(199, 181);
            agma.Name = "agma";
            agma.Size = new Size(108, 23);
            agma.TabIndex = 12;
            // 
            // Laki
            // 
            Laki.AutoSize = true;
            Laki.Location = new Point(199, 214);
            Laki.Name = "Laki";
            Laki.Size = new Size(67, 19);
            Laki.TabIndex = 13;
            Laki.TabStop = true;
            Laki.Text = "laki Laki";
            Laki.UseVisualStyleBackColor = true;
            // 
            // PR
            // 
            PR.AutoSize = true;
            PR.Location = new Point(327, 216);
            PR.Name = "PR";
            PR.Size = new Size(86, 19);
            PR.TabIndex = 14;
            PR.TabStop = true;
            PR.Text = "Perempuan";
            PR.UseVisualStyleBackColor = true;
            // 
            // ftsl
            // 
            ftsl.AutoSize = true;
            ftsl.Location = new Point(199, 255);
            ftsl.Name = "ftsl";
            ftsl.Size = new Size(57, 19);
            ftsl.TabIndex = 15;
            ftsl.Text = "Futsal";
            ftsl.UseVisualStyleBackColor = true;
            ftsl.CheckedChanged += ftsl_CheckedChanged;
            // 
            // raket
            // 
            raket.AutoSize = true;
            raket.Location = new Point(199, 280);
            raket.Name = "raket";
            raket.Size = new Size(85, 19);
            raket.TabIndex = 16;
            raket.Text = "Badminton";
            raket.UseVisualStyleBackColor = true;
            // 
            // lari
            // 
            lari.AutoSize = true;
            lari.Location = new Point(339, 255);
            lari.Name = "lari";
            lari.Size = new Size(45, 19);
            lari.TabIndex = 17;
            lari.Text = "Lari";
            lari.UseVisualStyleBackColor = true;
            // 
            // volly
            // 
            volly.AutoSize = true;
            volly.Location = new Point(339, 280);
            volly.Name = "volly";
            volly.Size = new Size(51, 19);
            volly.TabIndex = 18;
            volly.Text = "Volly";
            volly.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(537, 303);
            button1.Name = "button1";
            button1.Size = new Size(84, 23);
            button1.TabIndex = 19;
            button1.Text = "TAMPILKAN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(537, 332);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 20;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(713, 398);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 21;
            button3.Text = "TAMBAH";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(713, 427);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 22;
            button4.Text = "HAPUS";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(713, 456);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 23;
            button5.Text = "TUTUP";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(50, 375);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(657, 113);
            dataGridView1.TabIndex = 24;
            dataGridView1.AutoSizeColumnsModeChanged += dataGridView1_AutoSizeColumnsModeChanged;
            dataGridView1.RowHeadersWidthSizeModeChanged += dataGridView1_RowHeadersWidthSizeModeChanged;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "NO";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Nama Lengkap";
            Column2.Name = "Column2";
            Column2.Width = 112;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Kelas";
            Column3.Name = "Column3";
            Column3.Width = 59;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Agama";
            Column4.Name = "Column4";
            Column4.Width = 70;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Jenis kelamin";
            Column5.Name = "Column5";
            Column5.Width = 102;
            // 
            // Column6
            // 
            Column6.HeaderText = "Hobi";
            Column6.Name = "Column6";
            Column6.Width = 58;
            // 
            // Column7
            // 
            Column7.HeaderText = "Alamat";
            Column7.Name = "Column7";
            Column7.Width = 70;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(582, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 23);
            comboBox1.TabIndex = 25;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(582, 105);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(144, 23);
            comboBox2.TabIndex = 26;
            // 
            // button6
            // 
            button6.Location = new Point(443, 59);
            button6.Name = "button6";
            button6.Size = new Size(96, 23);
            button6.TabIndex = 27;
            button6.Text = "ADD ID";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(443, 105);
            button7.Name = "button7";
            button7.Size = new Size(96, 23);
            button7.TabIndex = 28;
            button7.Text = "ADD NAMA";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 500);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(volly);
            Controls.Add(lari);
            Controls.Add(raket);
            Controls.Add(ftsl);
            Controls.Add(PR);
            Controls.Add(Laki);
            Controls.Add(agma);
            Controls.Add(kels);
            Controls.Add(alamt);
            Controls.Add(nma);
            Controls.Add(id);
            Controls.Add(ALMT);
            Controls.Add(HOBI);
            Controls.Add(JNS);
            Controls.Add(AGM);
            Controls.Add(KLS);
            Controls.Add(NAMA);
            Controls.Add(noid);
            Controls.Add(judul);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label judul;
        private Label noid;
        private Label NAMA;
        private Label KLS;
        private Label AGM;
        private Label JNS;
        private Label HOBI;
        private Label ALMT;
        private TextBox id;
        private TextBox nma;
        private TextBox alamt;
        private ComboBox kels;
        private ComboBox agma;
        private RadioButton Laki;
        private RadioButton PR;
        private CheckBox ftsl;
        private CheckBox raket;
        private CheckBox lari;
        private CheckBox volly;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button6;
        private Button button7;
    }
}
