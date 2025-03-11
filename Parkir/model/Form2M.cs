using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace ParkirApp.model
{
    class Form2M
    {
        
        

      

     
            public static DataTable keluar(string decoded)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM db_parkir.parkir_masuk where no_masuk='" + decoded + "'", DatabaseUtility.ConnectionString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
        public static void update(string decoded)
        {
            string updateQuery = "UPDATE parkir_masuk a join biaya_parkir b SET a.tanggal_keluar = CURDATE(), a.jam_keluar = curtime(),a.Tarif = b.Tarif WHERE a.no_masuk ='" + decoded + "'";
            DatabaseUtility.ExecuteMyQuery(updateQuery);
        }
    }
}

