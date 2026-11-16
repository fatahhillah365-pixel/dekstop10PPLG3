namespace PPLG3_19
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
            pictureBox1 = new PictureBox();
            user = new Label();
            pw = new Label();
            cpw = new Label();
            textuser = new TextBox();
            textpw = new TextBox();
            textcpw = new TextBox();
            btnlogin = new Button();
            btnclose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 89);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.profil3;
            pictureBox1.Location = new Point(47, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // user
            // 
            user.AutoSize = true;
            user.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user.Location = new Point(47, 194);
            user.Name = "user";
            user.Size = new Size(87, 21);
            user.TabIndex = 2;
            user.Text = "Username";
            // 
            // pw
            // 
            pw.AutoSize = true;
            pw.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pw.Location = new Point(47, 252);
            pw.Name = "pw";
            pw.Size = new Size(82, 21);
            pw.TabIndex = 3;
            pw.Text = "Password";
            // 
            // cpw
            // 
            cpw.AutoSize = true;
            cpw.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cpw.Location = new Point(47, 313);
            cpw.Name = "cpw";
            cpw.Size = new Size(148, 21);
            cpw.TabIndex = 4;
            cpw.Text = "Confirm Password";
            // 
            // textuser
            // 
            textuser.Location = new Point(223, 192);
            textuser.Name = "textuser";
            textuser.Size = new Size(132, 23);
            textuser.TabIndex = 5;
            // 
            // textpw
            // 
            textpw.Location = new Point(223, 250);
            textpw.Name = "textpw";
            textpw.Size = new Size(132, 23);
            textpw.TabIndex = 6;
            // 
            // textcpw
            // 
            textcpw.Location = new Point(223, 311);
            textcpw.Name = "textcpw";
            textcpw.Size = new Size(132, 23);
            textcpw.TabIndex = 7;
            textcpw.TextChanged += textBox3_TextChanged;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.MediumTurquoise;
            btnlogin.Location = new Point(83, 390);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(79, 33);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnclose
            // 
            btnclose.BackColor = Color.DarkOrange;
            btnclose.Location = new Point(223, 390);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(79, 33);
            btnclose.TabIndex = 9;
            btnclose.Text = "CLOSE";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 446);
            Controls.Add(btnclose);
            Controls.Add(btnlogin);
            Controls.Add(textcpw);
            Controls.Add(textpw);
            Controls.Add(textuser);
            Controls.Add(cpw);
            Controls.Add(pw);
            Controls.Add(user);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label user;
        private Label pw;
        private Label cpw;
        private TextBox textuser;
        private TextBox textpw;
        private TextBox textcpw;
        private Button btnlogin;
        private Button btnclose;
    }
}
