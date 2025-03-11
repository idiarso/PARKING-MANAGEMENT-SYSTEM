using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ParkirApp.controller
{
    class ParkirC
    {
        public static void tutup()
        {
            DialogResult result;
            result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
