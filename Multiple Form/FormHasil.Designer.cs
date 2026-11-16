
namespace Multiple_Form
{
    partial class FormHasil
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 110);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Tampilkan Isian Username";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 148);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 1;
            label2.Text = "Tampilkan Isian password";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 190);
            label3.Name = "label3";
            label3.Size = new Size(187, 15);
            label3.TabIndex = 2;
            label3.Text = "Tampilkan Isian confirm Password";
            label3.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(63, 287);
            button1.Name = "button1";
            button1.Size = new Size(81, 41);
            button1.TabIndex = 3;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(209, 287);
            button2.Name = "button2";
            button2.Size = new Size(81, 41);
            button2.TabIndex = 4;
            button2.Text = "Next Form";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormHasil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 362);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHasil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHasil";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}