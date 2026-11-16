namespace insertpicture
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
            picture1 = new PictureBox();
            txt1 = new TextBox();
            lbl1 = new Label();
            btnupload = new Button();
            btninsert = new Button();
            btnclear = new Button();
            btnclose = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picture1).BeginInit();
            SuspendLayout();
            // 
            // picture1
            // 
            picture1.Location = new Point(78, 38);
            picture1.Name = "picture1";
            picture1.Size = new Size(186, 187);
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture1.TabIndex = 0;
            picture1.TabStop = false;
            // 
            // txt1
            // 
            txt1.Location = new Point(566, 45);
            txt1.Name = "txt1";
            txt1.Size = new Size(161, 23);
            txt1.TabIndex = 1;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(489, 40);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(50, 25);
            lbl1.TabIndex = 2;
            lbl1.Text = "Title";
            // 
            // btnupload
            // 
            btnupload.BackColor = SystemColors.ActiveCaption;
            btnupload.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupload.Location = new Point(102, 231);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(132, 34);
            btnupload.TabIndex = 3;
            btnupload.Text = "Upload";
            btnupload.UseVisualStyleBackColor = false;
            btnupload.Click += btnupload_Click;
            // 
            // btninsert
            // 
            btninsert.BackColor = Color.Yellow;
            btninsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninsert.Location = new Point(102, 403);
            btninsert.Name = "btninsert";
            btninsert.Size = new Size(132, 35);
            btninsert.TabIndex = 4;
            btninsert.Text = "Insert";
            btninsert.UseVisualStyleBackColor = false;
            btninsert.Click += btninsert_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Bisque;
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(375, 403);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(132, 35);
            btnclear.TabIndex = 5;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.Red;
            btnclose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(642, 403);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(132, 35);
            btnclose.TabIndex = 6;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(btnclose);
            Controls.Add(btnclear);
            Controls.Add(btninsert);
            Controls.Add(btnupload);
            Controls.Add(lbl1);
            Controls.Add(txt1);
            Controls.Add(picture1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picture1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picture1;
        private TextBox txt1;
        private Label lbl1;
        private Button btnupload;
        private Button btninsert;
        private Button btnclear;
        private Button btnclose;
        private OpenFileDialog openFileDialog1;
    }
}
