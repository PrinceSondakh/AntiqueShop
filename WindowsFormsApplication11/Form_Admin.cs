using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            panel_pembeli.Controls.Clear();
            AntiqueShop_pembeli a = new AntiqueShop_pembeli();
            a.TopLevel = false;
            //syntax utk menampilkan form di dalam panel
            panel_pembeli.Controls.Add(a);
            a.Show();
            panel_penjual.Controls.Clear();
            AntiqueShop b = new AntiqueShop();
            b.TopLevel = false;
            //syntax utk menampilkan form di dalam panel
            panel_penjual.Controls.Add(b);
            b.Show();
        }
    }
}
