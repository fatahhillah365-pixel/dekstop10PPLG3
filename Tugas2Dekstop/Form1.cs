namespace Tugas2Dekstop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Angka1.Clear();
            Angka2.Clear();
            Hasil.Clear();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            double angka1 = Convert.ToDouble(Angka1.Text);
            double angka2 = Convert.ToDouble(Angka2.Text);
            double hasil = angka1 + angka2;
            Hasil.Text = hasil.ToString();
        }

        private void btnkurang_Click(object sender, EventArgs e)
        {
            double angka1 = Convert.ToDouble(Angka1.Text);
            double angka2 = Convert.ToDouble(Angka2.Text);
            double hasil = angka1 - angka2;
            Hasil.Text = hasil.ToString();
        }

        private void btnkali_Click(object sender, EventArgs e)
        {
            double angka1 = Convert.ToDouble(Angka1.Text);
            double angka2 = Convert.ToDouble(Angka2.Text);
            double hasil = angka1 * angka2;
            Hasil.Text = hasil.ToString();
        }

        private void btnbagi_Click(object sender, EventArgs e)
        {
            double angka1 = Convert.ToDouble(Angka1.Text);
            double angka2 = Convert.ToDouble(Angka2.Text);
            double hasil = angka1 / angka2;
            Hasil.Text = hasil.ToString();
        }

        private void Angka1_TextChanged(object sender, EventArgs e)
        {

        }

        private void segi3_Click(object sender, EventArgs e)
        {
            double angka1 = Convert.ToDouble(Angka1.Text);
            double angka2 = Convert.ToDouble(Angka2.Text);
            double hasil = angka1 * angka2 / 2;
            Hasil.Text = hasil.ToString();
        }

        private void Hasil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
