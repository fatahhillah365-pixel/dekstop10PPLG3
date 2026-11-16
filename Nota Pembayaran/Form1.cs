using System.Runtime.CompilerServices;

namespace Nota_Pembayaran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin ingin keluar?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            text1.Clear();
            text2.Clear();
            text3.Clear();
            nomer.Value = 1;
            combo1.SelectedIndex = -1;
            box2.SelectedIndex = -1;
            deskripsi.Visible = false;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void text3_TextChanged(object sender, EventArgs e)
        {
            {

            }
        }

        private void struk_Click(object sender, EventArgs e)
        {
            double combo1 = Convert.ToDouble(this.combo1.SelectedItem);
            double box2 = Convert.ToDouble(this.box2.SelectedItem);
            double jumlah = Convert.ToDouble(nomer.Value);
            double total = (combo1 + box2) * jumlah;
            text3.Text = total.ToString();

            deskripsi.Visible = true;
            deskripsi.Text = "NOTA PEMBELIAN " +
                "\n\nMakanan Favorit : " + text1.Text +
                "\nMinuman Favorit : " + text2.Text +
                "\nJumlah Pesanan : " + nomer.Value +
                "\nHarga Makanan : " + this.combo1.SelectedItem +
                "\nHarga Minuman : " + this.box2.SelectedItem +
                "\nTotal Pembayaran : " + text3.Text;





        }

        private void nomer_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
