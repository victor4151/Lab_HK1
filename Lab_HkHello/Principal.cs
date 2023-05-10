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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void textRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void PTM_Click(object sender, EventArgs e)
        {
            /*
            double Loan = double.Parse(textLoan.Text);
            double Date = double.Parse(textDate.Text);
            double Rate = double.Parse(textRate.Text);
            double r = 1 + Rate / 12 / 100;
            double n = Date * 12;
            double rpn = Math.Pow(r, n);
            double PMT = Loan * rpn * (r - 1) / (rpn - 1);
            MessageBox.Show("每月"+(int)PMT);
            */
            double Loan = double.Parse(textLoan.Text); // 本金
            double Date = double.Parse(textDate.Text); // 年期
            double Rate = double.Parse(textRate.Text); // 年利率
            //double r = Rate / 12 / 100; //月利率
            //double m = Date * 12; //月數

            //double MRP = Math.Pow((1 + r), m) * r / Math.Pow((1 + r), m) - 1;

            /*{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            (公式中：月利率 ＝ 年利率／12 ； 月數=貸款年期 ｘ 12)
            */
            //  string result = MonthPay(Loan, Date, Rate);
            MessageBox.Show("每月應繳" + MonthPay(Loan, Date, Rate));
            //MessageBox.Show("每月應繳" + (int)Loan * MRP);
        }

        private void Report_Click(object sender, EventArgs e)
        {
            
             PrincipalReport frm = new PrincipalReport(); //呼叫別個FRM
             frm.txtMoney.Text = textLoan.Text;  //將使用者輸入數字轉到另一張表單中的txt欄位
             frm.txtNumber.Text = textDate.Text; //將使用者輸入數字轉到另一張表單中的txt欄位
             frm.txtRate.Text = textRate.Text;    //將使用者輸入數字轉到另一張表單中的txt欄位
            double Loan = double.Parse(textLoan.Text); // 本金
            double Date = double.Parse(textDate.Text); // 年期
            double Rate = double.Parse(textRate.Text); // 年利率
            MonthPay(Loan, Date, Rate);
            frm.txtMon.Text = MonthPay(Loan, Date, Rate).ToString();
            frm.txtTotal.Text = (MonthPay(Loan, Date, Rate)*12*Date).ToString();
            //string result = MonthPay();
            frm.ShowDialog();

        }
        double MonthPay(double Loan1, double Date1, double Rate1) // 方法計算本息公式
        {
            
            double r = Rate1 / 12 / 100; //月利率
            double m = Date1 * 12; //月數

            double MRP = (Math.Pow((1 + r), m) * r) / (Math.Pow((1 + r), m) - 1);
            /*{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            (公式中：月利率 ＝ 年利率／12 ； 月數=貸款年期 ｘ 12)
            */

            MRP = Loan1 * MRP; 
            return MRP;
        }

        private void Total_Click(object sender, EventArgs e)
        {
            //計算總金額
            double Loan = double.Parse(textLoan.Text); // 本金
            double Date = double.Parse(textDate.Text); // 年期
            double Rate = double.Parse(textRate.Text); // 年利率
            MonthPay(Loan, Date, Rate);
            double total = MonthPay(Loan, Date, Rate) * Date * 12;//貸款金*(月*12)年
            MessageBox.Show("總共金額" + total);
        }
    }
}
