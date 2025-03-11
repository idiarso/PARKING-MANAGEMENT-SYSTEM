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
namespace ParkirApp.view
{
    public partial class Laporan : UserControl
    {
        public Laporan()
        {
            InitializeComponent();
        }

        //MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;Convert Zero Datetime=True;Allow Zero Datetime=True;");
        private void Laporan_Load(object sender, EventArgs e)
        {

        }

        private void BtnTampilkan_Click(object sender, EventArgs e)
        {

          // MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT * FROM parkir_masuk WHERE tanggal_Masuk between '" + Datepicker1.Value.ToString("yyyy-MM-dd") + "' and '" + Datepicker2.Value.ToString("yyyy-MM-dd") + "'", connection);
          // DataTable sd = new DataTable();
          //sdf.Fill(sd);
             
          //sd= LaporanM.sumbertampil(Datepicker2.Value.ToString, Datepicker1.Value.ToString);
            dataGridView1.DataSource = LaporanM.GetListData(Datepicker1.Value.ToString("yyyy-MM-dd"), Datepicker2.Value.ToString("yyyy-MM-dd"));

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog1.Document = PrintDocument1;
            PrintPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(objBmp, 120, 100);

            e.Graphics.DrawString(label1.Text, new Font("Verdana", 30, FontStyle.Bold), Brushes.Black, new Point(300, 30));
        }
    }
}
