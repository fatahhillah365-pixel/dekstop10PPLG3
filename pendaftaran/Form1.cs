using System.Numerics;

namespace pendaftaran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox3.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            Data.Visible = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox6.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void Daftar_Click(object sender, EventArgs e)
        {
            String noPendaftaran = textBox1.Text;
            String Nama = textBox2.Text;
            String Alamat = textBox3.Text;
            String NoHp = textBox4.Text;
            String jenisKelamin = radioButton1.Checked ? "Laki-Laki" : radioButton2.Checked ? "Perempuan" : "Tidak Diketahui";
            String tanggal = comboBox1.Text + " " + comboBox3.Text + " " + comboBox2.Text;
            String TempatLahir = textBox5.Text;
            String TanggalDaftar = textBox6.Text;

            Data.Visible = true;
            Data.Text = "nomor pendaftaran : " + noPendaftaran + Environment.NewLine +
                        "Nama Lengkap : " + Nama + Environment.NewLine +
                        "Alamat : " + Alamat + Environment.NewLine +
                        "No Hp : " + NoHp + Environment.NewLine +
                         "Jenis Kelamin : " + jenisKelamin + Environment.NewLine +
                        "tanggal Lahir : " + tanggal + Environment.NewLine +
                        "Tempat Lahir : " + TempatLahir + Environment.NewLine +
                        "Tanggal Daftar : " + TanggalDaftar + Environment.NewLine;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Data_Click(object sender, EventArgs e)
        {

        }

        private void judul_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
