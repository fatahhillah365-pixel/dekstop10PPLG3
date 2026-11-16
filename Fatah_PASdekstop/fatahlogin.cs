using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Fatah_PASdekstop

{
    public partial class fatahlogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5SLOPO7;Initial Catalog=loginpas;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public fatahlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Table1 WHERE username = @user AND password = @pass", con);
            cmd.Parameters.AddWithValue("@user", txtuser.Text);
            cmd.Parameters.AddWithValue("@pass", pwtxt.Text);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            string @user = txtuser.Text;
            string @pass = pwtxt.Text;
            if (txtuser.Text == user && pwtxt.Text == pass)
            {
                MessageBox.Show("Login Berhasil!");
                this.Hide();
                fatahcrud crud = new fatahcrud();
                crud.Show();
            }
            else
            {
                MessageBox.Show("Login Gagal! Pastikan username dan password benar.");
            }
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            pwtxt.PasswordChar = show.Checked ? '\0' : '*';
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
