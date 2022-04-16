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

/*

    Made and Progammed by Prince Imanuel , 1 May 2018
    Features: auto load, blue+black colours template
*/


namespace project
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        DataTable dbdataset;
        MySqlCommand command;
        MySqlCommand command2;
        private void Customer_Load(object sender, EventArgs e)
        {
            label_noimg1.Text = "NO IMAGE";
            label_noimg2.Text = "NO IMAGE";
            load_aja();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button_loadtable_Click(object sender, EventArgs e)
        {
            //load table 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM antique.barang;", myConn);
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
            //Save
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "insert into antique.barang (id_barang, nama_barang, tipe_barang, asal_barang, harga_barang, berat_barang, jumlah_stok, tanggal_pembuatan_barang) values('','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox13.Text + "','" + this.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Inserted");

                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox13.Text = "";
              //  textBox7.Text = ""; date simpan
                
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            //edit 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE antique.barang SET nama_barang= '" + this.textBox15.Text + "',tipe_barang='" + this.textBox14.Text + "',asal_barang='" + this.textBox12.Text + "',harga_barang='" + this.textBox11.Text + "',berat_barang='" + this.textBox10.Text + "',jumlah_stok='" + this.textBox9.Text + "',tanggal_pembuatan_barang='" + this.textBox8.Text + "' WHERE id_barang= '" + this.textBox1.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Updated");
                textBox1.Text = "";
                textBox15.Text = "";
                textBox14.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";
                textBox10.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            //Delete
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = " DELETE FROM antique.barang  WHERE id_barang = '" + textBox1.Text + "'; ";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Data Berhasil Di Hapus");
                textBox1.Text = "";
                textBox15.Text = "";
                textBox14.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";
                textBox10.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dbdataset);
            dv.RowFilter = string.Format("nama_barang LIKE '%{0}%'", textBox_search.Text);
            dataGridView1.DataSource = dv;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_log_in_Click(object sender, EventArgs e)
        {
            load_aja();
        }

        private void load_aja() {
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

        private void button2_Click(object sender, EventArgs e)
        {
            

            MemoryStream ms = new MemoryStream();
            try { pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat); } catch (Exception a) { }
            byte[] img = ms.ToArray();
            //Save
            MySqlConnection myConn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            string Query = "insert into antique.barang (id_barang, nama_barang, tipe_barang, asal_barang, harga_barang, berat_barang, jumlah_stok, tanggal_pembuatan_barang,nama_tempat,nama_kota,nama_provinsi,no_telp_email,gambar) values('','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox13.Text + "','" + this.dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "','" + this.textBox7.Text+ "','" + this.textBox16.Text + "','" + this.textBox17.Text + "','" + this.textBox18.Text + "',@img);";
            myConn.Open();
            command = new MySqlCommand(Query, myConn);
            command.Parameters.Add("@img", MySqlDbType.Blob);
            command.Parameters["@img"].Value = img;
            MySqlDataReader myReader;
            try
            {
                
                myReader = command.ExecuteReader();
                MessageBox.Show("Inserted");
                load_aja();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox13.Text = "";
                textBox7.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox18.Text = "";
                label_noimg1.Text = "NO IMAGE";
                pictureBox1.Image = null;

                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //edit 
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = "UPDATE antique.barang SET nama_barang= '" + this.textBox15.Text + "',tipe_barang='" + this.textBox14.Text + "',asal_barang='" + this.textBox12.Text + "',harga_barang='" + this.textBox11.Text + "',berat_barang='" + this.textBox10.Text + "',jumlah_stok='" + this.textBox9.Text + "',nama_tempat='" + this.textBox19.Text + "',nama_kota='" + this.textBox20.Text + "',nama_provinsi='" + this.textBox21.Text + "',no_telp_email='" + this.textBox22.Text + "' WHERE id_barang= '" + this.textBox1.Text + "';";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Updated");
                load_aja();
                pictureBox2.Image = null;
                textBox1.Text = "";
                textBox15.Text = "";
                textBox14.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";
                textBox10.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox19.Text = "";
                textBox20.Text = "";
                textBox21.Text = "";
                textBox22.Text = "";

                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //Delete
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            string Query = " DELETE FROM antique.barang  WHERE id_barang = '" + textBox1.Text + "'; ";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Data Berhasil Di Hapus");
                load_aja();
                pictureBox2.Image = null;
                textBox1.Text = "";
                textBox15.Text = "";
                textBox14.Text = "";
                textBox12.Text = "";
                textBox11.Text = "";
                textBox10.Text = "";
                textBox9.Text = "";
                textBox8.Text = "";
                textBox19.Text = "";
                textBox20.Text = "";
                textBox21.Text = "";
                textBox22.Text = "";
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


        }
        MySqlDataAdapter da;





        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox2.Image = null;
            label_noimg2.Text = "NO IMAGE";
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells["id_barang"].Value.ToString();
            textBox15.Text = row.Cells["nama_barang"].Value.ToString();
            textBox14.Text = row.Cells["tipe_barang"].Value.ToString();
            textBox12.Text = row.Cells["asal_barang"].Value.ToString();
            textBox11.Text = row.Cells["harga_barang"].Value.ToString();
            textBox10.Text = row.Cells["berat_barang"].Value.ToString();
            textBox9.Text = row.Cells["jumlah_stok"].Value.ToString();
            textBox8.Text = row.Cells["tanggal_pembuatan_barang"].Value.ToString();
            textBox19.Text = row.Cells["nama_tempat"].Value.ToString();
            textBox20.Text = row.Cells["nama_kota"].Value.ToString();
            textBox21.Text = row.Cells["nama_provinsi"].Value.ToString();
            textBox22.Text = row.Cells["no_telp_email"].Value.ToString();
            f4w();
        }
        /*
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells["id_barang"].Value.ToString();
            textBox15.Text = row.Cells["nama_barang"].Value.ToString();
            textBox14.Text = row.Cells["tipe_barang"].Value.ToString();
            textBox12.Text = row.Cells["asal_barang"].Value.ToString();
            textBox11.Text = row.Cells["harga_barang"].Value.ToString();
            textBox10.Text = row.Cells["berat_barang"].Value.ToString();
            textBox9.Text = row.Cells["jumlah_stok"].Value.ToString();
            textBox8.Text = row.Cells["tanggal_pembuatan_barang"].Value.ToString();
            textBox19.Text = row.Cells["nama_tempat"].Value.ToString();
            textBox20.Text = row.Cells["nama_kota"].Value.ToString();
            textBox21.Text = row.Cells["nama_provinsi"].Value.ToString();
            textBox22.Text = row.Cells["no_telp_email"].Value.ToString();
            f4w();
            */

           /*
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String selectQuery = "SELECT id_barang, nama_barang, tipe_barang, asal_barang, harga_barang, berat_barang, jumlah_stok, tanggal_pembuatan_barang,nama_tempat,nama_kota,nama_provinsi,no_telp_email FROM antique.barang WHERE id_barang = '" + textBox1.Text + "'";
            command2 = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command2);


            da.Fill(dbdataset);


            //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = dbdataset.Rows[0][0].ToString();
            textBox15.Text = dbdataset.Rows[0][1].ToString();
            textBox14.Text = dbdataset.Rows[0][2].ToString();
            textBox12.Text = dbdataset.Rows[0][3].ToString();
            textBox11.Text = dbdataset.Rows[0][4].ToString();
            textBox10.Text = dbdataset.Rows[0][5].ToString();
            textBox9.Text = dbdataset.Rows[0][6].ToString();
            textBox8.Text = dbdataset.Rows[0][7].ToString();
            textBox19.Text = dbdataset.Rows[0][8].ToString();
            textBox20.Text = dbdataset.Rows[0][9].ToString();
            textBox21.Text = dbdataset.Rows[0][10].ToString();
            textBox22.Text = dbdataset.Rows[0][12].ToString();


            byte[] img = (byte[])dbdataset.Rows[0][13];

            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            da.Dispose();
         */
        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Pilih gambar cuk(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                label_noimg1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void f4w()
        {

            string myConnection = "datasource=localhost;port=3306;username=root;password=";
            MySqlConnection connection = new MySqlConnection(myConnection);

            String selectQuery = "SELECT * FROM antique.barang WHERE id_barang = '" + textBox1.Text + "'";
            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            byte[] img = (byte[])table.Rows[0][12];
            try
            {
                MemoryStream ms = new MemoryStream(img);
                pictureBox2.Image = Image.FromStream(ms);
                label_noimg2.Text = "";
                da.Dispose();
            }
            catch (Exception a) {
               
            }

        }

    }
}
