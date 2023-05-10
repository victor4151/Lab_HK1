using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab_HkHello.Utility;


namespace Lab_HkHello
{
    public partial class Frm_student_structFrom : Form
    {
        public Frm_student_structFrom()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        string ShowData = "姓名:0\n國文:0\n英文:0\n數學:0\n";
        string ShowMaxMin = "最高科目成績為數學:0\n最低科目成績為數學:0\n";
        private void btnSave_Click(object sender, EventArgs e)
        {
            Student stu = new Student(txtName.Text, int.Parse(txtChi.Text), int.Parse(txtEng.Text), int.Parse(txtMat.Text));
            //labScore.Text = $"姓名:{stu.Name}\n國文:{stu.Chi}\n英文:{stu.Eng}\n數學:{stu.Mat}\n";
            ShowData = "姓名:"+ stu.Name+"\n" + "國文:" + stu.Chi+"\n"+ 
                "英文:"+stu.Eng+"\n"+"數學:"+ stu.Mat;

            int[] StudentScore = new int[3];
            string[] Subject = new string[3];
            //string end;

            StudentScore[0] = int.Parse(txtChi.Text);
            StudentScore[1] = int.Parse(txtEng.Text);
            StudentScore[2] = int.Parse(txtMat.Text);

            Subject[0] = labChi.Text;
            Subject[1] = labEng.Text;
            Subject[2] = labMat.Text;

            // foreach (int i in StudentScore)
            //{
            
            if (StudentScore.Max() == int.Parse(txtChi.Text) && StudentScore.Min() == int.Parse(txtEng.Text))
            {
                ShowMaxMin = "最高科目成績為:" + Subject[0] + StudentScore[0] + "分\n"+
                    "最低科目成績為:" + Subject[1] + StudentScore[1] + "分\n";
            }
            else if (StudentScore.Max() == int.Parse(txtChi.Text) && StudentScore.Min() == int.Parse(txtMat.Text))
            {
                ShowMaxMin = "最高科目成績為:" + Subject[0] + StudentScore[0] + "分\n"+
                    "最低科目成績為:" + Subject[2] + StudentScore[2] + "分\n";
            }
            else if (StudentScore.Max() == int.Parse(txtEng.Text) && StudentScore.Min() == int.Parse(txtChi.Text))
            {
                ShowMaxMin = "最高科目成績為:" + Subject[1] + StudentScore[1] + "分\n"+
                     "最低科目成績為:" + Subject[0] + StudentScore[0] + "分\n";
            }
            else if (StudentScore.Max() == int.Parse(txtEng.Text) && StudentScore.Min() == int.Parse(txtMat.Text))
            {
                ShowMaxMin = "最高科目成績為:" + Subject[1] + StudentScore[1] + "分\n"+
                    "最低科目成績為:" + Subject[2] + StudentScore[2] + "分\n";
            }
            else if (StudentScore.Max() == int.Parse(txtMat.Text)&&StudentScore.Min() == int.Parse(txtEng.Text))
            {
                ShowMaxMin = "最高科目成績為:" + Subject[2] + StudentScore[2] + "分\n" +
                    "最低科目成績為:" + Subject[1] + StudentScore[1] + "分\n";
            }
            else if (StudentScore.Max() == int.Parse(txtMat.Text)&&StudentScore.Min() == int.Parse(txtChi.Text))
            {
                ShowMaxMin = "最高科目成績為:" + Subject[2] + StudentScore[2] + "分\n"+
                    "最低科目成績為:" + Subject[0] + StudentScore[0] + "分\n";
            }

            //MessageBox.Show("最高科目成績為:" + StudentScore.Max() + "分\n" + "最低科目成績為數學" + StudentScore.Min() + "分\n");
           // MessageBox.Show(ShowMaxMin);
            
            //}

        }
        
        private void btnShowSave_Click(object sender, EventArgs e)
        {
            labScore.Text = ShowData;
        }

        private void btnShowAvg_Click(object sender, EventArgs e)
        {
            //labAvg.Text ="";
            labAvg.Text = ShowMaxMin;
        }

        private void groScore_Enter(object sender, EventArgs e)
        {

        }
    }
}
