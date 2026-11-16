namespace Fatah_PASdekstop
{
    partial class fatahinsert
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
            pictureBox1 = new PictureBox();
            btnupload = new Button();
            btninsert = new Button();
            btnclear = new Button();
            btnBack = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(205, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 154);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnupload
            // 
            btnupload.Location = new Point(243, 216);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(89, 36);
            btnupload.TabIndex = 1;
            btnupload.Text = "Upload";
            btnupload.UseVisualStyleBackColor = true;
            btnupload.Click += btnupload_Click;
            // 
            // btninsert
            // 
            btninsert.Location = new Point(90, 386);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(75, 34);
            btninsert.TabIndex = 2;
            btninsert.Text = "Insert";
            btninsert.UseVisualStyleBackColor = true;
            btninsert.Click += btninsert_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(243, 386);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(89, 34);
            btnclear.TabIndex = 3;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(464, 386);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(93, 34);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(399, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(434, 25);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 6;
            label1.Text = "Title";
            // 
            // fatahinsert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(613, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnBack);
            Controls.Add(btnclear);
            Controls.Add(btninsert);
            Controls.Add(btnupload);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fatahinsert";
            Text = "fatahinsert";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnupload;
        private Button btninsert;
        private Button btnclear;
        private Button btnBack;
        private TextBox textBox1;
        private Label label1;
    }
}