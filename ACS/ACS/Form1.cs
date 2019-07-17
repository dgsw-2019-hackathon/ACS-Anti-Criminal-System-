using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ACS
{
    public partial class Form1 : Form
    {
        bool modflag;
        int c=1;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            player.SoundLocation = @"C:\siren.wav";
            serialPort1.PortName = "COM12";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
            serialPort1.DataReceived += SerialPort1_DataReceived;
            now_tb.Text = "안전";
            this.BackColor = Color.LightGray;
        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if(serialPort1.BytesToRead >= 0) {
    
                string[] readarray = new string[] { c.ToString(), DateTime.Now.ToLongTimeString() };

                this.Invoke(new Action(() => main_lv.Items.Add(new ListViewItem(readarray))));
                this.Invoke(new Action(() => this.BackColor = Color.Red));

                player.Play();

                this.Invoke(new Action(() =>
                {
                    c++;
                    now_tb.Text = "위험";
                }));



                Thread.Sleep(5000);
                this.Invoke(new Action(() => now_tb.Text = "안전"));

                player.Stop();

                this.Invoke(new Action(() => this.BackColor = Color.LightGray));
            }
        }

        private void Doublemod_bt_Click(object sender, EventArgs e)
        {
            if(modflag)
            {
                serialPort1.Write("e");
                modflag = false;
            }
            else
            {
                serialPort1.Write("d");
                modflag = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time_lb.Text = DateTime.Now.ToLongTimeString();
        }

        private void Time_lb_Click(object sender, EventArgs e)
        {

        }

        private void Pause_bt_Click(object sender, EventArgs e)
        {
            serialPort1.Write("z");
        }
    }
}
