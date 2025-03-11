using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ParkirApp.model;
using ParkirApp.controller;

namespace ParkirApp.view
{
    public partial class DataKeluar : UserControl
    {
        public DataKeluar()
        {
            InitializeComponent();
        }

        //MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;Convert Zero Datetime=True;Allow Zero Datetime=True;");
        //MySqlCommand command;
        //MySqlDataAdapter adapter;
        //DataTable table;

        private void DataKeluar_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = DataKeluarM.GetListData();
            Timer1.Start();
            LblDate.Text = DateTime.Now.ToString("dd-MM-yyyy").ToString();
            LblTime.Text = DateTime.Now.ToString("H:mm tt").ToString();

        }

        //public void OpenConnection()
        //{
        //    if (connection.State == ConnectionState.Closed)
        //    {
        //        connection.Open();
        //    }
        //}

        //public void CloseConnection()
        //{
        //    if (connection.State == ConnectionState.Open)
        //    {
        //        connection.Close();
        //    }
        //}

        //public void ExecuteMyQuery(string query)
        //{
        //    try
        //    {
        //        OpenConnection();
        //        command = new MySqlCommand(query, connection);

        //        if (command.ExecuteNonQuery() == 1)
        //        {
        //            MessageBox.Show("Selamat Data Anda Berhasil Di Simpan");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Data Gagal di Simpan");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}

        //public void SearchData(string valueToSearch)
        //{
        //    string query = "SELECT * FROM parkir_masuk WHERE CONCAT(`no_kendaraan`) like '%" + valueToSearch + "%'";
        //    command = new MySqlCommand(query, connection);
        //    adapter = new MySqlDataAdapter(command);
        //    table = new DataTable();
        //    adapter.Fill(table);
        //    DataGridView1.DataSource = table;
        //}

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToLongTimeString();
            Timer1.Start();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            //string valueToSearch = TextboxNoKendaraan.Text.ToString();
            //SearchData(valueToSearch);
           //DataKeluarM.SearchData(valueToSearch);
            //string updateQuery = "UPDATE db_parkir.parkir_masuk a join biaya_parkir b SET a.tanggal_keluar = CURDATE(), a.jam_keluar = curtime(),a.Tarif = b.Tarif WHERE a.no_masuk =" + int.Parse(TextboxNoMasuk.Text);
            DataKeluarM.UpdateData4(TextboxNoMasuk.Text,TextboxNoKendaraan.Text);
            DataGridView1.DataSource = DataKeluarM.GetListData();

        }

        //public void Koneksi()
        //{
        //    try
        //    {

        //        //string selectQuery = "SELECT a.no_masuk,a.no_kendaraan,a.tanggal_masuk,a.jam_masuk,a.tanggal_keluar, a.jam_keluar,b.jenis_kendaraan,b.Tarif FROM parkir_masuk a join biaya_parkir b where a.id_kendaraan = b.id_kendaraan";
        //        //MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
        //        //connection.Open();
        //        //DataSet ds = new DataSet();
        //        //adapter.Fill(ds, "parkir_masuk");
        //        //DataGridView1.DataSource = ds.Tables["parkir_masuk"];
        //        DataGridView1.DataSource = DataKeluarM.GetListData();
        //        //connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void barcode_Click(object sender, EventArgs e)
        {
            DataKeluarC.barcode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView1.DataSource = DataKeluarM.GetListData();
        }

        private void noken2(object sender, EventArgs e)
        {
            //string valueToSearch = TextboxNoKendaraan.Text.ToString();
            ////SearchData(valueToSearch);
            //DataKeluarM.SearchData(valueToSearch);
            ////string updateQuery = "UPDATE db_parkir.parkir_masuk a join biaya_parkir b SET a.tanggal_keluar = CURDATE(), a.jam_keluar = curtime(),a.Tarif = b.Tarif WHERE a.no_masuk =" + int.Parse(TextboxNoMasuk.Text);
            //DataKeluarM.UpdateData3(TextboxNoMasuk.Text, TextboxNoKendaraan.Text);
            //DataGridView1.DataSource = DataKeluarM.GetListData();
        }

        private void nosuk(object sender, KeyEventArgs e)
        {
            //string valueToSearch = TextboxNoKendaraan.Text.ToString();
            ////SearchData(valueToSearch);
            //DataKeluarM.SearchData(valueToSearch);
            ////string updateQuery = "UPDATE db_parkir.parkir_masuk a join biaya_parkir b SET a.tanggal_keluar = CURDATE(), a.jam_keluar = curtime(),a.Tarif = b.Tarif WHERE a.no_masuk =" + int.Parse(TextboxNoMasuk.Text);
            //DataKeluarM.UpdateData3(TextboxNoMasuk.Text, TextboxNoKendaraan.Text);
            //DataGridView1.DataSource = DataKeluarM.GetListData();
        }
    }
}
