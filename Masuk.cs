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
    public partial class Masuk : Form
    {
        public Masuk()
        {
            InitializeComponent();
        }
        // Koneksi ke Database
        MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;Convert Zero Datetime=True;Allow Zero Datetime=True;");
        MySqlCommand command;
       

        private void Masuk_Load(object sender, EventArgs e)
        {
            populateDGV();
            combo();
           
        }

        void combo()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;Convert Zero Datetime=True;Allow Zero Datetime=True;");
                string selectQuery = "SELECT * FROM biaya_parkir";
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();
                DataSet ds = new DataSet();

                
                while (reader.Read())
                {

                    comboBox1.Items.Add(reader["id_kendaraan"].ToString()+" "+ reader["jenis_kendaraan"].ToString());
                    comboBox1.ValueMember = reader["id_kendaraan"].ToString();
                    comboBox1.DisplayMember = reader["jenis_kendaraan"].ToString();
                    comboBox1.DataSource = ds.Tables["parkir_masuk"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void populateDGV()
        {
            //tampilan waktu dan tanggal
            timer1.Start();
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy").ToString();
            lblTime.Text = DateTime.Now.ToString("H:mm tt").ToString();

            /*add item Motor dan Mobil di ComboBox
            comboBox1.Items.Add("MOTOR");
            comboBox1.Items.Add("MOBIL");
            */

            // Koneksi ke MySql data parkir masuk
            try
            {

                string selectQuery= "SELECT `no_masuk`, `no_kendaraan`, `id_kendaraan`, `tanggal_Masuk`, `jam_Masuk` FROM parkir_masuk";
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

        
        private void btnSimpan_Click(object sender, EventArgs e)
        { 
            // input data parkir
            string insertQuery = "INSERT INTO parkir_masuk(`no_kendaraan`, `id_kendaraan`, `tanggal_Masuk`, `jam_Masuk`) VALUES ('" + this.textBox1.Text + "','" + this.comboBox1.Text + "', CURDATE(), curtime());";
            executeMyQuery(insertQuery);
            populateDGV();
            combo();
           
        }
        //timer Untuk menjalankan Waktu di aplikasi supaya sama seperti di PC
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataKeluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Keluar ss = new Keluar();
            ss.Show();
        }

        private void dataMasukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masuk ss = new Masuk();
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

        private void meneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataUser ss = new DataUser();
            ss.Show();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void pengaturanTarifParkirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tarif ss = new Tarif();
            ss.Show();
        }

        
    }
}
