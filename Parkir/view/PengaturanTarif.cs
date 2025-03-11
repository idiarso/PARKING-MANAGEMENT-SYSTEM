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
using ParkirApp.view;
using ParkirApp.model;

namespace ParkirApp.view
{
    public partial class PengaturanTarif : Form
    {
        public PengaturanTarif()
        {
            InitializeComponent();
        }
        
        
        //MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;");
        //MySqlCommand command;

        private void BtnTutup_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ss = new Parkir();
            ss.Closed += (s, args) => this.Close();
            ss.Close();
        }

        private void PengaturanTarif_Load(object sender, EventArgs e)
        {
            Data();
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

        public void Data()
        {
            biayaParkirBindingSource.DataSource = BiayaParkir.GetListData();
            DataGridView1.DataSource = biayaParkirBindingSource;
            TxtJeniskendaraan.Enabled = true;
            TxtTarif.Enabled = true;
            // Koneksi ke MySql data parkir masuk
            //try
            //{

            //string selectQuery = "SELECT `id_kendaraan`, `jenis_kendaraan`, `Tarif` FROM `biaya_parkir`";
            //MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            //connection.Open();
            //DataSet ds = new DataSet();
            //adapter.Fill(ds, "biaya_parkir");
            //DataGridView1.DataSource = ds.Tables["biaya_parkir"];
            //connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtJeniskendaraan.Text) && !string.IsNullOrEmpty(TxtTarif.Text))
            {
                BiayaParkir.Insert(TxtJeniskendaraan.Text, int.Parse(TxtTarif.Text));
                Data();
            }
            //string insertQuery = "INSERT INTO biaya_parkir(`jenis_kendaraan`, `Tarif`) VALUES ('" + this.TxtJeniskendaraan.Text + "','" + this.TxtTarif.Text + "');";
            //ExecuteMyQuery(insertQuery);
            //Data();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LblID.Text))
            {
                BiayaParkir.Delete(int.Parse(LblID.Text));
                Data();
            }
            //string deleteQuery = "DELETE FROM biaya_parkir WHERE id_kendaraan = " + int.Parse(LblID.Text);
            //ExecuteMyQuery(deleteQuery);
            //Data();
        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LblID.Text) && !string.IsNullOrEmpty(TxtJeniskendaraan.Text) && !string.IsNullOrEmpty(TxtTarif.Text))
            {
                BiayaParkir.Update(int.Parse(LblID.Text), TxtJeniskendaraan.Text, int.Parse(TxtTarif.Text));
                Data();
            }
            //string deleteQuery = "UPDATE biaya_parkir SET jenis_kendaraan='" + TxtJeniskendaraan.Text + "',Tarif='" + TxtTarif.Text + "' WHERE  id_kendaraan = " + int.Parse(LblID.Text);
            //ExecuteMyQuery(deleteQuery);
            //Data();
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            LblID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtJeniskendaraan.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtTarif.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();

            TxtJeniskendaraan.Enabled = false;
            TxtTarif.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ss = new Parkir();
            ss.Closed += (s, args) => this.Close();
            ss.Close();
        }

        Bunifu.Framework.UI.Drag MoveFrom = new Bunifu.Framework.UI.Drag();
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFrom.Grab(this);
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveFrom.Release();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFrom.MoveObject();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.CurrentRow != null)
            {
                LblID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
                TxtJeniskendaraan.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtTarif.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            TxtJeniskendaraan.Enabled = true;
            TxtTarif.Enabled = true;
            TxtJeniskendaraan.Text = string.Empty;
            TxtTarif.Text = string.Empty;
        }
    }
}
