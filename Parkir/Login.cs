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
using ParkirApp.model;
using ParkirApp.view;

namespace ParkirApp
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            
        }
        

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            if (LoginM.IsUserValid(TextboxName.Text, TextboxPws.Text))
            {
                this.Hide();

                Parkir ss = new Parkir();
                ss.Show();

            }
            else
            {
                MessageBox.Show("GAGAl LOGIN");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void LblBatal_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        Bunifu.Framework.UI.Drag MoveFrom = new Bunifu.Framework.UI.Drag();
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFrom.Grab(this);
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveFrom.Release();
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFrom.MoveObject();
        }

        private void TextboxPws_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

           Form1 ss = new Form1();
            ss.Show();
        }
    }
}
