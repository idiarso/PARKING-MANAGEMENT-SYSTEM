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

namespace parkir
{
    public partial class DataUser : Form
    {
        public DataUser()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;Initial Catalog='db_parkir';port=3306;username=root;password=;");

        private void DataUser_Load(object sender, EventArgs e)
        {

        }

        

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO login(`username`, `password`, `nama`, `alamat`, `No_Hp`) VALUES ('" + this.textBoxUsername.Text + "','" + this.textBoxPassword.Text + "','" +this.textBoxNama.Text +"','" + this.textBoxAlamat.Text + "','" + this.textBoxNoHp.Text + "');";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Tersimpan");
                }
                else
                {
                    MessageBox.Show("Data tidak tersimpan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masuk ss = new Masuk();
            ss.Show();
        }

        private void btnDataUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataPetugas ss = new DataPetugas();
            ss.Show();
        }
    }
}
