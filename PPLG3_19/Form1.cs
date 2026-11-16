namespace PPLG3_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin ingin keluar?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String user = "Fatah";
            String password = "123";
            if (textuser.Text == user && textpw.Text == password && textcpw.Text == textcpw.Text)
            {
                this.Hide();
                DATA form2 = new DATA();
                form2.Show();

            }
            else
            {
                MessageBox.Show("Username atau Password Salah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textuser.Text = String.Empty;
                textpw.Text = String.Empty;
                textcpw.Text = String.Empty;

            }

            
        }
    }
}
