using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using MySql.Data.MySqlClient;
using ParkirApp.model;
using ParkirApp.controller;
namespace ParkirApp.view
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //MySqlConnection connection = new MySqlConnection("datasource=localhost;database=db_parkir;port=3306;username=root;password=");
    
        //MySqlCommand command;
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
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

        public string textcode
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox2.Image = (Image)eventArgs.Frame.Clone();
            }
            catch (Exception ex) { }

        }
        private void LblClose_Click(object sender, EventArgs e)
        {
            //DialogResult result;
            //result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            //if (result == DialogResult.Yes)
            //{
            //    FinalFrame.Stop();
            //    this.Hide();

            //}
            Form2C.tutup(FinalFrame);
            
        }

        private void LblBatal_Click(object sender, EventArgs e)
        {
            //DialogResult result;
            //result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            //if (result == DialogResult.Yes)
            //{
            //    FinalFrame.Stop();
            //    this.Hide();
            //}
            
            Form2C.tutup(FinalFrame);
       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_webcam_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            
            FinalFrame.Start();
            btn_webcam.Enabled = false;
            btn_scanner.Enabled = true;
        }

        private void btn_scanner_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btn_scanner.Enabled = false;
            textBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)pictureBox2.Image);
                string decoded = result.ToString().Trim();
                textBox1.Text = decoded;
                //MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM db_parkir.parkir_masuk where no_masuk='" + decoded + "'", connection);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                //string updateQuery = "UPDATE parkir_masuk a join biaya_parkir b SET a.tanggal_keluar = CURDATE(), a.jam_keluar = curtime(),a.Tarif = b.Tarif WHERE a.no_masuk ='"+ decoded+ "'";



                if (Form2M.keluar(decoded).Rows.Count > 0)
                {
                    timer1.Stop();
                    Form2M.update(decoded);
                    textBox1.Text = decoded;
                    timer1.Start();

                }
                else
                {
                    timer1.Stop();
                    btn_scanner.Enabled = true;
                    textBox1.Text = decoded;
                    MessageBox.Show("error,no tidak ada dalam database");
                    
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }
    }
}
