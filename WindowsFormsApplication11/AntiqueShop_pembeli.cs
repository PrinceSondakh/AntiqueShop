using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication11
{
    //Progammed by Prince Imanuel , 1 May 2018
    public partial class AntiqueShop_pembeli : Form
    {
        public AntiqueShop_pembeli()
        {
            InitializeComponent();
        }
        public AntiqueShop_pembeli(string username)
            : this()
        {
            label_user.Text = "Welcome, " + username;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_waktu.Text = DateTime.Now.ToString();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //untuk membersihkan form yg tampil di panel agar tidak saling menimpa
            panel2.Controls.Clear();
            Ujian___Transaksi_rental_mobil.Transaksi a = new Ujian___Transaksi_rental_mobil.Transaksi();
            a.TopLevel = false;
            //syntax utk menampilkan form di dalam panel
            panel2.Controls.Add(a);
            a.Show();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            DOPFNS_RealWorld.antique_Login a = new DOPFNS_RealWorld.antique_Login();
            a.Show();
            this.Close();
        }
        private void uangchek()
        {


        }
        private void AntiqueShop_pembeli_Load(object sender, EventArgs e)
        {
            this.ControlBox = true;
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
            reader.SpeakAsync("BUY");
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
            reader.SpeakAsync("LOGOUT");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
