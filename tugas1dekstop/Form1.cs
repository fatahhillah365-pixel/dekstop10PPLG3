namespace tugas1dekstop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCLEAR_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Nama.Text = "";
            Kelas.Text = "";
            lakilaki.Checked = false;
            perempuan.Checked = false;
            wa.Text = "";
            Hobby.Text = "";
            alamat.Text = "";
        }
    }
}
