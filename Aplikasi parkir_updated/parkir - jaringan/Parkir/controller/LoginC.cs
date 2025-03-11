using System;
using System.Windows.Forms;
using ParkirApp.model;
using ParkirApp.view;

namespace ParkirApp.controller
{
    public class LoginC
    {
        public static void masuk(string a,string b)
        {
            LoginM.IsUserValid(a, b);
            string c = "Login sebagai : ";
            string d = "privillage : ";
            if (LoginM.priv == "0")
                LoginM.priv = "user";
            if (LoginM.priv == "1")
                LoginM.priv = "admin";

            string e = string.Concat(c,a+Environment.NewLine,d,LoginM.priv);
            if (LoginM.IsUserValid(a, b) == true)
            {
                MessageBox.Show(e);
                Form.ActiveForm.Hide();
                Parkir pa = new Parkir();
                pa.Show();
              

            }
            else
                MessageBox.Show("error username atau password salah");


        }
        
       
        

        

        public static void tutup()
        {
           
            DialogResult result;
            result = MessageBox.Show("Anda yakin ingin Keluar??", "pilihan", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public static void sembunyi()
        {
            Form.ActiveForm.Hide();

            
        }
    }
}
