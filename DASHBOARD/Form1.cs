namespace DASHBOARD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin ingin keluar?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox5.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            btnjava.Visible = true;
            btnphyton.Visible = true;
            btninfoc.Visible = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin ingin keluar?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btninfoc_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            pictureBox4.Visible = false;
            pictureBox2.Visible = false;
            btnjava.Visible = false;
            btnphyton.Visible = false;

            lblc.Visible = true;
            lblc.Text = "Bahasa pemrograman C# atau " +
                "\n dibaca C Sharp " +
                "\n merupakan salah satu bahasa pemrograman" +
                "\n yang dikembangkan Microsoft" +
                "\n pada tahun 2000";
        }

        private void btnjava_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
            groupBox3.Hide();
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            btnphyton.Visible = false;
            btninfoc.Visible = false;

            lbljava.Visible = true;
            lbljava.Text = "Java adalah bahasa pemrograman" +
                "\n dan platform komputer yang dirilis pada " +
                "\n tahun 1995" +
                " oleh Sun Microsystems." +
                " Java adalah " +
                "\n bahasa pemrograman yang paling banyak " +
                "\n digunakan di dunia,khususnya untuk " +
                "\n aplikasi web";
        }

        private void btnphyton_Click(object sender, EventArgs e)
        {

        }

        private void btnset_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            {
                pictureBox1.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }
            else if (pictureBox5.Visible)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
            } else if (pictureBox6.Visible)
            {
                pictureBox6.Visible = false;
                pictureBox1.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = true;
            }
            else 
            {
                pictureBox1.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }
            }

        private void btnphyton_Click_1(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            btnjava.Visible = false;
            btninfoc.Visible = false;

            lblphyton.Visible = true;
            lblphyton.Text = "phyton adalah bahasa pemrograman" +
                "\n tingkat tinggi yang" +
                "\n digunakan untuk berbagai tujuan," +
                "\n termasuk pengembangan web," +
                "\n analisis data, kecerdasan buatan, " +
                "\n dan otomatisasi tugas-tugas";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
