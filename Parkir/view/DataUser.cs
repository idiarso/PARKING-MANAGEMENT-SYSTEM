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
using ParkirApp.controller;
using ParkirApp.model;
namespace ParkirApp.view
{
    public partial class DataUser : Form
    {
        public DataUser()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;");

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void DataUser_Load(object sender, EventArgs e)
        {
            Data();
            
        }
        public void Data()
        {
            DataGridView1.DataSource = DataUserM.GetListData();
            //try
            //{

            //    string selectQuery = "SELECT `id_petugas`, `nama`, `alamat`, `No_Hp` FROM login";
            //    MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            //    connection.Open();
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds, "login");
            //    DataGridView1.DataSource = ds.Tables["login"];
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.DataGridView1.Width, this.DataGridView1.Height);
            DataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.DataGridView1.Width, this.DataGridView1.Height));

            e.Graphics.DrawImage(objBmp, 120, 100);

            e.Graphics.DrawString(Label1.Text, new Font("Verdana", 30, FontStyle.Bold), Brushes.Black, new Point(300, 30));
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog1.Document = PrintDocument1;
            PrintPreviewDialog1.ShowDialog();
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //var ss = new Parkir();
            //ss.Closed += (s, args) => this.Close();
            //ss.Close();
            DataUserC.tutup();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //var ss = new Parkir();
            //ss.Closed += (s, args) => this.Close();
            //ss.Close();
            DataUserC.tutup();
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

     
    }
}

