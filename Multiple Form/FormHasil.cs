using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Form
{
    public partial class FormHasil : Form
    {
        public FormHasil(String textuser, String textpw, String textcpw)
        {
            InitializeComponent();
            label1.Text = "Username : " + textuser;
            label2.Text = "Password : " + textpw;
            label3.Text = "Confirm Password : " + textcpw;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }

        public FormHasil()
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin logout?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin ke halaman selanjutnya?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                next next = new next();
                next.Show();
            }

        }
    }
}
