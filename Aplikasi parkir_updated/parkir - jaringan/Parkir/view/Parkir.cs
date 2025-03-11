using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkirApp.view;
using ParkirApp.model;
namespace ParkirApp.view
{
    public partial class Parkir : Form
    {
        public Parkir()
        {
            InitializeComponent();
        }

        private void Parkir_Load(object sender, EventArgs e)
        {

        }


        Bunifu.Framework.UI.Drag MoveFrom = new Bunifu.Framework.UI.Drag();
        private void Panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFrom.Grab(this);
        }

        private void Panel3_MouseUp(object sender, MouseEventArgs e)
        {
            MoveFrom.Release();
        }

        private void Panel3_MouseMove(object sender, MouseEventArgs e)
        {
            MoveFrom.MoveObject();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (Side.Width >= 200)
            {
                PictureLogo.Location = new Point(12, 78);
                PictureLogo.Size = new Size(38, 36);
                Side.Width = 67;
            }
            else
            {
                PictureLogo.Location = new Point(10, 1);
                PictureLogo.Size = new Size(163, 174);
                Side.Width = 200;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMasuk_Click(object sender, EventArgs e)
        {
            dataMasuk1.BringToFront();
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            dataKeluar1.BringToFront();
        }

        private void BtnDataParkir_Click(object sender, EventArgs e)
        {
            dataParkir1.BringToFront();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnLaporan_Click(object sender, EventArgs e)
        {
            laporan1.BringToFront();
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {

        }

        private void Tarif1_Load(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnOptions_Click_1(object sender, EventArgs e)
        {
            if (LoginM.priv == "0")
            {
                MessageBox.Show("error hanya untuk admin");
            }
            if (LoginM.priv == "1")
            {
                options1.BringToFront();
            }

        }

        private void options1_Load(object sender, EventArgs e)
        {

        }

        private void options2_Load(object sender, EventArgs e)
        {

        }
    }
}
