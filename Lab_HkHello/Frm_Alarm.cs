using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_HkHello
{
    public partial class Frm_Alarm : Form
    {
        public Frm_Alarm()
        {
            InitializeComponent();
        }
        string Date,timeex;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeex = txtTime.Text;
            Date = DateTime.Now.ToString("hh:mm:ss");
            labtimeNow.Text = Date;

            if (Date == timeex && flagCK)
            {
                timeExplode.Enabled = true;

                groSelTim.BackColor = Color.Black;
                groSelTim.ForeColor = Color.Pink;
               // SoundPlayer player = new SoundPlayer();
               // player.SoundLocation = @"D:\Lab_Hk\Alarm Meme Sound Effect警報器音效 (online-audio-converter.com)";
               // player.Load(); //同步載入聲音
              //  player.Play(); //啟用新執行緒播放
            }

        }

        private void Frm_Alarm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool flagCK = false;
        bool isTimeCheck(string ID)
        {
            return Regex.IsMatch(ID, @"^[0-2]{1}[0-9]{1}:[0-9]{2}:[0-9]{2}$");
        }
        private void checkAlarm_CheckedChanged(object sender, EventArgs e)
        {
            flagCK = !flagCK;
            if (checkAlarm.Checked)
            {
                labtimeNow.Text = "";
                groSelTim.BackColor = SystemColors.Control;
                groSelTim.ForeColor = Color.Black;
            }
            
            
             labtimecheck.Text = isTimeCheck(txtTime.Text) ? "格式正確" : "格式錯誤";

            
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groSelTim_Enter(object sender, EventArgs e)
        {

        }
        bool flagPW = true;
        private void timeExplode_Tick(object sender, EventArgs e)
        {
            if (flagPW)
            {
                groSelTim.BackColor = Color.Black;
                groSelTim.ForeColor = Color.Pink;
            }
            else
            {
                groSelTim.BackColor = Color.Pink;
                groSelTim.ForeColor = Color.Black;
            }
            flagPW = !flagPW;
        }
    }
}
