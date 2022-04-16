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


/*

    secara overal : Text to spech, GPS, SMS gateway, tekan enter, framework bunifu untuk button, sedikit tambahan template.
Progammed by Prince Imanuel , 26 April 2018
-Features: Text to speech, Template, Capslock, Try catch jika salah password atau belum menyalakan MySql, show password dan hide password
di tekan enter..

    need : 1 form utk admin,
    sms gateway. untuk user ke penjual. (download library)
    dan admin ke penjual.
    laporan

*/


namespace DOPFNS_RealWorld
{
    public partial class antique_Login : Form
    {
        public antique_Login()
        {
            InitializeComponent();
        }
        string lvl, username, id;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer reader = new SpeechSynthesizer();
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            reader.SpeakAsync("Welcome to Antique, Shop");
           // textBox_kata_sandi.PasswordChar = '\u25CF';

        }

        private void textBox_kata_sandi_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
            }
            this.AcceptButton = this.button_log_in;
            // this .CancelButton = this.nama_button;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                SpeechSynthesizer reader = new SpeechSynthesizer();
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                reader.SpeakAsync("Show password");
                textBox_kata_sandi.UseSystemPasswordChar = false;
            }
            else
            {
                SpeechSynthesizer reader = new SpeechSynthesizer();
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                reader.SpeakAsync("Hide password");
                textBox_kata_sandi.UseSystemPasswordChar = true;
            }
        }

        private void textBox_nama_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = this.button_log_in;
            // this .CancelButton = this.nama_button;
        }

        private void label_lupa_pass_daftar_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer reader = new SpeechSynthesizer();
            reader.Dispose();
            reader = new SpeechSynthesizer();
            reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
            reader.SpeakAsync("Create user and Top up!");
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }

        private void button_log_in_Click(object sender, EventArgs e)
        {
            try
            {
                //connection 
                string myConnection = "datasource=localhost;port=3306;username=root;password=";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select nickname, password, role from antique.user where nickname= '" + this.textBox_nama.Text + "' and password='" + this.textBox_kata_sandi.Text + "' ;", myConn);
                MySqlDataReader myReader;
                myConn.Open(); // start connection
                myReader = SelectCommand.ExecuteReader();
                int count = 0;

                while (myReader.Read())
                {
                    count = count + 1;
                    lvl = myReader.GetString("role").ToString();
                    id = myReader.GetString(0);
                }
                if (count == 1)
                {
                    if (lvl == "admin")
                    {
                        username = textBox_nama.Text;
                        SpeechSynthesizer reader = new SpeechSynthesizer();
                        reader.Dispose();
                        reader = new SpeechSynthesizer();
                        reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                        reader.SpeakAsync("Login as Admin Success!");
                        reader.Dispose();
                        reader = new SpeechSynthesizer();
                        reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                        reader.SpeakAsync("Welcome " + textBox_nama.Text);
                        WindowsFormsApplication11.Form_Admin a21 = new WindowsFormsApplication11.Form_Admin();
                        this.Hide();
                        a21.Show();

                    }
                    if (lvl == "penjual")
                    {
                        username = textBox_nama.Text;
                        SpeechSynthesizer reader = new SpeechSynthesizer();
                        reader.Dispose();
                        reader = new SpeechSynthesizer();
                        reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                        reader.SpeakAsync("Login as Penjual Success!");
                        reader.Dispose();
                        reader = new SpeechSynthesizer();
                        reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                        reader.SpeakAsync("Welcome " + textBox_nama.Text);
                        WindowsFormsApplication11.AntiqueShop asf = new WindowsFormsApplication11.AntiqueShop(username);
                        this.Hide();
                        asf.Show();
                    }
                    if (lvl == "pembeli")
                    {
                        username = textBox_nama.Text;
                        SpeechSynthesizer reader = new SpeechSynthesizer();
                        reader.Dispose();
                        reader = new SpeechSynthesizer();
                        reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                        reader.SpeakAsync("Login as Pembeli Success!");
                        reader.Dispose();
                        reader = new SpeechSynthesizer();
                        reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                        reader.SpeakAsync("Welcome " + textBox_nama.Text);
                        WindowsFormsApplication11.AntiqueShop_pembeli asf = new WindowsFormsApplication11.AntiqueShop_pembeli(username);
                        this.Hide();
                        asf.Show();
                    }
                }
                else
                {
                    SpeechSynthesizer reader = new SpeechSynthesizer();
                    reader.Dispose();
                    reader = new SpeechSynthesizer();
                    reader.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                    reader.SpeakAsync("Wrong username or password, Please Enter again!!");
                }
                myConn.Close();
            }
            catch (Exception xe) {
            } 
        }
    }
}

