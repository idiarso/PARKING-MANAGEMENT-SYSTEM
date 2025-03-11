using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ParkirApp.model;
namespace ParkirApp.view
{
    public partial class DataParkir : UserControl
    {
        public DataParkir()
        {
            InitializeComponent();
        }


        private void DataParkir_Load(object sender, EventArgs e)
        {
            InitDataParkir();

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            InitDataParkir();
        }

        private void InitDataParkir()
        {
            DataGridView1.DataSource = DataParkirM.GetListData();
            Label3.Text = DataParkirM.TotalTarif().ToString();
        }
    }
}
