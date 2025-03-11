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
    public partial class Keluar : Form
    {
        public Keluar()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;Convert Zero Datetime=True;Allow Zero Datetime=True;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        private void dataMasukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masuk ss = new Masuk();
            ss.Show();
        }

        private void dataKeluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Keluar ss = new Keluar();
            ss.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Keluar_Load(object sender, EventArgs e)
        {
            populateDGV();

            
        }
        public void populateDGV()
        {
            searchData("");

            //tampilan waktu dan tanggal
            timer1.Start();
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy").ToString();
            lblTime.Text = DateTime.Now.ToString("H:mm tt").ToString();

            label8.Text = (from DataGridViewRow row in dataGridView1.Rows where row.Cells[7].FormattedValue.ToString()!= string.Empty select Convert.ToInt32(row.Cells[7].FormattedValue)).Sum().ToString();

            try
            {

                string selectQuery = "SELECT a.no_masuk,a.no_kendaraan,a.tanggal_masuk,a.jam_masuk,a.tanggal_keluar, a.jam_keluar,b.jenis_kendaraan,b.Tarif FROM parkir_masuk a join biaya_parkir b where a.id_kendaraan = b.id_kendaraan";
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "parkir_masuk");
                dataGridView1.DataSource = ds.Tables["parkir_masuk"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void searchData(string valueToSearch)
        {
            string query = "SELECT * FROM parkir_masuk WHERE CONCAT(`no_kendaraan`) like '%" + valueToSearch + "%'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Selamat Data Anda Berhasil Di Simpan");
                }
                else
                {
                    MessageBox.Show("Data Gagal di Simpan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBoxNoKendaraan.Text.ToString();
            searchData(valueToSearch);
            //"SELECT a.no_masuk,a.no_kendaraan,a.tanggal_masuk,a.jam_masuk,a.tanggal_keluar, a.jam_keluar,b.jenis_kendaraan,b.Tarif FROM parkir_masuk a join biaya_parkir b where a.id_kendaraan = b.id_kendaraan";
            string updateQuery = "UPDATE db_parkir.parkir_masuk a join biaya_parkir b SET a.tanggal_keluar = CURDATE(), a.jam_keluar = curtime(),a.Tarif = b.Tarif WHERE a.no_masuk =" + int.Parse(textBoxNoMasuk.Text);
            executeMyQuery(updateQuery);
            populateDGV();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(objBmp, 120, 100);

            e.Graphics.DrawString(label1.Text, new Font("Verdana", 30, FontStyle.Bold), Brushes.Black, new Point(300, 30));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void manajemenDataUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataUser ss = new DataUser();
            ss.Show();
        }

        private void lbltarifMobil_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
