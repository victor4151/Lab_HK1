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
    public partial class Frm_MyClac : Form
    {
        public Frm_MyClac()
        {
            InitializeComponent();
        }
        int[] Num = new int[3];
        private void btnCount_Click(object sender, EventArgs e)
        {
            Num[0]= int.Parse(txtNum1.Text);
            Num[1]= int.Parse(txtNum2.Text);
            Num[2] = Num[0] + Num[1];
            txtAnswer.Text = Num[2].ToString();
            //MessageBox.Show(txtAnswer.Text);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Num[0] = int.Parse(txtNum1.Text);
            Num[1] = int.Parse(txtNum2.Text);
            Num[2] = Num[0] - Num[1];
            txtAnswer.Text = Num[2].ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Num[0] = int.Parse(txtNum1.Text);
            Num[1] = int.Parse(txtNum2.Text);
            Num[2] = Num[0] * Num[1];
            txtAnswer.Text = Num[2].ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            decimal num1, num2, total;
            num1 = decimal.Parse(txtNum1.Text);
            num2 = decimal.Parse(txtNum2.Text);
            total = num1 / num2;
            this.txtAnswer.Text = string.Format("{0:#,##0.00}", Convert.ToDecimal(total));
            txtAnswer.Text = total.ToString();
        }
    }
}
