using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_HkHello
{
    public partial class Frm_ScreenSaver : Form
    {
        public Frm_ScreenSaver()
        {
            InitializeComponent();
        }

        private void Frm_ScreenSaver_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Frm_ScreenSaver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int sizeL = 10;
        int sizeT = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {

             foreach (Control item in Controls)
            {
                item.Top += sizeT;
                item.Left += sizeL;
                if ((btnScreen.Location.X + btnScreen.Width) > this.Width || btnScreen.Location.X < 0)
                    sizeL *= (-1);
                if ((btnScreen.Location.Y + btnScreen.Height) > this.Height || btnScreen.Location.Y < 0)
                    sizeT *= (-1);
            }
 
        }

    }
}
