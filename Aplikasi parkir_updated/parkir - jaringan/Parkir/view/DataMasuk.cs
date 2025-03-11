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
    public partial class DataMasuk : UserControl
    {
        public DataMasuk()
        {
            InitializeComponent();
        }

     
        private void DataMasuk_Load(object sender, EventArgs e)
        {
            Koneksi();
            Combo();
        }

        public void Koneksi()
        {
            Timer1.Start();
            LblDate.Text = DateTime.Now.ToString("dd-MM-yyyy").ToString();
            LblTime.Text = DateTime.Now.ToString("H:mm tt").ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToLongTimeString();
            Timer1.Start();
        }

        void Combo()
        {
            try
            {
                //MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;Convert Zero Datetime=True;Allow Zero Datetime=True;");
                //string selectQuery = "SELECT * FROM biaya_parkir";
                //connection.Open();
                //MySqlCommand command = new MySqlCommand(selectQuery, connection);
                //MySqlDataReader reader = command.ExecuteReader();
                //DataSet ds = new DataSet();
                List<BiayaParkirM> list = BiayaParkirM.GetBiayaParkir();

                //while (reader.Read())
                ComboxJenisKendaraan.Items.Clear();
                foreach (BiayaParkirM biayaParkir in list)
                {
                    ComboxJenisKendaraan.Items.Add(biayaParkir.Id_Kendaraan + " " + biayaParkir.Jenis_Kendaraan);
                    ComboxJenisKendaraan.ValueMember = biayaParkir.Id_Kendaraan.ToString();
                    ComboxJenisKendaraan.DisplayMember = biayaParkir.Jenis_Kendaraan.ToString();
                    //ComboxJenisKendaraan.Items.Add(reader["id_kendaraan"].ToString() + " " + reader["jenis_kendaraan"].ToString());
                    //ComboxJenisKendaraan.ValueMember = reader["id_kendaraan"].ToString();
                    //ComboxJenisKendaraan.DisplayMember = reader["jenis_kendaraan"].ToString();
                    //ComboxJenisKendaraan.DataSource = ds.Tables["parkir_masuk"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LblDate_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            //string insertQuery = "INSERT INTO parkir_masuk(`no_kendaraan`, `id_kendaraan`, `tanggal_Masuk`, `jam_Masuk`) VALUES ('" + this.TextboxNo.Text + "','" + this.ComboxJenisKendaraan.Text + "', CURDATE(), curtime());";
            //  ExecuteMyQuery(insertQuery);
            // FIXED
            string[] idKendaraan = ComboxJenisKendaraan.Text.Split(' ');
            DataMasukM.simpan(TextboxNo.Text, idKendaraan[0]);
            Combo();
            printPreviewDialog1.ShowDialog();
       // printDocument1.Print();
            
        }

      
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // FIXED
            e.Graphics.DrawString(DataMasukC.PrintOut, DataMasukC.Arial, DataMasukC.drawBrush, DataMasukC.drawPoint);

            e.Graphics.DrawString(DataMasukC.Nomasuk2.ToString(), DataMasukC.Barcode, DataMasukC.drawBrush, DataMasukC.drawPoint1);
            //DataMasukC.Point(0F, 0F);
            //e.Graphics.DrawString(DataMasukC.top, DataMasukC.Arial, DataMasukC.drawBrush, DataMasukC.drawPoint);
            //DataMasukC.Point(0F, 15F);
            //e.Graphics.DrawString(DataMasukC.Nomasuk, DataMasukC.Arial, DataMasukC.drawBrush, DataMasukC.drawPoint);
            //DataMasukC.Point(0F, 30F);
            //e.Graphics.DrawString(DataMasukC.Nomasuk1, DataMasukC.Arial, DataMasukC.drawBrush, DataMasukC.drawPoint);
            //DataMasukC.Point(0F, 45F);
            //e.Graphics.DrawString(DataMasukC.Nokendaraan, DataMasukC.Arial, DataMasukC.drawBrush, DataMasukC.drawPoint);
            //DataMasukC.Point(0F, 60F);
            //e.Graphics.DrawString(DataMasukC.Nokendaraan1, DataMasukC.Arial, DataMasukC.drawBrush, DataMasukC.drawPoint);
            //DataMasukC.Point(0F, 75F);
            //e.Graphics.DrawString(DataMasukC.Nomasuk1, DataMasukC.Barcode, DataMasukC.drawBrush, DataMasukC.drawPoint);
            //DataMasukC.Point(0F, 90F);
            //e.Graphics.DrawString(DataMasukC.bottom, DataMasukC.Barcode, DataMasukC.drawBrush, DataMasukC.drawPoint);
            // e.Graphics.DrawString("Karcis Parkir", new Font("Arial", 14),new  SolidBrush(Color.Black),new  PointF(0.0F, 0.0F));

            //e.Graphics.DrawString("Karcis Parkir", new Font("Arial", 14), new SolidBrush(Color.Black), new PointF(0.0F, 15.0F));

        }

        private void noken(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                DataMasukM.simpan(TextboxNo.Text, ComboxJenisKendaraan.Text);

            }
        }

        public void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
