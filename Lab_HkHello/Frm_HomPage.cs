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
    public partial class Frm_HomPage : Form
    {
        public Frm_HomPage()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            Hello frm /* 將Frm_M02_HelloForm存入frm */ = new Hello(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Principal frm /* 將Frm_M02_HelloForm存入frm */ = new Principal(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            Frm_Pos frm /* 將Frm_M02_HelloForm存入frm */ = new Frm_Pos(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnStudentStruc_Click(object sender, EventArgs e)
        {
            Frm_student_structFrom frm /* 將Frm_M02_HelloForm存入frm */ = new Frm_student_structFrom(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            Frm_Method frm /* 將Frm_M02_HelloForm存入frm */ = new Frm_Method(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnMyClac_Click(object sender, EventArgs e)
        {
            Frm_MyClac frm /* 將Frm_M02_HelloForm存入frm */ = new Frm_MyClac(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnOXGame_Click(object sender, EventArgs e)
        {
            Frm_xoGame frm /* 將Frm_M02_HelloForm存入frm */ = new Frm_xoGame(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            Frm_Notepad frm /* 將Frm_M02_HelloForm存入frm */ = new Frm_Notepad(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            Frm_ScreenSaver frm /* 將Frm_M02_HelloForm存入frm */ = new Frm_ScreenSaver(); //建立實體Frm_M02_HelloForm
           // frm.TopLevel = false;
           // splitContainer2.Panel2.Controls.Clear();
           // splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Frm_Alarm frm /* 將Frm_M02_HelloForm存入frm */ = new Frm_Alarm(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnDrawpaint_Click(object sender, EventArgs e)
        {
            Frm_DrawPaint frm /* 將Frm_M02_HelloForm存入frm */ = new Frm_DrawPaint(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Frm_Guess frm /* 將Frm_M02_HelloForm存入frm */ = new Frm_Guess(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Viewer frm /* 將Frm_M02_HelloForm存入frm */ = new Viewer(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void btnStudentGrade_Click(object sender, EventArgs e)
        {
            Frm_StudentGrade frm /* 將Frm_M02_HelloForm存入frm */ = new Frm_StudentGrade(); //建立實體Frm_M02_HelloForm
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }
    }
}
