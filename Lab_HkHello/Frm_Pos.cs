using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_HkHello
{
    public partial class Frm_Pos : Form
    {
        public Frm_Pos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string[] Order = new string[4];
        double priceBeer=0, priceTeqaila=0, priceWnisky=0,priceWine=0; // 單價
        double numberBeer=0, numberTeqaila=0, numberWnisky = 0, numberWine; // 數量
        double subTotal = 0,discount=0; // 小計
        //double display = 0;

        private void txtList_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtList.Text = "尚未點餐";
            txtTotalPrice.Text = "NT$0";
            priceBeer = 0; priceTeqaila = 0; priceWnisky = 0; priceWine = 0; // 單價
            numberBeer = 0; numberTeqaila = 0; numberWnisky = 0; numberWine =0; // 數量
            subTotal = 0; discount = 0; // 小計
            Order = new string[4];

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額:NT$"+ txtTotalPrice.Text);
        }

        private void btnBeer_Click(object sender, EventArgs e)
        {
            numberBeer += 1;
            priceBeer = 120 * numberBeer;
            subTotal = priceWnisky + priceTeqaila + priceBeer + priceWine;

            txtTotalPrice.Text = "NT$" + subTotal;


            Order[0] = "啤酒beerx" + numberBeer + " 共" + priceBeer;


            txtList.Text = "";
            if (numberTeqaila.ToString() != "0" && numberWnisky.ToString() != "0" && numberWine.ToString() != "0")
            {
                txtList.Text += Order[0] + Environment.NewLine + Order[1] + Environment.NewLine
                    + Order[2] + Environment.NewLine + Order[3] + Environment.NewLine;
            }
            else if (numberTeqaila.ToString() == "0")
            {
                txtList.Text += Order[0] + Environment.NewLine
                    + Order[2] + Environment.NewLine + Order[3] + Environment.NewLine;
            }
            else if (numberWnisky.ToString() == "0")
            {
                txtList.Text += Order[0] + Environment.NewLine
                    + Order[1] + Environment.NewLine + Order[3] ;
            }
            else
                txtList.Text += Order[0] + Environment.NewLine + Order[1] + Environment.NewLine
                                    + Order[2] + Environment.NewLine + Order[3] + Environment.NewLine;

        }

        private void btnTeqaila_Click(object sender, EventArgs e)
        {
            numberTeqaila += 1;
            priceTeqaila = 180 * numberTeqaila;
            subTotal = priceWnisky + priceTeqaila + priceBeer + priceWine;
            txtTotalPrice.Text = "NT$" + subTotal;
            Order[1] = "龍舌蘭Teqaila" + numberTeqaila + " 共" + priceTeqaila;
            //txtList.Text = Order[1];
            txtList.Text = "";
            if (numberBeer.ToString() == "0" && numberWine.ToString() == "0")
            {
                txtList.Text += Order[1] + Environment.NewLine + Order[2];
            }
            else if (numberBeer.ToString() == "0" && numberWnisky.ToString() == "0")
            {
                txtList.Text += Order[1] + Environment.NewLine + Order[3];
            }
            else if (numberBeer.ToString() == "0")
            {
                txtList.Text += Order[1] + Environment.NewLine + Order[2] + Environment.NewLine + Order[3];
            }
            else
                txtList.Text += Order[0] + Environment.NewLine + Order[1] + Environment.NewLine
                                                   + Order[2] + Environment.NewLine + Order[3] + Environment.NewLine;

        }

        private void btnWnisky_Click(object sender, EventArgs e)
        {
            numberWnisky += 1;
            priceWnisky = 350 * numberWnisky;
            subTotal = priceWnisky + priceTeqaila + priceBeer + priceWine;
            txtTotalPrice.Text = "NT$" + subTotal;
            Order[2] = "威士忌Wnisky " + numberWnisky + " 共" + priceWnisky;
            //  txtList.Text = Order[0] + Environment.NewLine + Order[1] + Environment.NewLine + Order[2] + Environment.NewLine + Order[3] + Environment.NewLine;
            txtList.Text = "";
            
            
            if (numberBeer.ToString() == "0" && numberWine.ToString() == "0" && numberTeqaila.ToString() == "0")
            {
                txtList.Text +=  Order[2];
            }
            else if (numberBeer.ToString() == "0" && numberTeqaila.ToString() == "0")
            {
                txtList.Text += Order[2] + Environment.NewLine + Order[3];
            }
            else if (numberBeer.ToString() == "0" && numberWine.ToString() == "0")
            {
                txtList.Text += Order[1] + Environment.NewLine + Order[2];
            }
            else if (numberBeer.ToString() == "0" )
            {
                txtList.Text += Order[1] + Environment.NewLine + Order[2] + Environment.NewLine+ Order[3];
            }
            else if (numberWine.ToString() == "0" && numberTeqaila.ToString() == "0")
            {
                txtList.Text += Order[0] + Environment.NewLine + Order[2];
            }
            else
                txtList.Text += Order[0] + Environment.NewLine + Order[1] + Environment.NewLine
                                                   + Order[2] + Environment.NewLine + Order[3] + Environment.NewLine;
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            numberWine += 1;
            priceWine = 320 * numberWine;
            subTotal = priceWnisky + priceTeqaila + priceBeer + priceWine;
            txtTotalPrice.Text = "NT$" + subTotal;
            Order[3] = "紅酒Wine " + numberWine + " 共" + priceWine;
            //  txtList.Text = Order[0] + Environment.NewLine + Order[1] + Environment.NewLine + Order[2] + Environment.NewLine + Order[3] + Environment.NewLine;
            txtList.Text = "";
            if (numberBeer.ToString() == "0" && numberWnisky.ToString() == "0" && numberTeqaila.ToString() == "0")
            {
                txtList.Text += Order[3];
            }
            else if (numberBeer.ToString() == "0"  && numberTeqaila.ToString() == "0")
            {
                txtList.Text += Order[2] + Environment.NewLine + Order[3];
            }
            else if (numberBeer.ToString() == "0" && numberWnisky.ToString() == "0")
            {
                txtList.Text += Order[1] + Environment.NewLine + Order[3];
            }
            else if (numberTeqaila.ToString() == "0" && numberWnisky.ToString() == "0")
            {
                txtList.Text += Order[0] + Environment.NewLine + Order[3];
            }
            else if (numberBeer.ToString() == "0" )
            {
                txtList.Text += Order[1] + Environment.NewLine + Order[2] + Environment.NewLine + Order[3];
            }

            else
                txtList.Text += Order[0] + Environment.NewLine + Order[1] + Environment.NewLine
                                                       + Order[2] + Environment.NewLine + Order[3] + Environment.NewLine;
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            discount = subTotal * 0.9;
            txtTotalPrice.Text = subTotal.ToString() ;
            MessageBox.Show("總金額:NT$" + txtTotalPrice.Text+"\n折扣後金額"+ discount);
        }

        private void labWine_Click(object sender, EventArgs e)
        {
            //numberWine += 1;
            //priceWine = 320 * numberWine;
            //subTotal = priceWnisky + priceTeqaila + priceBeer + priceWine;
            //txtTotalPrice.Text = "NT$" + subTotal;
            //Order[3] = "紅酒Wine " + numberWine + " 共" + priceWine;
           // txtList.Text = Order[0] + Environment.NewLine + Order[1] + Environment.NewLine + Order[2] + Environment.NewLine + Order[3] + Environment.NewLine;
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void labWnisky_Click(object sender, EventArgs e)
        {
            //numberWnisky += 1;
            //priceWnisky = 350 * numberWnisky;
            //subTotal = priceWnisky + priceTeqaila+ priceBeer+ priceWine;
            //txtTotalPrice.Text = "NT$" + subTotal;
            //Order[2] = "威士忌Wnisky " + numberWnisky + " 共" + priceWnisky;
            //txtList.Text = Order[0] + Environment.NewLine + Order[1] + Environment.NewLine + Order[2] + Environment.NewLine + Order[3] + Environment.NewLine;

        }

        private void labBeer_Click(object sender, EventArgs e)
        {
            //numberBeer += 1;
            //priceBeer = 120* numberBeer;
            //subTotal = priceWnisky + priceTeqaila + priceBeer + priceWine;
            
            //txtTotalPrice.Text = "NT$" + subTotal;


            //Order[0] = "啤酒beerx" + numberBeer + " 共" + priceBeer;
            
            //txtList.Text +=Order[0];

        }

        private void labTeqaila_Click(object sender, EventArgs e)
        {
           // numberTeqaila += 1;
           // priceTeqaila = 180 * numberTeqaila;
           // subTotal = priceWnisky + priceTeqaila + priceBeer + priceWine;
           // txtTotalPrice.Text = "NT$" + subTotal;

           // Order[1] = "龍舌蘭Teqailax " + numberTeqaila + " 共" + priceTeqaila;

           //// txtList.Text +=Order[1]+"\n";
 
        }

    }   
}
