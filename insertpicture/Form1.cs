namespace insertpicture;
using System.Data.SqlClient;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-5SLOPO7;Initial Catalog=insertpicture;Integrated Security=True;TrustServerCertificate=True");
    SqlCommand cmd;
    private void btnclose_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("yakin ingin keluar?", "keluar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void btnclear_Click(object sender, EventArgs e)
    {
        picture1.Image = null;
        txt1.Text = "";
    }

    private void btnupload_Click(object sender, EventArgs e)
    {
        openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif) | *.jpg; *.jpeg; *.png; *.gif";
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            picture1.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }

    private void btninsert_Click(object sender, EventArgs e)
    {
        cmd = new SqlCommand("Insert INTO insertpicture (nameimage, image1) VALUES (@nameimage, @image1)", con);
        cmd.Parameters.AddWithValue("@nameimage", txt1.Text);
        MemoryStream memstr = new MemoryStream();
        picture1.Image.Save(memstr, picture1.Image.RawFormat);
        cmd.Parameters.AddWithValue("@image1", memstr.ToArray());
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
        MessageBox.Show("Data Inserted Succesfully");
    }

    private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {

    }
}

