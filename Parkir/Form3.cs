using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ParkirApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

            


           
 
            //connection.Open();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            string query = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection con = new MySqlConnection(query);
            
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select max(no_masuk) FROM db_parkir.parkir_masuk";
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    label1.Text = myReader[0].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();


        }
    }
}
