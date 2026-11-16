using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPLG3_19
{
    public partial class DATA : Form
    {
        public DATA()
        {
            InitializeComponent();
        }

        private void btngmbr_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;

            }
            else if (pictureBox2.Visible)
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;

            }
            else 
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;

            }
            


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            numericUpDown1.Value = 1;
            total.Clear();
            label6.Visible = false;
        }

        private void btnnota_Click(object sender, EventArgs e)
        {

            double comboBox1 = Convert.ToDouble(this.comboBox1.SelectedItem);
            double comboBox2 = Convert.ToDouble(this.comboBox2.SelectedItem);
            double jumlah = Convert.ToDouble(numericUpDown1.Value);
            double total = comboBox1  * jumlah;
            label6.Text = total.ToString();
           
            label6.Visible = true;
            label6.Text = "Struk " +
                "\n\n Nama SoftWare : " + comboBox1 +
                "\nHarga            : " + comboBox2 +
                "\nJumlah Pesanan : " + numericUpDown1.Value +
                "\ntotal pesanan : " + total;
        }

        private void btnlgt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin logout?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                Form1 form2 = new Form1();
                form2.Show();
            }
        }
    }
}
