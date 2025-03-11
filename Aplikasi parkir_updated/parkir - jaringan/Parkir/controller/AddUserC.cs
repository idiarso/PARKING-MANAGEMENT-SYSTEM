using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkirApp.view;
using System.Windows.Forms;

namespace ParkirApp.controller
{
    class AddUserC
    {
        public static void tutup()
        {
            Form.ActiveForm.Hide();
            var ss = new Parkir();
            ss.Closed += (s, args) => Form.ActiveForm.Close();
            ss.Close();
        }
    }
}
