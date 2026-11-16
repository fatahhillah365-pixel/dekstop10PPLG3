namespace Fatah_PASdekstop
{
    partial class fatahlogin
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
            pwtxt = new TextBox();
            usertxt = new TextBox();
            txtuser = new Label();
            txtpw = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnlogin = new Button();
            btnclose = new Button();
            show = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pwtxt
            // 
            pwtxt.Location = new Point(145, 303);
            pwtxt.Name = "pwtxt";
            pwtxt.PasswordChar = '*';
            pwtxt.Size = new Size(158, 23);
            pwtxt.TabIndex = 0;
            // 
            // usertxt
            // 
            usertxt.Location = new Point(145, 256);
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(158, 23);
            usertxt.TabIndex = 1;
            // 
            // txtuser
            // 
            txtuser.AutoSize = true;
            txtuser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtuser.Location = new Point(35, 256);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(101, 25);
            txtuser.TabIndex = 2;
            txtuser.Text = "Username";
            // 
            // txtpw
            // 
            txtpw.AutoSize = true;
            txtpw.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtpw.Location = new Point(35, 303);
            txtpw.Name = "txtpw";
            txtpw.Size = new Size(97, 25);
            txtpw.TabIndex = 3;
            txtpw.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.genbok;
            pictureBox1.Location = new Point(154, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(322, 409);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(77, 29);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnclose
            // 
            btnclose.Location = new Point(35, 409);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(73, 29);
            btnclose.TabIndex = 6;
            btnclose.Text = "CLose";
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // show
            // 
            show.AutoSize = true;
            show.Location = new Point(145, 332);
            show.Name = "show";
            show.Size = new Size(108, 19);
            show.TabIndex = 7;
            show.Text = "Show Password";
            show.UseVisualStyleBackColor = true;
            show.CheckedChanged += show_CheckedChanged;
            // 
            // fatahlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(422, 450);
            Controls.Add(show);
            Controls.Add(btnclose);
            Controls.Add(btnlogin);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtpw);
            Controls.Add(txtuser);
            Controls.Add(usertxt);
            Controls.Add(pwtxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fatahlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pwtxt;
        private TextBox usertxt;
        private Label txtuser;
        private Label txtpw;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnlogin;
        private Button btnclose;
        private CheckBox show;
    }
}
