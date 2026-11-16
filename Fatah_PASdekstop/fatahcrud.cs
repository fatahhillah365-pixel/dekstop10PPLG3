using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatah_PASdekstop
{

    public partial class fatahcrud : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5SLOPO7;Initial Catalog=pascrud;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public fatahcrud()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select id,nama As namahewan,habitat As habitathewan, umur As umurhewan, kategori As kategorihewan from crud where nama like @namahewan+'%'", con);
            cmd.Parameters.AddWithValue("namahewan", txtsearch.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin ke halaman selanjutnya?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                fatahinsert next = new fatahinsert();
                next.Show();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("Update crud Set nama=@namahewan,habitat=@habitathewan,umur=@umurhewan,kategori=@kategorihewan where id=@id", con);
            cmd4.Parameters.AddWithValue("namahewan", txtnama.Text);
            cmd4.Parameters.AddWithValue("habitathewan", txthabitat.Text);
            cmd4.Parameters.AddWithValue("umurhewan", txtumur.Text);
            cmd4.Parameters.AddWithValue("kategorihewan", combokategori.Text);
            cmd4.Parameters.AddWithValue("id", txtid.Text);
            con.Open();
            cmd4.ExecuteNonQuery();
            con.Close();

            bind_data();
        }
        private void bind_data()
        {
            SqlCommand cmd = new SqlCommand("Select id,nama As nama,habitat As habitat, umur As umur, kategori As kategori from crud", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin ke halaman sebelumnya?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                fatahlogin next = new fatahlogin();
                next.Show();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnama.Clear();
            txtsearch.Clear();
            txthabitat.Clear();
            txtumur.Clear();
            combokategori.SelectedIndex = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            txtid.Text = selectedrow.Cells[0].Value.ToString();
            txtnama.Text = selectedrow.Cells[1].Value.ToString();
            txthabitat.Text = selectedrow.Cells[2].Value.ToString();
            txtumur.Text = selectedrow.Cells[3].Value.ToString();
            combokategori.Text = selectedrow.Cells[4].Value.ToString();
        }
    }
}
