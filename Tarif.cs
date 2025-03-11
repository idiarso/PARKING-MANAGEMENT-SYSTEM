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
    public partial class Tarif : Form
    {
        public Tarif()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;");
        MySqlCommand command;

        private void Tarif_Load(object sender, EventArgs e)
        {
            populateDGV();
        }

        public void populateDGV()
        {
            // Koneksi ke MySql data parkir masuk
            try
            {

                string selectQuery = "SELECT `id_kendaraan`, `jenis_kendaraan`, `Tarif` FROM `biaya_parkir`";
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "biaya_parkir");
                dataGridView1.DataSource = ds.Tables["biaya_parkir"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO biaya_parkir(`jenis_kendaraan`, `Tarif`) VALUES ('" + this.textBoxjenis.Text + "','" + this.textBoxtarif.Text + "');";
            executeMyQuery(insertQuery);
            populateDGV();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masuk ss = new Masuk();
            ss.Show();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM biaya_parkir WHERE id_kendaraan = "+int.Parse(labelID.Text);
            executeMyQuery(deleteQuery);
            populateDGV();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            labelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxjenis.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxtarif.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            string deleteQuery = "UPDATE biaya_parkir SET jenis_kendaraan='"+textBoxjenis.Text+"',Tarif='"+textBoxtarif.Text+ "' WHERE  id_kendaraan = " + int.Parse(labelID.Text);
            executeMyQuery(deleteQuery);
            populateDGV();
        }
    }
}
