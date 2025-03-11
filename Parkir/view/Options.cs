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
using ParkirApp.view;
using ParkirApp.controller;


namespace ParkirApp.view
{
    public partial class Options : UserControl
    {
      
        public Options()
        {
            InitializeComponent();
        }

        

        private void Options_Load(object sender, EventArgs e)
        {
            
                
            
        }

        private void BtnTarif_Click(object sender, EventArgs e)
        {
            OptionsC.tarif();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            OptionsC.adduser();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            OptionsC.user();
        }
    }
}
