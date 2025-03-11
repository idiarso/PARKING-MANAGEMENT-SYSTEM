using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkirApp.model
{
    public class BiayaParkirM
    {
        #region Private Variable
        private int _id_kendaraan;
        private string _jenis_kendaraan;
        private int _tarif;

        public BiayaParkirM()
        {
            _id_kendaraan = 0;
            _jenis_kendaraan = string.Empty;
            _tarif = 0;
        }
        #endregion

        #region Property
        public int Id_Kendaraan
        {
            get { return _id_kendaraan; }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    _id_kendaraan = value;
                }
            }
        }

        public string Jenis_Kendaraan
        {
            get { return _jenis_kendaraan; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _jenis_kendaraan = value;
                }
            }
        }

        public int Tarif
        {
            get { return _tarif; }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    _tarif = value;
                }
            }
        }
        #endregion

        #region Method
        public static List<BiayaParkirM> GetBiayaParkir()
        {
            List<BiayaParkirM> list = new List<BiayaParkirM>();
            MySqlConnection conn = new MySqlConnection(DatabaseUtility.ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM biaya_parkir", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                BiayaParkirM biayaParkir = new BiayaParkirM();
                if(!string.IsNullOrEmpty(row["id_kendaraan"].ToString()))
                    biayaParkir.Id_Kendaraan = int.Parse(row["id_kendaraan"].ToString());
                if (!string.IsNullOrEmpty(row["tarif"].ToString()))
                    biayaParkir.Tarif = int.Parse(row["tarif"].ToString());
                biayaParkir.Jenis_Kendaraan = row["jenis_kendaraan"].ToString();

                list.Add(biayaParkir);
            }
            conn.Close();
            return list;
        }
        #endregion
    }
}
