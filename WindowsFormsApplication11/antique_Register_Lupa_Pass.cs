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
/*
Progammed by Prince Imanuel , 28 April 2018
-Features: Text to speech, Template, Can forget password.

    -Radio button = pembeli, penjual
*/
namespace DOPFNS_RealWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_rh_check.Text = "";
            this.Close();
            antique_Login a = new antique_Login();
            a.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_ks.Text = "";
        }
        int a = 0;
        private void radiocheckaje()
        {
            if(radioButton_pembeli.Checked == true)
            {
                textBox_Role.Text = "pembeli";
            }
            else if (radioButton_penjual.Checked == true)
            {
                textBox_Role.Text = "penjual";
            }

        }
        private void button_register_Click(object sender, EventArgs e)
        {
            radiocheckaje();
            string myConnection = "datasource=localhost;port=3306;username=root;password=";
     //       INSERT INTO `user` (`id_user`, `nickname`, `phone_number`, `password`, `role`, `money`) VALUES(NULL, 'aaa', '123', '123', 'penjual', '0');
            string Query = "INSERT INTO `antique`.`user` (`id_user`, `nickname`, `phone_number`, `password`, `role`, `money`) values(NULL,'" + this.textBox_rh_n.Text + "','" + this.textBox_rh_nt.Text + "','" + this.textBox_rh_ks.Text + "','" + this.textBox_Role.Text + "','0');";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = cmdDatabase.ExecuteReader();
                textBox_rh_ks.Text = "";
                textBox_rh_n.Text = "";
                textBox_rh_nt.Text = "";
                radioButton_pembeli.Checked = false;
                radioButton_penjual.Checked= false;
                label_rh_check.Text = "Inserted";
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_click_on_me_Click(object sender, EventArgs e)
        {
            if (textBox_fp_nka.Text == "abc")//100k
            {
                int a = 100000;
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                string Query = "UPDATE antique.user SET money=money + '100000' where nickname='" + this.textBox_fp_n.Text + "';";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, myConn);
                MySqlDataReader myReader;

                try
                {
                    myConn.Open();
                    myReader = cmdDatabase.ExecuteReader();
                    label_ks.Text = "Telah top up 100000 rupiah!";
                    textBox_fp_nka.Text = "";
                    textBox_fp_n.Text = "";
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (textBox_fp_nka.Text == "abcd")//1 000 000 000
            {
                int a2 = 100000;
                string myConnection2 = "datasource=localhost;port=3306;username=root;password=";
                string Query2 = "UPDATE antique.user SET money=money + '1000000000' where nickname='" + this.textBox_fp_n.Text + "';";
                MySqlConnection myConn2 = new MySqlConnection(myConnection2);
                MySqlCommand cmdDatabase2 = new MySqlCommand(Query2, myConn2);
                MySqlDataReader myReader2;

                try
                {
                    myConn2.Open();
                    myReader2 = cmdDatabase2.ExecuteReader();
                    label_ks.Text = "Telah top up 1 MILYAR rupiah!";
                    textBox_fp_nka.Text = "";
                    textBox_fp_n.Text = "";
                    while (myReader2.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (textBox_fp_nka.Text == "" && textBox_fp_n.Text == "") {
                MessageBox.Show("Anda tidak input apa-apa");
            }
            else
            {
                MessageBox.Show("Salah input");
            }
        }
    
    }
}
