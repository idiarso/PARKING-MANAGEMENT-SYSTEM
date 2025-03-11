using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkirApp.view;
using MySql.Data.MySqlClient;
using System.Data;
using ParkirApp.model;
using System.Windows.Forms;
namespace ParkirApp.model
{
    public class LoginM
    {
        public static string priv = "0";
        public static bool IsUserValid(string username, string password)
        {
            bool result = false;

            
            
            MySqlConnection conn = new MySqlConnection(DatabaseUtility.ConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(@"SELECT * FROM login 
                WHERE username='" + username + "' and password = '" + password + "'", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            

            DataTable dt = new DataTable();

            adp.Fill(dt); 
            MySqlCommand command1 = conn.CreateCommand();
            command1.CommandText = "SELECT Privillage FROM db_parkir.login where username='" + username + "'";
            MySqlDataReader myReader1;
            myReader1 = command1.ExecuteReader();

            if (dt.Rows.Count > 0)
            {
                result = true;
                while (myReader1.Read())
                {
                    priv = myReader1[0].ToString();
                }

            }

            conn.Close();
            return result;
        }
        
    }
}
