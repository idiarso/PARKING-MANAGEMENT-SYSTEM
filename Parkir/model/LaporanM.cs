using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ParkirApp.view;
using MySql.Data.MySqlClient;
using Bunifu.Framework.UI;

namespace ParkirApp.model
{
    public class LaporanM
    {
        DataTable x = new DataTable();
        // public void tampil(Datepicker1.Value.ToString, Datepicker2.Value.ToString, dataGridView1)
        //{
        public static void sumbertampil(string x, string y)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;Convert Zero Datetime=True;Allow Zero Datetime=True;");

            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT * FROM parkir_masuk WHERE tanggal_Masuk between '" + x + ("yyyy-MM-dd") + "' and '" + y + ("yyyy-MM-dd") + "'", connection);
            DataTable sd = new DataTable();
            sdf.Fill(sd);

            //dataGridView1.DataSource = sd;
        }

        public static DataTable GetListData(string date1, string date2)
        {
            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT * FROM parkir_masuk WHERE tanggal_Masuk between '" + date1 + "' and '" + date2 + "'", DatabaseUtility.ConnectionString);
            DataTable sd = new DataTable();
            sdf.Fill(sd);

            return sd;
        }
    }
}

