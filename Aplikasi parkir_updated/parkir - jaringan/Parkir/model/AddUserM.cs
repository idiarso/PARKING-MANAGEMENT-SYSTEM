using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ParkirApp.model
{
    class AddUserM
    {
        public static bool Insert(string username,string password,string nama,string alamat,string No_Hp,string privillage)
        {
            string updateQuery = @"INSERT INTO login(username,password,nama,alamat,No_Hp,Privillage) VALUES (@username,@password,@nama,@alamat,@No_Hp,@privillage)";
            var cmd = new MySqlCommand(updateQuery, new MySqlConnection(DatabaseUtility.ConnectionString));

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@alamat", alamat);
            cmd.Parameters.AddWithValue("@No_Hp", No_Hp);
            cmd.Parameters.AddWithValue("@privillage", privillage);
            return DatabaseUtility.ExecuteCommandNonQuery(cmd);
        }
    }
}
