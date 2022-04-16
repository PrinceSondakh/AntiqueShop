using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//Progammed by Prince Imanuel, 1 May 2018
namespace WindowsFormsApplication11
{
    public partial class antique_report : Form
    {
        public antique_report()
        {
            InitializeComponent();
        }
        DataTable dbdataset;
        private void represh() {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM antique.transaksi", myConn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                dbdataset = new DataTable();

                sda.Fill(dbdataset);


                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;


                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            represh();
        }

        private void antique_report_Load(object sender, EventArgs e)
        {
            represh();
        }
    }
}
