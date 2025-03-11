using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace ParkirApp.model
{
    class DataKeluarM
    {
        
        public static DataTable GetListData()
        {
            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT a.no_masuk, a.no_kendaraan, a.tanggal_masuk, a.jam_masuk, a.tanggal_keluar, a.jam_keluar, b.jenis_kendaraan, b.Tarif FROM parkir_masuk a join biaya_parkir b where a.id_kendaraan = b.id_kendaraan", DatabaseUtility.ConnectionString);
            DataTable sd = new DataTable();
            sdf.Fill(sd);

            return sd;
        }
        public static DataTable SearchData(string valueToSearch)
        {

            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT * FROM parkir_masuk WHERE CONCAT(no_kendaraan) like '%" + valueToSearch + "%'", DatabaseUtility.ConnectionString);
            DataTable sd = new DataTable();
            sdf.Fill(sd);
            return sd;
            
            
        }
        public static void UpdateData(string x)
        {
            
       
                string updateQuery = @"UPDATE db_parkir.parkir_masuk a join biaya_parkir b 
                SET a.tanggal_keluar = CURDATE(), a.jam_keluar = curtime(),a.Tarif = b.Tarif WHERE a.no_masuk = '" + int.Parse(x) + "'";
                var cmd = new MySqlCommand(updateQuery, new MySqlConnection(DatabaseUtility.ConnectionString));

                cmd.CommandType = CommandType.Text;
            DatabaseUtility.ExecuteMyQuery(updateQuery);
               

            //cmd.Parameters.AddWithValue("@x", int.Parse(x));


        }
        public static void UpdateData2(string y)
        {
           
                string updateQuery = @"UPDATE db_parkir.parkir_masuk a join biaya_parkir b 
                SET a.tanggal_keluar = CURDATE(), a.jam_keluar = curtime(),a.Tarif = b.Tarif WHERE a.no_kendaraan = '" + y + "'";
                var cmd = new MySqlCommand(updateQuery, new MySqlConnection(DatabaseUtility.ConnectionString));

                cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("@x", int.Parse(x));
            DatabaseUtility.ExecuteMyQuery(updateQuery);




        }
        public static void UpdateData3(string x,string y)
        {
        
                string updateQuery = @"UPDATE db_parkir.parkir_masuk a join biaya_parkir b 
                SET a.tanggal_keluar = CURDATE(), a.jam_keluar = curtime(),a.Tarif = b.Tarif WHERE a.no_masuk = '" + int.Parse(x) + "' or a.no_kendaraan= '" + y + "'";
                var cmd = new MySqlCommand(updateQuery, new MySqlConnection(DatabaseUtility.ConnectionString));

                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@x", int.Parse(x));
                DatabaseUtility.ExecuteCommandNonQuery(cmd);
          
        }
        public static void UpdateData4(string x, string y)
        {
           
            if (!string.IsNullOrEmpty(x))
                UpdateData(x);
             else if (!string.IsNullOrEmpty(y))
                UpdateData2(y);
           

            else
                MessageBox.Show("error data harus diisi");
            

            
        }
    }
}
