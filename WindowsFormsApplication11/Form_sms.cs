using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GsmComm.GsmCommunication;
using GsmComm.Interfaces;
using GsmComm.PduConverter;
using GsmComm.Server;

namespace WindowsFormsApplication11
{
    public partial class Form_sms : Form
    {
        public Form_sms()
        {
            InitializeComponent();
        }
        GsmCommMain comm;
        SmsSubmitPdu pdu;
        private void button1_Click(object sender, EventArgs e)
        {

            GsmCommMain comm2 = new GsmCommMain(5, 9600, 300);
            try
            {
                comm2.Open();
                if(comm2.IsConnected() == true)
                {
                    MessageBox.Show("Koneksi berhasil");
                }
                else
                {
                    MessageBox.Show("Tidak bisa membuka port", "error");
                }
                comm2.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(this, "connection error: " + error.Message, "connection setup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listBox1.Items.Add(error.ToString());
                return;
            }
            MessageBox.Show(this, "Koneksi berhasil", "connection setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBox1.Items.Add("Koneksi berhasil dilakukan");
        }

        private void Form_sms_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                comm = new GsmCommMain(int.Parse(textBox1.Text), 115200);
                comm.Open();
                pdu = new SmsSubmitPdu(textBox3.Text, textBox2.Text,"");
                comm.SendMessage(pdu);
                comm.Close();
            }
            catch (Exception error) {
               MessageBox.Show(error.ToString());
            }
        }
    }
}
