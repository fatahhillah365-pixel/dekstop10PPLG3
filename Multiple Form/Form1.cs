namespace Multiple_Form
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void clse_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin ingin keluar?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                // Close();
                Application.Exit();
            }
        }

        private void lgn_Click(object sender, EventArgs e)
        {
            String user = "Fatah";
            String password = "12345";
            if (textuser.Text == user && textpw.Text == password && textcpw.Text == textcpw.Text)
            {
                this.Hide();
                FormHasil form2 = new FormHasil(textuser.Text, textpw.Text, textcpw.Text);
                form2.Show();

            }
            else
            {
                MessageBox.Show("Username atau Password Salah", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textuser.Text = String.Empty;
                textpw.Text = String.Empty;
                textcpw.Text = String.Empty;

            }

            String form2label1 = "Username : " + textuser.Text;
            String label2 = "Password : " + textpw.Text;
            String label3 = "Confirm Password : " + textcpw.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
