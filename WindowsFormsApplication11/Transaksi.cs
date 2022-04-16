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
using System.IO;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
/*
Made by Prince George Imanuel 4 May 2018
Fitur: retrieve info, gambar, fungsi search, stok(min 1 max 100k), check terlebih dahulu, lalu yang ditampilkan hanyalah
barang yang masih ada stok nya kalo gak ya gak ditampilkan, lalu saat di beli stoknya akan berkurang. Data transaksi masuk di tabel transaksi.
*/
namespace Ujian___Transaksi_rental_mobil
{
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }
        DataTable dbdataset;
        MySqlCommand command;
        MySqlDataAdapter da;
        int check = 0;
        int total_sisa_barang = 0;
        /* void fillCombo()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "SELECT * FROM antique.barang";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string sName = myReader.GetString("nama_barang");// load field nama from table db_customer
                   // comboBox1.Items.Add(sName); //add nama into ComboBoxItem
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "SELECT * FROM antique.barang where nama_barang='" + comboBox1.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string sID = myReader.GetString("id_barang").ToString();
                    label_id.Text = sID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } */
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            label_noimage.Text = "NO IMAGE";
            refresh_table();
        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = null;
            label_noimage.Text = "NO IMAGE";
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            label_ib.Text = row.Cells["id_barang"].Value.ToString();
            label_nb.Text = row.Cells["nama_barang"].Value.ToString();
            label_tb.Text = row.Cells["tipe_barang"].Value.ToString();
            label_ab.Text = row.Cells["asal_barang"].Value.ToString();
            label_hb.Text = row.Cells["harga_barang"].Value.ToString();
            label_bb.Text = row.Cells["berat_barang"].Value.ToString();
            label_js.Text = row.Cells["jumlah_stok"].Value.ToString();
            label_nt.Text = row.Cells["nama_tempat"].Value.ToString();
            label_nk.Text = row.Cells["nama_kota"].Value.ToString();
            label_np.Text = row.Cells["nama_provinsi"].Value.ToString();
            label_nte.Text = row.Cells["no_telp_email"].Value.ToString();
            f4w();
        }
        private void f4w()
        {

            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection connection = new MySqlConnection(myConnection);

            String selectQuery = "SELECT * FROM antique.barang WHERE id_barang = '" + label_ib.Text + "'";
            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            byte[] img = (byte[])table.Rows[0][12];
            try
            {
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                label_noimage.Text = "";
                da.Dispose();
            }
            catch (Exception a)
            {

            }

        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            refresh_table();
        }

        public void refresh_table()
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT id_barang, nama_barang, tipe_barang, asal_barang, harga_barang, berat_barang, jumlah_stok, tanggal_pembuatan_barang,nama_tempat,nama_kota,nama_provinsi,no_telp_email FROM antique.barang where jumlah_stok !=0", myConn);
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


        void hitharga()
        {
            try
            {
                int total = 0; // total utk cek jumlah stok tersisa
                int total2 = 0; // total utk mengkalikan jumlah yg dibutuhkan dengan harga barang
                int total3 = 0; // utk menghitung jumlah stok yg diambil
                //count total
                total = Convert.ToInt32(label_js.Text) - Convert.ToInt32(numericUpDown1.Text);
                total2 = Convert.ToInt32(numericUpDown1.Text) * Convert.ToInt32(label_hb.Text);
                total3 = Convert.ToInt32(numericUpDown1.Text);
                label_total_harga.Text = total2.ToString();
                label_jumlah_stok_tersisa.Text = total.ToString();
                label_stok_yg_diambil.Text = total3.ToString();
                total_sisa_barang = total;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void status_barang(int id_brg)
        {
            //connection 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE antique.barang SET jumlah_stok= '"+total_sisa_barang+"' WHERE id_barang='" + id_brg + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void button_cek_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hitharga();
            check = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check == 0)
            {
                MessageBox.Show("Check terlebih dahulu!");
            }
            else if(check ==1){
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                string Query = "insert into antique.transaksi (id_barang, nama_barang, tipe_barang, asal_barang, harga_barang, berat_barang, jumlah_stok) values('','" + this.label_nb.Text + "','" + this.label_tb.Text + "','" + this.label_ab.Text + "','" + this.label_total_harga.Text + "','" + this.label_bb.Text + "','" + this.label_stok_yg_diambil.Text + "');";

                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
                MySqlDataReader myReader;

                try
                {
                    myConn.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    SpeechSynthesizer reader = new SpeechSynthesizer();
                    reader.Dispose();
                    reader = new SpeechSynthesizer();
                    reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                    MessageBox.Show("Thankyou!");
                    reader.SpeakAsync("Thankyou!");
                    label_stok_yg_diambil.Text = "";
                    label_jumlah_stok_tersisa.Text = "";
                    label_total_harga.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // int data_id_mobil = Convert.ToInt32(id_mobil.Text);
                status_barang(Convert.ToInt32(label_ib.Text));//kirim id_mobil ke fungsi untuk rubah status
                refresh_table();
                check = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dbdataset);
            dv.RowFilter = string.Format("nama_barang LIKE '%{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
