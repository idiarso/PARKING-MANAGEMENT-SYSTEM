using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace parkir
{
    public partial class DataPetugas : Form
    {
        public DataPetugas()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;");

        private void DataPetugas_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        public void populateDGV()
        {
            // Koneksi ke MySql data parkir masuk
            try
            {

                string selectQuery = "SELECT `id_petugas`, `nama`, `alamat`, `No_Hp` FROM login";
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "login");
                dataGridView1.DataSource = ds.Tables["login"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataUser ss = new DataUser();
            ss.Show();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(objBmp, 120, 100);

            e.Graphics.DrawString(label1.Text, new Font("Verdana", 30, FontStyle.Bold), Brushes.Black, new Point(300, 30));
        }
    }
}
