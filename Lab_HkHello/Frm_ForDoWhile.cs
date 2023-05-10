using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_HkHello
{
    public partial class Frm_Method : Form
    {
        public Frm_Method()
        {
            InitializeComponent();
        }
        private void btnloneName_Click(object sender, EventArgs e)
        {
            //string[] arr = {"mother張","emma迪克蕭",""};
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        //int[] arr = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        private void btnParity_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            //int sum = arr.Sum();
            int count1=0, count2 = 0, odd,even;
            odd = even = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {   
                    count1++;//存取偶數數量
                    even = arr[i];//存取偶數最大值
                }               
                else { 
                    count2++;//存取奇數數量
                    odd = arr[i];//存取奇數最大值
                }
            }
            labResult.Text = $"int 陣列{{1,5, 6, 8, 7, 97, 54, 887, 65, 578 }}\n" +
                $"奇數有{count2}\n偶數有{count1}";      
        }
        private void btnCheckParity_Click(object sender, EventArgs e)
        {
            int num;
            bool isNum = int.TryParse(txtNumber.Text, out num);
            if (isNum)//判斷是否為空值
            {
                int Parse = int.Parse(txtNumber.Text);
                string result = Parsecalculate(Parse);
                labResult.Text = result;
            }
            else
            {
                MessageBox.Show("請輸入數字", "警告",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumber.Text = "";
                txtNumber.Focus();
            }
        }
        string Parsecalculate(int Parse)//計算奇偶數的方法
        {
            int culate = int.Parse(txtNumber.Text);
            if (culate % 2 == 0)//取餘數0為偶
            {
                return $"數入的數字{Parse} 為偶數";
            }
            else return $"數入的數字{Parse} 為奇數";
            // public void int[] arr = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果";
        }
        private void btnSwap_Click(object sender, EventArgs e)//Swap數值交換
        {
            int a = 100, b = 200,c,d;
            c=a; d=b;
            GenericSwap<int>(ref a, ref b);
            labResult.Text=($"換位後n1: {c} , 換位後n2: {d}\n換位後n1: {a} , 換位後n2: {b}");
        }
        void GenericSwap<Tt>(ref Tt a, ref Tt b)
        {
            Tt t = a;
            a = b;
            b = t;
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            //建立陣列
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum = arr.Sum();
            labResult.Text = $"int 陣列{{1,5, 6, 8, 7, 97, 54, 887, 65, 578 }}\n" +
                $"加總為{sum}";
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int max = arr.Max(); 
            labResult.Text = $"int 陣列{{1,5, 6, 8, 7, 97, 54, 887, 65, 578 }}\n" +
                $"最大值{max}";
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int min = arr.Min();
            labResult.Text = $"int 陣列{{1,5, 6, 8, 7, 97, 54, 887, 65, 578 }}\n" +
                $"最小值{min}";
        }
        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int min = arr.Min();
            int max=arr.Max();  
            labResult.Text = $"int 陣列{{1,5, 6, 8, 7, 97, 54, 887, 65, 578 }}\n" +
                $"最大值{max}\n最小值{min}";
        }

        private void btnCcheck_Click(object sender, EventArgs e)
        {
            string[] arr = { "mother張", "emma","迪克蕭","J40","candy","cindy","coconut","mot" };
        }

        private void Mastree_Click(object sender, EventArgs e)
        {
            int num;
            bool isNum = int.TryParse(txtnum.Text, out num);
            //int score = int.Parse(txtscore.Text);
            if (isNum)
            {
                int score = int.Parse(txtnum.Text);
                string result = "";
                for (int i = 0; i <= score; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        result = "*";
                    }
                }
                MessageBox.Show(result);
                labResult.Text = result;
            }
            else
            {
                MessageBox.Show("請輸入數字", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnum.Text = "";
                txtnum.Focus();
            }
        }
    }
}
