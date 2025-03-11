using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using MySql.Data.MySqlClient;
using ParkirApp.view;

namespace ParkirApp
{
    public partial class Form1 : Form
    {
       

        public static string y;
        public Form1()
        {
            InitializeComponent();
        }
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");


        public string textcode
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try {
                pictureBox2.Image = (Image)eventArgs.Frame.Clone();
            }catch(Exception ex) { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            timer1.Start();

         
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }
        private void LblClose_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                FinalFrame.Stop();

                Application.Exit();
            }
        }

        private void btn_webcam_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_scanner_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            textBox1.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        


        private void timer1_Tick(object sender, EventArgs e)
        {

            y = textBox1.Text;
            try
            {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)pictureBox2.Image);
                string decoded = result.ToString().Trim();
                
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM db_parkir.login where barcode='" + decoded + "'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command1 = connection.CreateCommand();
                command.CommandText = "SELECT nama FROM db_parkir.login where barcode = '" + decoded + "'";
                command1.CommandText = "SELECT privillage FROM db_parkir.login where barcode = '" + decoded + "'";
                MySqlDataReader myReader;
                string x = "*";
                try
                {
                    connection.Open();
                    myReader = command.ExecuteReader();

                    while (myReader.Read())
                    {
                        x = myReader[0].ToString();

                    }
                    connection.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    connection.Open();
                    myReader = command1.ExecuteReader();

                    while (myReader.Read())
                    {
                        y = myReader[0].ToString();

                    }
                    connection.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                string u="Login sebagai : ";
                string a = "privillage :";
                if(y=="0")
                {
                    y = "user";
                }
                else
                {
                    y = "admin";
                }
                string z = string.Concat(u, x + System.Environment.NewLine, a,y);
                if (dt.Rows.Count > 0)
                {
                    
                    timer1.Stop();
                    
                    textBox1.Text = x;
                    MessageBox.Show(z);
                    FinalFrame.Stop();
                    this.Hide();
                    
                    //Parkir ss = new Parkir();
                    //ss.Show();

                }
                else
                {
                    timer1.Stop();
                    
                    textBox1.Text = "gagal";
                    MessageBox.Show("gagal login");
                    timer1.Start();


                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_loginbiasa_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login ss = new Login();
            ss.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                FinalFrame.Stop();

                Application.Exit();
            }
        }

        private void LblBatal_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                FinalFrame.Stop();
                Application.Exit();
            }
        }
    }
}
