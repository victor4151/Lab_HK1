using System;
using System.Collections;
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

namespace Lab_HkHello
{
    public partial class Frm_StudentGrade : Form
    {
        public Frm_StudentGrade()
        {
            InitializeComponent();
        }
        ArrayList StudentSco = new ArrayList();
        
        //int[] Score = new int[3];
        Student sco;
        int studenttotal, studentAvg;
        
        private void btnClean_Click(object sender, EventArgs e)
        {
            labData.Text = "";
            StudentSco.Clear();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int k=0;
            int[] randomArray = new int[3];
            Random rnd = new Random();  //產生亂數初始值
            //for (int i = 0; i < 3; i++)
           // {
                randomArray[k] = rnd.Next(0, 100);   //亂數產生，亂數產生的範圍是0~100
            for (int i = 0; i < StudentSco.Count; i++)
            {
                int[] Score = new int[3];
                Score[0] = ((Student)StudentSco[i]).Chi;
                Score[1] = ((Student)StudentSco[i]).Eng;
                Score[2] = ((Student)StudentSco[i]).Mat;
                studenttotal = ((Student)StudentSco[i]).Chi + ((Student)StudentSco[i]).Eng + ((Student)StudentSco[i]).Mat;
                studentAvg = studenttotal / 3;
                labDataShow.Text += $"\n姓名:{((Student)StudentSco[i]).Name},國文{((Student)StudentSco[i]).Chi}" +
                $",英文{((Student)StudentSco[i]).Eng},數學{((Student)StudentSco[i]).Mat}" +
                $"總分{studenttotal},平均{studentAvg},最低{Score.Min()},最高{Score.Max()}";
            }

            // MessageBox.Show("@@"+randomArray[i]);
            //}
            //StudentSco.Add(sco);
            // ShowProduct();
        }

        private void Frm_StudentGrade_Load(object sender, EventArgs e)
        {

        }

        private void btnTotsl_Click(object sender, EventArgs e)
        {
            
            int chi=0,eng=0,mat=0,i=0;
            int Chimax= 0, Emgmax=0, Matmax=0, Chimin=0, Emgmin = 0, Matmin = 0;



            if (((Student)StudentSco[i]).Chi > Chimax)
                for (i = 0; i < StudentSco.Count; i++)
                {
                    if (((Student)StudentSco[i]).Chi > Chimax)
                    {
                        Chimax = ((Student)StudentSco[i]).Chi;
                    }
                 }
     
                for (i = 0; i < StudentSco.Count; i++)
                {
                    if (((Student)StudentSco[i]).Chi < Chimin)
                    {
                        Chimin = ((Student)StudentSco[i]).Chi;
                            MessageBox.Show($"{Chimin}");
                    }
                }

            for ( i = 0; i < StudentSco.Count; i++)
            {
                decimal AvgC, AvgE, AvgM;
               chi += ((Student)StudentSco[i]).Chi;
               eng += ((Student)StudentSco[i]).Eng;
               mat += ((Student)StudentSco[i]).Mat;
              // studenttotal = chi + eng + mat;

               AvgC = chi / StudentSco.Count;
               AvgE= eng / StudentSco.Count;
               AvgM= mat / StudentSco.Count;
                
               labAvg.Text = "";
               labAvg.Text += $"\n總分:{chi} {eng} {mat}\n平均{AvgC} {AvgE} {AvgM}\n" +
                    $"最高";
                //MessageBox.Show("@@" +chi);
            }
           
            //int sum = StudentSco.Sum();


        }

        private void labData_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

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
                MessageBox.Show("請輸入國文成績", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
///////////////////////////////////////////////////////////////////////////////////////////
            sco.Name= txtName.Text;
            sco.Chi=int.Parse(txtChi.Text);
            sco.Eng=int.Parse(txtEng.Text); 
            sco.Mat=int.Parse(txtMat.Text);

            labData.Text = "姓名 國文 英文 數學 總分 平均 最低 最高";
            StudentSco.Add(sco);
            ShowProduct();

            // MessageBox.Show("totla" + studenttotal + "\navg" + studentAvg);
            void ShowProduct()//使用方法將特定公式存入並計算
            {
                labDataShow.Text = "";

               //for迴圈
                for (int i = 0; i < StudentSco.Count; i++)
                {
                  int[] Score = new int[3];
                   Score[0] = ((Student)StudentSco[i]).Chi;
                   Score[1] = ((Student)StudentSco[i]).Eng;
                   Score[2] = ((Student)StudentSco[i]).Mat;
                   studenttotal = ((Student)StudentSco[i]).Chi + ((Student)StudentSco[i]).Eng + ((Student)StudentSco[i]).Mat;
                   studentAvg = studenttotal / 3;
                   labDataShow.Text += $"\n姓名:{((Student)StudentSco[i]).Name},國文{((Student)StudentSco[i]).Chi}" +
                   $",英文{((Student)StudentSco[i]).Eng},數學{((Student)StudentSco[i]).Mat}" +
                   $"總分{studenttotal},平均{studentAvg},最低{Score.Min()},最高{Score.Max()}";
                }

        }

            /////////////////////////////////////////////////////////////////////////////////////////
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
///////////////////////////////////////////////////////////////////////
        }
    }
}
