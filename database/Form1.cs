using System.Data;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace database
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5SLOPO7;Initial Catalog=database1;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();
        }
        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select id,fname As namadepan, lname As namabelakang, nilai from database2", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("yakin ingin keluar?", "keluar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Insert into database2(id,fname,lname,nilai)Values(@id,@fname,@lname,@nilai)", con);
            cmd2.Parameters.AddWithValue("id", txtid.Text);
            cmd2.Parameters.AddWithValue("fname", txtnmad.Text);
            cmd2.Parameters.AddWithValue("lname", txtnmab.Text);
            cmd2.Parameters.AddWithValue("nilai", txtnilai.Text);
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
            bind_data();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtnmad.Clear();
            txtnmab.Clear();
            txtnilai.Clear();
            txtsearch.Clear();
        }

        private void btndlt_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("yakin ingin hapus?", "hapus ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd3 = new SqlCommand("Delete from database2 where id=@id", con);
                cmd3.Parameters.AddWithValue("id", txtid.Text);
                con.Open();
                cmd3.ExecuteNonQuery();
                con.Close();
                bind_data();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            txtid.Text = selectedrow.Cells[0].Value.ToString();
            txtnmad.Text = selectedrow.Cells[1].Value.ToString();
            txtnmab.Text = selectedrow.Cells[2].Value.ToString();
            txtnilai.Text = selectedrow.Cells[3].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("Update database2 Set fname=@namadepan,lname=@namabelakang,nilai=@nilai where id=@id", con);
            cmd4.Parameters.AddWithValue("namadepan", txtnmad.Text);
            cmd4.Parameters.AddWithValue("namabelakang", txtnmab.Text);
            cmd4.Parameters.AddWithValue("nilai", txtnilai.Text);
            cmd4.Parameters.AddWithValue("id", txtid.Text);
            con.Open();
            cmd4.ExecuteNonQuery();
            con.Close();

            bind_data();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd5 = new SqlCommand("Select id,fname As namadepan, lname As namabelakang, nilai from database2 where fname like @namadepan+'%'", con);
            cmd5.Parameters.AddWithValue("namadepan", txtsearch.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd5;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
