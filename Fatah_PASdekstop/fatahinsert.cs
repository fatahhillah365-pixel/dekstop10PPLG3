using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Fatah_PASdekstop
{

    public partial class fatahinsert : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5SLOPO7;Initial Catalog=insertpas;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        SqlCommand cmd;
        public fatahinsert()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnupload_Click(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Insert INTO insert (nama, image1) VALUES (@nama, @image1)", con);
            cmd.Parameters.AddWithValue("@nama", textBox1.Text);
            MemoryStream memstr = new MemoryStream();
            pictureBox1.Image.Save(memstr, pictureBox1.Image.RawFormat);
            cmd.Parameters.AddWithValue("@image1", memstr.ToArray());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin ke halaman sebelumnya?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                fatahcrud next = new fatahcrud();
                next.Show();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            textBox1.Text = "";
        }
    }
}
