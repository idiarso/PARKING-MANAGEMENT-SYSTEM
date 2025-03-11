using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using MySql.Data.MySqlClient;
using ParkirApp.model;
using AForge.Video.DirectShow;
using AForge.Video;
namespace ParkirApp.controller
{
    class Form2C
    {
        private static VideoCaptureDevice FinalFrame;

        public static void tutup(VideoCaptureDevice final)
        {
            DialogResult result;
            result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                final.Stop();
                Form.ActiveForm.Close();

            }
        }
    }
}
