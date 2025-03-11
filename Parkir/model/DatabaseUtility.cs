using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
namespace ParkirApp.model
{
    public static class DatabaseUtility
    {

        public static string ConnectionString
        {
            get
            {
                //string connectionString = "server=localhost;user=dev;database=db_parkir;port=3306;password=Dev*8";
                string connectionString = "server=localhost;user=root;database=db_parkir;port=3306;password=";
                //string connectionString = "datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;Convert Zero Datetime=True;Allow Zero Datetime=True;";
                return connectionString;
            }

        }
        public static bool ExecuteCommandNonQuery(MySqlCommand inSqlCommand)
        {
            bool executed = false;
            try
            {
                if (inSqlCommand.Connection.State != ConnectionState.Open)
                {
                    inSqlCommand.Connection.Open();
                }

                inSqlCommand.ExecuteNonQuery();
                executed = true;
            }
            catch (Exception ex)
            {
                Trace.TraceError("'{0}', '{1}'", "DatabaseUtility", ex.Message);
            }
            finally
            {
                inSqlCommand.Connection.Close();
            }
            return executed;
        }
        public static DataTable GetTableByQuery(string inSelectCommand, MySqlConnection inSqlConnection)
        {
            var table = new DataTable();
            var dataSet = new DataSet();
            MySqlDataAdapter adapter;

            try
            {
                if (inSqlConnection.State != ConnectionState.Open)
                {
                    inSqlConnection.Open();
                }
                adapter = new MySqlDataAdapter(inSelectCommand, inSqlConnection);
                adapter.Fill(dataSet);
                table = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                Trace.TraceError("'{0}', '{1}'", "DatabaseUtility", ex.Message);
            }
            finally
            {
                inSqlConnection.Close();
            }

            return table;
        }



        static MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;Convert Zero Datetime=True;Allow Zero Datetime=True;");
        //static MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=dev;password=Dev*8;Convert Zero Datetime=True;Allow Zero Datetime=True;");
        static MySqlCommand command;
        public static void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static void ExecuteMyQuery(string query)
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Selamat Data Anda Berhasil Di Simpan");
                }
                else
                {
                    MessageBox.Show("Data Gagal di Simpan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }


        }


    }
}
