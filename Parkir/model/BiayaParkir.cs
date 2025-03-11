using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkirApp.model
{
    class BiayaParkir
    {
        private int _id_kendaraan;
        private string _jenis_kendaraan;
        private int _tarif;

        public BiayaParkir()
        {
            _id_kendaraan = 0;
            _jenis_kendaraan = string.Empty;
            _tarif = 0;
        }

        public int IdKendaraan
        {
            get { return _id_kendaraan; }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                    _id_kendaraan = value;
            }
        }

        public string JenisKendaraan
        {
            get { return _jenis_kendaraan; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _jenis_kendaraan = value;
            }
        }

        public int Tarif
        {
            get { return _tarif; }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                    _tarif = value;
            }
        }

        public static DataTable GetListData()
        {
            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT * FROM biaya_parkir", DatabaseUtility.ConnectionString);
            DataTable sd = new DataTable();
            sdf.Fill(sd);

            return sd;
        }

        public static bool IsExist(int id)
        {
            MySqlDataAdapter sdf = new MySqlDataAdapter("SELECT * FROM biaya_parkir WHERE id_kendaraan = "+ id, DatabaseUtility.ConnectionString);
            DataTable sd = new DataTable();
            sdf.Fill(sd);

            if (sd.Rows.Count > 0)
                return true;

            return false;
        }

        public static bool Update(int id, string jenisKendaraan, int tarif)
        {
            string updateQuery = @"UPDATE biaya_parkir SET jenis_kendaraan = @jenis_kendaraan,Tarif = @tarif WHERE  id_kendaraan = @id_kendaraan";
            var cmd = new MySqlCommand(updateQuery, new MySqlConnection(DatabaseUtility.ConnectionString));

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id_kendaraan", id);
            cmd.Parameters.AddWithValue("@jenis_kendaraan", jenisKendaraan);
            cmd.Parameters.AddWithValue("@tarif", tarif);
            return DatabaseUtility.ExecuteCommandNonQuery(cmd);
        }

        public static bool Insert(string jenisKendaraan, int tarif)
        {
            string updateQuery = @"INSERT INTO biaya_parkir(jenis_kendaraan, Tarif) VALUES (@jenis_kendaraan, @tarif)";
            var cmd = new MySqlCommand(updateQuery, new MySqlConnection(DatabaseUtility.ConnectionString));

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@jenis_kendaraan", jenisKendaraan);
            cmd.Parameters.AddWithValue("@tarif", tarif);
            return DatabaseUtility.ExecuteCommandNonQuery(cmd);
        }

        public static bool Delete(int id)
        {
            string updateQuery = @"DELETE FROM biaya_parkir WHERE id_kendaraan = @id_kendaraan";
            var cmd = new MySqlCommand(updateQuery, new MySqlConnection(DatabaseUtility.ConnectionString));

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id_kendaraan", id);
            return DatabaseUtility.ExecuteCommandNonQuery(cmd);
        }
    }
}
