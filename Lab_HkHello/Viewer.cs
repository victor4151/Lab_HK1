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
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_Viewer frm  = new Frm_Viewer(); 
            frm.Show();
            frm.BackgroundImage = pictureBox2.BackgroundImage;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_Viewer frm = new Frm_Viewer();
            frm.Show();
            frm.BackgroundImage = pictureBox1.BackgroundImage;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Frm_Viewer frm = new Frm_Viewer();
            frm.Show();
            frm.BackgroundImage = pictureBox4.BackgroundImage;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Frm_Viewer frm = new Frm_Viewer();
            frm.Show();
            frm.BackgroundImage = pictureBox3.BackgroundImage;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Frm_Viewer frm = new Frm_Viewer();
            frm.Show();
            frm.BackgroundImage = pictureBox8.BackgroundImage;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Frm_Viewer frm = new Frm_Viewer();
            frm.Show();
            frm.BackgroundImage = pictureBox7.BackgroundImage;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Frm_Viewer frm = new Frm_Viewer();
            frm.Show();
            frm.BackgroundImage = pictureBox5.BackgroundImage;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Frm_Viewer frm = new Frm_Viewer();
            frm.Show();
            frm.BackgroundImage = pictureBox6.BackgroundImage;
        }
    }
}
