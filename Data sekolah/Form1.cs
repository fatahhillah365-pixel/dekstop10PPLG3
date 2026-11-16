using System.Windows.Forms;

namespace Data_sekolah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NOMOR(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_RowHeadersWidthSizeModeChanged(object sender, DataGridViewAutoSizeModeEventArgs e)
        {

        }

        private void dataGridView1_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            id.Clear();
            nma.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            kels.SelectedIndex = -1;
            agma.SelectedIndex = -1;
            Laki.Checked = false;
            PR.Checked = false;
            ftsl.Checked = false;
            raket.Checked = false;
            volly.Checked = false;
            lari.Checked = false;
            alamt.Clear();



        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Yakin ingin keluar?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string No = comboBox1.Text;
            string Nama = comboBox2.Text;
            string Kelas = kels.Text;
            string Agama = agma.Text;
            string JK = "";
            if (Laki.Checked)
            {
                JK = Laki.Text;
            }
            else if (PR.Checked)
            {
                JK = PR.Text;
            }
            string Hobi = "";
            if (ftsl.Checked)
            {
                Hobi += ftsl.Text + ", ";
            }
            if (raket.Checked)
            {
                Hobi += raket.Text + ", ";
            }
            if (volly.Checked)
            {
                Hobi += volly.Text + ", ";
            }
            if (lari.Checked)
            {
                Hobi += lari.Text + ", ";
            }
            string Alamat = alamt.Text;

            MessageBox.Show("Nomor id kamu adalah        : " + No + "\n" +
                            "Nama kamu adalah            : " + Nama + "\n" +
                            "Kelas kamu adalah           : " + Kelas + "\n" +
                            "Agama kamu adalah           : " + Agama + "\n" +
                            "Jenis Kelamin kamu adalah   : " + JK + "\n" +
                            "Hobi kamu adalah            : " + Hobi + "\n" +
                            "Alamat kamu adalah          : " + Alamat, " BIODATA : ");







        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin ingin menghapus data ini?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)

                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string No = comboBox1.Text;
            string Nama = comboBox2.Text;
            string Kelas = kels.Text;
            string Agama = agma.Text;
            string JK = "";
            if (Laki.Checked)
            {
                JK = Laki.Text;
            }
            else if (PR.Checked)
            {
                JK = PR.Text;
            }
            string Hobi = "";
            if (ftsl.Checked)
            {
                Hobi += ftsl.Text + ", ";
            }
            if (raket.Checked)
            {
                Hobi += raket.Text + ", ";
            }
            if (volly.Checked)
            {
                Hobi += volly.Text + ", ";
            }
            if (lari.Checked)
            {
                Hobi += lari.Text + ", ";
            }
            string Alamat = alamt.Text;
            dataGridView1.Rows.Add(No, Nama, Kelas, Agama, JK, Hobi, Alamat);

            dataGridView1.Rows.Add();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void judul_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String noid = id.Text;
            comboBox1.Items.Add(noid);
            id.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String nama = nma.Text;
            comboBox2.Items.Add(nama);
            nma.Text = "";
        }

        private void kels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ftsl_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
