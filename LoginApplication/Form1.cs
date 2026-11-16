
using Microsoft.Data.SqlClient;
//using System.Data.SqlClient; Pak agus


namespace LoginApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = show.Checked ? false : true;
        }
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("yakin ingin keluar?", "keluar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5SLOPO7;Initial Catalog=loginapp1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT (*) FROM loginapp1 WHERE username =@username AND password =@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if(count > 0)
            {
              MessageBox.Show("login berhasil", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Login");
                txtusername.Text = " ";
                txtpassword.Text = " ";
            }
        }
    }
}
