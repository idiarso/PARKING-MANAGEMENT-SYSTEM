using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkirApp.view;
using System.Windows.Forms;
namespace ParkirApp.controller
{
    class OptionsC
    {
        public static void tarif()
        {
            PengaturanTarif ss = new PengaturanTarif();
            ss.Show();
        }
        public static void adduser()
        {
            AddUser ss = new AddUser();
            
            ss.Show();
        }
        public static void user()
        {
            ParkirApp.view.DataUser ss = new ParkirApp.view.DataUser();
            ss.Show();
        }
    }
}
