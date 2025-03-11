using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkirApp.model;
using ParkirApp.controller;

namespace ParkirApp.view
{
    public partial class LoginV : Form
    {
        public LoginV()
        {
            InitializeComponent();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            LoginC.masuk(TextboxName.Text, TextboxPws.Text);
        }

        private void LblBatal_Click(object sender, EventArgs e)
        {
            LoginC.tutup();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            LoginC.tutup();
        }

        private void TextboxName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                LoginC.masuk(TextboxName.Text, TextboxPws.Text);

            }

        }

        private void txtuser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                LoginC.masuk(TextboxName.Text, TextboxPws.Text);

            }

        }
    }
}
