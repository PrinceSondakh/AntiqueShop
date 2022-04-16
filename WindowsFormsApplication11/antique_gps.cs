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
//Progammed by Prince Imanuel , 1 May 2018
namespace WindowsFormsApplication11
{
    public partial class antique_gps : Form
    {
        public antique_gps()
        {
            InitializeComponent();
        }
        DataTable dbdataset;
        private void load_aja()
        {
            //load table 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT id_barang, nama_barang, tipe_barang, asal_barang, harga_barang, berat_barang, jumlah_stok, tanggal_pembuatan_barang,nama_tempat,nama_kota,nama_provinsi,no_telp_email FROM antique.barang;", myConn);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string street = textBox_street.Text;
            string city = textBox_city.Text;
            string state = textBox_state.Text;
            string zip = textBox_zip.Text;

            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");
                if (street != string.Empty) {
                    queryaddress.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    queryaddress.Append(city + "," + "+");
                }
                if (state != string.Empty)
                {
                    queryaddress.Append(state + "," + "+");
                }
                if (zip != string.Empty)
                {
                    queryaddress.Append(zip + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString(), "Error");

            }

        }

        private void antique_gps_Load(object sender, EventArgs e)
        {
            load_aja();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            load_aja();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dbdataset);
            dv.RowFilter = string.Format("nama_barang LIKE '%{0}%'", textBox_search.Text);
            dataGridView1.DataSource = dv;
        }

        private void textBox_zip_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.button1;
        }

        private void textBox_state_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.button1;
        }

        private void textBox_city_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.button1;
        }

        private void textBox_street_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.button1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox_tumbal.Text = row.Cells["id_barang"].Value.ToString();
            textBox_tumbal1.Text = row.Cells["nama_barang"].Value.ToString();
            textBox_tumbal2.Text = row.Cells["tipe_barang"].Value.ToString();
            textBox_tumbal3.Text = row.Cells["asal_barang"].Value.ToString();
            textBox_tumbal4.Text = row.Cells["harga_barang"].Value.ToString();
            textBox_tumbal5.Text = row.Cells["berat_barang"].Value.ToString();
            textBox_tumbal6.Text = row.Cells["jumlah_stok"].Value.ToString();
            textBox_tumbal7.Text = row.Cells["tanggal_pembuatan_barang"].Value.ToString();
            textBox_tumbal8.Text = row.Cells["nama_tempat"].Value.ToString();
            textBox_tumbal9.Text = row.Cells["nama_kota"].Value.ToString();
            textBox_tumbal10.Text = row.Cells["nama_provinsi"].Value.ToString();
            textBox_tumbal11.Text = row.Cells["no_telp_email"].Value.ToString();
            textBox_street.Text = row.Cells["nama_tempat"].Value.ToString();
            textBox_city.Text = row.Cells["nama_kota"].Value.ToString();
            textBox_state.Text = row.Cells["nama_provinsi"].Value.ToString();
            textBox_zip.Text = row.Cells["no_telp_email"].Value.ToString();
        }
    }
}
