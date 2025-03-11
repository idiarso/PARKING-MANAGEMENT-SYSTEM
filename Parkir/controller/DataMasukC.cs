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
namespace ParkirApp.controller
{
    class DataMasukC
    {
        // Create string to draw.
        // FIXED
        public static String PrintOut = "Karcis Parkir\r\nNo Masuk : "+ DataMasukM.Nomasuk().ToString()  + "\r\nNo Kendaraan : "+ DataMasukM.Nokendaraan().ToString()  + "\r\nTerima Kasih atas kunjungan anda";
        public static String top = "Karcis Parkir";

        public static String Nomasuk = "No Masuk : ";
        public static String Nokendaraan = "No Kendaraan : ";
        public static String Nomasuk1 = DataMasukM.Nomasuk().ToString();
        public static String Nomasuk2 = string.Concat("*", Nomasuk1, "*");
        public static String Nokendaraan1 = DataMasukM.Nokendaraan().ToString();
        public static String bottom = "Terima Kasih atas kunjungan anda";

        // Create font and brush.
        public static Font Arial = new Font("Arial", 14);
        public static Font Barcode = new Font("IDAutomationHC39M Free Version", 18);
        public static SolidBrush drawBrush = new SolidBrush(Color.Black);
        public static float x = 0.0F;
        public static float y = 0.0F;
        // Create point for upper-left corner of drawing.
        public static  PointF drawPoint= new PointF(0.0F, 0.0F);

        public static PointF drawPoint1 = new PointF(0.0F, 120.0F);
        public static void Point(float a,float b)
        {
            a = x;
            b = y;
        }
        //e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);

    }
}
