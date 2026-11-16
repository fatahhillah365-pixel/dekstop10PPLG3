namespace database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            txtid = new TextBox();
            txtnmad = new TextBox();
            txtnmab = new TextBox();
            txtnilai = new TextBox();
            dataGridView1 = new DataGridView();
            btnclose = new Button();
            btninsert = new Button();
            btnclear = new Button();
            btndlt = new Button();
            btnupdate = new Button();
            btnsearch = new Button();
            txtsearch = new TextBox();
            pdf = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(38, 49);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(54, 21);
            lbl1.TabIndex = 1;
            lbl1.Text = "No ID";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.Location = new Point(38, 93);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(110, 21);
            lbl2.TabIndex = 2;
            lbl2.Text = "Nama Depan";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(38, 140);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(131, 21);
            lbl3.TabIndex = 3;
            lbl3.Text = "Nama Belakang";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.Location = new Point(38, 186);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(47, 21);
            lbl4.TabIndex = 4;
            lbl4.Text = "Nilai";
            // 
            // txtid
            // 
            txtid.Location = new Point(200, 47);
            txtid.Name = "txtid";
            txtid.Size = new Size(129, 23);
            txtid.TabIndex = 5;
            // 
            // txtnmad
            // 
            txtnmad.Location = new Point(200, 91);
            txtnmad.Name = "txtnmad";
            txtnmad.Size = new Size(129, 23);
            txtnmad.TabIndex = 6;
            // 
            // txtnmab
            // 
            txtnmab.Location = new Point(200, 138);
            txtnmab.Name = "txtnmab";
            txtnmab.Size = new Size(129, 23);
            txtnmab.TabIndex = 7;
            // 
            // txtnilai
            // 
            txtnilai.Location = new Point(200, 184);
            txtnilai.Name = "txtnilai";
            txtnilai.Size = new Size(129, 23);
            txtnilai.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(362, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(408, 213);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Red;
            btnclose.Cursor = Cursors.Hand;
            btnclose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(713, 351);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(75, 33);
            btnclose.TabIndex = 10;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.Yellow;
            btninsert.Cursor = Cursors.Hand;
            btninsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninsert.Location = new Point(38, 351);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(75, 33);
            btninsert.TabIndex = 11;
            btninsert.Text = "Insert";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += btninsert_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.DodgerBlue;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(134, 351);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 33);
            btnclear.TabIndex = 12;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btndlt
            // 
            btndlt.BackColor = Color.MediumSpringGreen;
            btndlt.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndlt.Location = new Point(232, 351);
            btndlt.Name = "btndlt";
            btndlt.Size = new Size(75, 33);
            btndlt.TabIndex = 13;
            btndlt.Text = "DELETE";
            btndlt.UseVisualStyleBackColor = false;
            btndlt.Click += btndlt_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.Crimson;
            btnupdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.Location = new Point(322, 351);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(75, 33);
            btnupdate.TabIndex = 14;
            btnupdate.Text = "UPDATE";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.FromArgb(255, 128, 255);
            btnsearch.Location = new Point(681, 13);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(89, 33);
            btnsearch.TabIndex = 15;
            btnsearch.Text = "Search Nama";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(523, 13);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(152, 33);
            txtsearch.TabIndex = 16;
            // 
            // pdf
            // 
            pdf.BackColor = Color.Coral;
            pdf.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pdf.Location = new Point(403, 351);
            pdf.Name = "pdf";
            pdf.Size = new Size(75, 33);
            pdf.TabIndex = 17;
            pdf.Text = "Print PDF";
            pdf.UseVisualStyleBackColor = false;
            pdf.Click += pdf_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 396);
            Controls.Add(pdf);
            Controls.Add(txtsearch);
            Controls.Add(btnsearch);
            Controls.Add(btnupdate);
            Controls.Add(btndlt);
            Controls.Add(btnclear);
            Controls.Add(btninsert);
            Controls.Add(btnclose);
            Controls.Add(dataGridView1);
            Controls.Add(txtnilai);
            Controls.Add(txtnmab);
            Controls.Add(txtnmad);
            Controls.Add(txtid);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private TextBox txtid;
        private TextBox txtnmad;
        private TextBox txtnmab;
        private TextBox txtnilai;
        private DataGridView dataGridView1;
        private Button btnclose;
        private Button btninsert;
        private Button btnclear;
        private Button btndlt;
        private Button btnupdate;
        private Button btnsearch;
        private TextBox txtsearch;
        private Button pdf;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
