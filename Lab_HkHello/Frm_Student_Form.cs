using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab_HkHello.Utility;
using static Lab_HkHello.Utility.Student;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_HkHello
{
    public partial class Frm_Student_Form : Form
    {
        public Frm_Student_Form()
        {
            InitializeComponent();
        }
        //int[] StudentData = new int[100];
        //int[] Studertscore = new int[100];
        int[] StudentScore = new int[3];
        int studenttotal, studentAvg;
        private void btncreate_Click(object sender, EventArgs e)
        {
            //防呆設計預防空值
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("請輸入姓名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtChi.Text))
            {
                 MessageBox.Show("請輸入國文成績","警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
            }
            else if (string.IsNullOrEmpty(txtEng.Text))
            {
                MessageBox.Show("請輸入英文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtMat.Text))
            {
                MessageBox.Show("請輸入數學成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           //使用結構陣列放在Utility

             Student stu = new Student(txtName.Text, int.Parse(txtChi.Text)
                , int.Parse(txtEng.Text), int.Parse(txtMat.Text));
            //顯示方式
            //labShow.Text += "\n" + "姓名:" + emp.Name + "年齡" + emp.Age ;

            //計算總分平均最高最低

            studenttotal = int.Parse(txtChi.Text) + int.Parse(txtEng.Text) + int.Parse(txtMat.Text);
            studentAvg = studenttotal / 3;
            StudentScore[0] = int.Parse(txtChi.Text);
            StudentScore[1] = int.Parse(txtEng.Text);
            StudentScore[2] = int.Parse(txtMat.Text);

            //for (int i = 0; i < 4; i++)
            //{
                
           // }

            labData.Text += $"\n姓名{txtName.Text}國文{StudentScore[0]}英文{StudentScore[1]}數學{StudentScore[2]}總分" +
                $"{studenttotal}平均{studentAvg}最高{StudentScore.Max()}最低{StudentScore.Min()}";
            MessageBox.Show("總共"+ studenttotal + "高分"+StudentScore.Max());
            


            UserRode Role = UserRode.Admin; //抓取Utility中public enum UserRode存取資料
            {
                //當有資料儲存後才會開啟此欄位
                if (Role == UserRode.Admin)
                {
                    btnTotsl.Enabled = true;
                }
                else
                    btnTotsl.Enabled = false;
            }
            //int a, avg, total;
            //a = 
            //for(int i=0; i <a;i++)

            //StudentData[1] = int.Parse(txtChi.Text);
            //StudentData[2] = int.Parse(txtEng.Text);
            //StudentData[3] = int.Parse(txtMat.Text);
            // MessageBox.Show();

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //隨機亂數
            int[] randomArray = new int[3];
            Random rnd = new Random();  //產生亂數初始值
            for (int i = 0; i < 3; i++)
            {
                randomArray[i] = rnd.Next(1, 100);   //亂數產生，亂數產生的範圍是0~100

                for (int j = 0; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i])    //檢查是否與前面產生的數值發生重複，如果有就重新產生
                    {
                        j = 0;  //如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)
                        randomArray[i] = rnd.Next(1, 100);   //重新產生，存回陣列，亂數產生的範圍是0~100
                    }
                }
                StudentScore[0] = randomArray[0];
                StudentScore[1] = randomArray[1];
                StudentScore[2] = randomArray[2];
                //labData.Text = "";

            }
            labData.Text += $"\n姓名{txtName.Text}國文{StudentScore[0]}英文{StudentScore[1]}數學{StudentScore[2]}";
        }

        private void btnTotsl_Click(object sender, EventArgs e)
        {

        }

        private void btnRandom20_Click(object sender, EventArgs e)
        {
            //隨機亂數20筆
            int[] randomArray = new int[3];
            Random rnd = new Random();  //產生亂數初始值
           // for (int k=0)
            for (int i = 0; i < 3; i++)
            {
                randomArray[i] = rnd.Next(1, 100);   //亂數產生，亂數產生的範圍是0~100

                for (int j = 0; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i])    //檢查是否與前面產生的數值發生重複，如果有就重新產生
                    {
                        j = 0;  //如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)
                        randomArray[i] = rnd.Next(1, 100);   //重新產生，存回陣列，亂數產生的範圍是0~100
                    }
                }
                StudentScore[0] = randomArray[0];
                StudentScore[1] = randomArray[1];
                StudentScore[2] = randomArray[2];
                //labData.Text = "";

            }
            labData.Text += $"\n姓名{txtName.Text}國文{StudentScore[0]}英文{StudentScore[1]}數學{StudentScore[2]}";
        }
    }
  
}
