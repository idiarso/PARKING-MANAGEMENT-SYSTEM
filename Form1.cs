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
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM db_parkir.login where username='" + tbuser.Text + "' and password = '" + tbpass.Text + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {

                this.Hide();
                Masuk ss = new Masuk();
                ss.Show();
               

            }
            else
            {
                MessageBox.Show("GAGAl LOGIN");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result;
                result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        // Add method to open the Gate Exit System
        private void btnGateExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            GateExitForm gateExitForm = new GateExitForm();
            gateExitForm.Show();
        }
    }
}
