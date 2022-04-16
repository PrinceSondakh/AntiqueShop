using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    static class Program
    {
        /// <summary>
        /// My name is Prince George Imanuel I made this application
        /// from 28 April to this day(22:21 PM,4 Mei)
        /// I will changed sms form to report form using crystal report later.
        /// Features: -Login as buyer, seller, admin. -Text to speech. -Enter., -Show pass.,-Search.,-.Retrieve information such as image and text
        /// -GPS.,-Pakai sistem uang.
        /// (-)Pembeli beli barang ke penjual,   pembeli uangnya berkurang . namun penjual tidak bertambah uangnya,
        /// TOP UP bisa untuk pembeli, penjual dan admin, saat transaksi yang berpengaruh hanya pembeli saja.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DOPFNS_RealWorld.antique_Login());
        }
    }
}
