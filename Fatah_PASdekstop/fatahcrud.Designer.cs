namespace Fatah_PASdekstop
{
    partial class fatahcrud
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
            btnback = new Button();
            btnclear = new Button();
            nextbtn = new Button();
            btnsearch = new Button();
            txtsearch = new TextBox();
            txtnama = new TextBox();
            txtid = new TextBox();
            txthabitat = new TextBox();
            combokategori = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtumur = new TextBox();
            btnupdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.BackColor = Color.LightYellow;
            btnback.Location = new Point(19, 334);
            btnback.Name = "btnback";
            btnback.Size = new Size(86, 34);
            btnback.TabIndex = 0;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Yellow;
            btnclear.Location = new Point(189, 334);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(88, 34);
            btnclear.TabIndex = 1;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // nextbtn
            // 
            nextbtn.BackColor = Color.Red;
            nextbtn.Location = new Point(678, 334);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(90, 34);
            nextbtn.TabIndex = 2;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = false;
            nextbtn.Click += nextbtn_Click;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(693, 58);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(75, 23);
            btnsearch.TabIndex = 3;
            btnsearch.Text = "Search ";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(519, 59);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(157, 23);
            txtsearch.TabIndex = 5;
            // 
            // txtnama
            // 
            txtnama.Location = new Point(177, 117);
            txtnama.Name = "txtnama";
            txtnama.Size = new Size(138, 23);
            txtnama.TabIndex = 6;
            // 
            // txtid
            // 
            txtid.Location = new Point(177, 78);
            txtid.Name = "txtid";
            txtid.Size = new Size(138, 23);
            txtid.TabIndex = 7;
            // 
            // txthabitat
            // 
            txthabitat.Location = new Point(177, 168);
            txthabitat.Name = "txthabitat";
            txthabitat.Size = new Size(138, 23);
            txthabitat.TabIndex = 8;
            // 
            // combokategori
            // 
            combokategori.FormattingEnabled = true;
            combokategori.Items.AddRange(new object[] { "karnivora", "herbivora", "omnivora" });
            combokategori.Location = new Point(177, 262);
            combokategori.Name = "combokategori";
            combokategori.Size = new Size(138, 23);
            combokategori.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(345, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(423, 197);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 119);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 11;
            label1.Text = "NAMA HEWAN ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 78);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 12;
            label2.Text = "ID HEWAN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 166);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 13;
            label3.Text = "HABITAT HEWAN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 213);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 14;
            label4.Text = "UMUR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(294, 9);
            label5.Name = "label5";
            label5.Size = new Size(173, 32);
            label5.TabIndex = 15;
            label5.Text = "DATA HEWAN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 264);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 16;
            label6.Text = "KATEGORI";
            // 
            // txtumur
            // 
            txtumur.Location = new Point(177, 215);
            txtumur.Name = "txtumur";
            txtumur.Size = new Size(138, 23);
            txtumur.TabIndex = 17;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(335, 334);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(79, 34);
            btnupdate.TabIndex = 18;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // fatahcrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(793, 380);
            Controls.Add(btnupdate);
            Controls.Add(txtumur);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(combokategori);
            Controls.Add(txthabitat);
            Controls.Add(txtid);
            Controls.Add(txtnama);
            Controls.Add(txtsearch);
            Controls.Add(btnsearch);
            Controls.Add(nextbtn);
            Controls.Add(btnclear);
            Controls.Add(btnback);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fatahcrud";
            Text = "fatahcrud";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
        private Button btnclear;
        private Button nextbtn;
        private Button btnsearch;
        private TextBox txtsearch;
        private TextBox txtnama;
        private TextBox txtid;
        private TextBox txthabitat;
        private ComboBox combokategori;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtumur;
        private Button btnupdate;
    }
}