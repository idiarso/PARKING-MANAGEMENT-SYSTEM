using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace ParkirApp.model
{
    class DataUserM
    {
        public static DataTable GetListData()
        {
            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT id_petugas,nama,alamat,no_Hp,Privillage from login", DatabaseUtility.ConnectionString);
            DataTable sd = new DataTable();
            sdf.Fill(sd);

            return sd;
        }
    }
}
