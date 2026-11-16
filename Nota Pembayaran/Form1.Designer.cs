namespace Nota_Pembayaran
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
            nomer = new NumericUpDown();
            combo1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            box2 = new ComboBox();
            text1 = new TextBox();
            text2 = new TextBox();
            text3 = new TextBox();
            Clear = new Button();
            Close = new Button();
            struk = new Button();
            groupBox1 = new GroupBox();
            deskripsi = new Label();
            ((System.ComponentModel.ISupportInitialize)nomer).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, 20);
            label1.Name = "label1";
            label1.Size = new Size(201, 30);
            label1.TabIndex = 0;
            label1.Text = "NOTA PEMBELIAN ";
            // 
            // nomer
            // 
            nomer.Location = new Point(248, 185);
            nomer.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nomer.Name = "nomer";
            nomer.Size = new Size(64, 23);
            nomer.TabIndex = 1;
            nomer.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nomer.ValueChanged += nomer_ValueChanged;
            // 
            // combo1
            // 
            combo1.DropDownStyle = ComboBoxStyle.DropDownList;
            combo1.FormattingEnabled = true;
            combo1.Items.AddRange(new object[] { "1.000", "2.000", "3.000", "4.000", "5.000", "6.000", "7.000", "8.000", "9.000", "10.000", "11.000", "12.000", "13.000", "14.000", "15.000", "16.000", "17.000", "18.000", "19.000", "20.000" });
            combo1.Location = new Point(248, 222);
            combo1.Name = "combo1";
            combo1.Size = new Size(121, 23);
            combo1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 98);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 3;
            label2.Text = "Makanan Favoritku";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 144);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 4;
            label3.Text = "Minuman Favoritku";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 187);
            label4.Name = "label4";
            label4.Size = new Size(175, 15);
            label4.TabIndex = 5;
            label4.Text = "Jumlah Makanan dan Minuman";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 225);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 6;
            label5.Text = "Harga Makanan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 263);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 7;
            label6.Text = "Harga Minuman";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 299);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 8;
            label7.Text = "Total Harga";
            // 
            // box2
            // 
            box2.DropDownStyle = ComboBoxStyle.DropDownList;
            box2.FormattingEnabled = true;
            box2.Items.AddRange(new object[] { "1.000", "2.000", "3.000", "4.000", "5.000", "6.000", "7.000", "8.000", "9.000", "10.000", "11.000", "12.000", "13.000", "14.000", "15.000", "16.000", "17.000", "18.000", "19.000", "20.000" });
            box2.Location = new Point(248, 260);
            box2.Name = "box2";
            box2.Size = new Size(121, 23);
            box2.TabIndex = 9;
            // 
            // text1
            // 
            text1.Location = new Point(248, 95);
            text1.Name = "text1";
            text1.Size = new Size(121, 23);
            text1.TabIndex = 10;
            // 
            // text2
            // 
            text2.Location = new Point(248, 141);
            text2.Name = "text2";
            text2.Size = new Size(121, 23);
            text2.TabIndex = 11;
            // 
            // text3
            // 
            text3.Location = new Point(248, 296);
            text3.Name = "text3";
            text3.ReadOnly = true;
            text3.Size = new Size(121, 23);
            text3.TabIndex = 12;
            text3.TextChanged += text3_TextChanged;
            // 
            // Clear
            // 
            Clear.Location = new Point(554, 415);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 13;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Close
            // 
            Close.Location = new Point(650, 415);
            Close.Name = "Close";
            Close.Size = new Size(75, 23);
            Close.TabIndex = 14;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // struk
            // 
            struk.Location = new Point(578, 386);
            struk.Name = "struk";
            struk.Size = new Size(121, 23);
            struk.TabIndex = 15;
            struk.Text = "STRUK NOTA";
            struk.UseVisualStyleBackColor = true;
            struk.Click += struk_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(deskripsi);
            groupBox1.Location = new Point(487, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 224);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // deskripsi
            // 
            deskripsi.AutoSize = true;
            deskripsi.Location = new Point(6, 19);
            deskripsi.Name = "deskripsi";
            deskripsi.Size = new Size(70, 15);
            deskripsi.TabIndex = 0;
            deskripsi.Text = "Tampil Data";
            deskripsi.Visible = false;
            deskripsi.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(struk);
            Controls.Add(Close);
            Controls.Add(Clear);
            Controls.Add(text3);
            Controls.Add(text2);
            Controls.Add(text1);
            Controls.Add(box2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(combo1);
            Controls.Add(nomer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";

            System.ComponentModel.ISupportInitialize nomer1 = ((System.ComponentModel.ISupportInitialize)nomer);
            nomer1.EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nomer;
        private ComboBox combo1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox box2;
        private TextBox text1;
        private TextBox text2;
        private TextBox text3;
        private Button Clear;
        private new Button Close;
        private Button struk;
        private GroupBox groupBox1;
        private Label deskripsi;
    }
}
