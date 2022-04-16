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
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
/*

    90% Progammed and Made by Prince Imanuel , 1 May 2018
    10% by Jad (for bunifu button)
    Secara keseluruhan tidak memakai template.
    Hanya sedikit tambahan tombol button yang pakai bunifu.

*/


namespace WindowsFormsApplication11
{
    public partial class AntiqueShop : Form
    {
        public AntiqueShop()
        {
            InitializeComponent();
        }
        public AntiqueShop(string username)
            : this()
        {
            label_user.Text = "Welcome, " + username;
        }
        DataTable dbdataset;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DOPFNS_RealWorld.antique_Login a = new DOPFNS_RealWorld.antique_Login();
            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=";    //initial database
                MySqlConnection myConn = new MySqlConnection(myConnection); //load mysqllibrary conection
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();    //create data adapter
                myDataAdapter.SelectCommand = new MySqlCommand("select * antique.barang;", myConn);// sql syntax
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter); //build data adapter

                myConn.Open();// start connection
                DataSet ds = new DataSet();
                MessageBox.Show("Conected");
                myConn.Close();// end connection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AntiqueShop_Load(object sender, EventArgs e)
        {


        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton_Register_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            //untuk membersihkan form yg tampil di panel agar tidak saling menimpa
            panel2.Controls.Clear();
            Form_About a = new Form_About();
            a.TopLevel = false;
            //syntax utk menampilkan form di dalam panel
            panel2.Controls.Add(a);
            a.Show();
        }
        private void HideForms()
        {
            int frmCount = this.MdiChildren.Count<Form>();
            if (frmCount > 0)
            {
                for (int i = 0; i < frmCount; i++)
                {
                    this.MdiChildren[i].Hide();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_waktu.Text = DateTime.Now.ToString();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            //untuk membersihkan form yg tampil di panel agar tidak saling menimpa
            panel2.Controls.Clear();
            antique_gps a = new antique_gps();
            a.TopLevel = false;
            //syntax utk menampilkan form di dalam panel
            panel2.Controls.Add(a);
            a.Show();
        }

        private void panel_home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            DOPFNS_RealWorld.antique_Login a = new DOPFNS_RealWorld.antique_Login();
            a.Show();
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            //untuk membersihkan form yg tampil di panel agar tidak saling menimpa
            panel2.Controls.Clear();
            project.Customer a = new project.Customer();
            a.TopLevel = false;
            //syntax utk menampilkan form di dalam panel
            panel2.Controls.Add(a);
            a.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            //untuk membersihkan form yg tampil di panel agar tidak saling menimpa
            panel2.Controls.Clear();
            antique_report a = new antique_report();
            a.TopLevel = false;
            //syntax utk menampilkan form di dalam panel
            panel2.Controls.Add(a);
            a.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_MouseEnter(object sender, EventArgs e)
        {
            SpeechSynthesizer reader = new SpeechSynthesizer();
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            reader.SpeakAsync("HOME");
        }

        private void bunifuImageButton1_MouseEnter(object sender, EventArgs e)
        {
            SpeechSynthesizer reader = new SpeechSynthesizer();
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            reader.SpeakAsync("SELL");
        }

        private void bunifuImageButton3_MouseEnter(object sender, EventArgs e)
        {
            SpeechSynthesizer reader = new SpeechSynthesizer();
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            reader.SpeakAsync("REPORT");
        }

        private void bunifuImageButton4_MouseEnter(object sender, EventArgs e)
        {
            SpeechSynthesizer reader = new SpeechSynthesizer();
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            reader.SpeakAsync("GLOBAL POSITIONING SYSTEM");
        }

        private void bunifuImageButton6_MouseEnter(object sender, EventArgs e)
        {
            SpeechSynthesizer reader = new SpeechSynthesizer();
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            reader.SpeakAsync("GOODBYE MASTER");
        }
    }
}
