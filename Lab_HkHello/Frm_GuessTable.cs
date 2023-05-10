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
    public partial class Frm_GuessTable : Form
    {
        public Frm_Guess frm1;//取名frm1 之後能將
        public Frm_GuessTable(Frm_Guess frm) //可將值取出
        {
            InitializeComponent();
            frm1 = frm; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int max = 100, min = 0;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Random n = new Random();
            // int num = n.Next(1, 100);
            //num = n.Next(1, 100);
            //for (; ; )
            //{\
                    
            if (int.TryParse(txtNumer.Text, out int num))
            {
                //int i = int.Parse(txtNumer.Text);輸入值
                //if (i != num)
                //   {
                if (num >= min && num <= max)
                {
                    if (num > Frm_Guess.ans)
                    {
                        max = num;
                        frm1.labGuessC.Text = $"Please Select A Number Between {min} To {max}";
                        //MessageBox.Show($" 答案'{Frm_Guess.ans} 最大{max} 最小{min}");
                    }
                    else if (num < Frm_Guess.ans)
                    {
                        min = num;
                        frm1.labGuessC.Text = $"Please Select A Number Between {min} To {max}";
                    }
                    else if (num == Frm_Guess.ans)
                    {
                        MessageBox.Show($" 恭喜你答對了 答案就是:{Frm_Guess.ans}");
                    }
                }
                else {
                    MessageBox.Show("請輸入0~100", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
                    //MessageBox.Show($"答案介於 {min}到{max}");
              //      break;
              //  }
               // else if (i == num)
               // {
                  //  MessageBox.Show($"恭喜答對答案為:{i}");
                //    break;
              // }

           // }
        }
    }
}
