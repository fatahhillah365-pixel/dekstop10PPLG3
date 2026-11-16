namespace Multiple_Form
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            user = new Label();
            pw = new Label();
            cpw = new Label();
            textcpw = new TextBox();
            lgn = new Button();
            clse = new Button();
            textuser = new TextBox();
            textpw = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.profil2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(37, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 102);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 66);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // user
            // 
            user.AutoSize = true;
            user.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user.Location = new Point(37, 165);
            user.Name = "user";
            user.Size = new Size(67, 17);
            user.TabIndex = 2;
            user.Text = "Username";
            // 
            // pw
            // 
            pw.AutoSize = true;
            pw.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pw.Location = new Point(37, 204);
            pw.Name = "pw";
            pw.Size = new Size(64, 17);
            pw.TabIndex = 3;
            pw.Text = "Password";
            // 
            // cpw
            // 
            cpw.AutoSize = true;
            cpw.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpw.Location = new Point(37, 247);
            cpw.Name = "cpw";
            cpw.Size = new Size(115, 17);
            cpw.TabIndex = 4;
            cpw.Text = "Confirm password";
            // 
            // textcpw
            // 
            textcpw.Location = new Point(181, 241);
            textcpw.Name = "textcpw";
            textcpw.PasswordChar = '*';
            textcpw.Size = new Size(126, 23);
            textcpw.TabIndex = 7;
            // 
            // lgn
            // 
            lgn.BackColor = Color.DeepSkyBlue;
            lgn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lgn.Location = new Point(52, 306);
            lgn.Name = "lgn";
            lgn.Size = new Size(86, 36);
            lgn.TabIndex = 8;
            lgn.Text = "Login";
            lgn.UseVisualStyleBackColor = false;
            lgn.Click += lgn_Click;
            // 
            // clse
            // 
            clse.BackColor = Color.Red;
            clse.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clse.Location = new Point(181, 306);
            clse.Name = "clse";
            clse.Size = new Size(83, 36);
            clse.TabIndex = 9;
            clse.Text = "Close";
            clse.UseVisualStyleBackColor = false;
            clse.Click += clse_Click;
            // 
            // textuser
            // 
            textuser.Location = new Point(181, 164);
            textuser.Name = "textuser";
            textuser.Size = new Size(126, 23);
            textuser.TabIndex = 10;
            // 
            // textpw
            // 
            textpw.Location = new Point(181, 198);
            textpw.Name = "textpw";
            textpw.PasswordChar = '*';
            textpw.Size = new Size(126, 23);
            textpw.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(346, 389);
            Controls.Add(textpw);
            Controls.Add(textuser);
            Controls.Add(clse);
            Controls.Add(lgn);
            Controls.Add(textcpw);
            Controls.Add(cpw);
            Controls.Add(pw);
            Controls.Add(user);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label user;
        private Label pw;
        private Label cpw;
        private TextBox textcpw;
        private Button lgn;
        private Button clse;
        private TextBox textuser;
        private TextBox textpw;
    }
}
