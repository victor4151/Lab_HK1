using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_HkHello
{
    public partial class Frm_xoGame : Form
    {
        public Frm_xoGame()
        {
            InitializeComponent();
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool flag = true;
        int[] b = new int[10] {0,0,0,0,0,0,0,0,0,0};

        private void btn1_Click(object sender, EventArgs e)
        {
            //b[0] = 0;
            //if (flag)
            //{
            //    b[0] = -1;
            //    btn1.Text = "X";
            //}
            //else
            //{
            //    b[0] = 1;
            //    btn1.Text = "O";
            //}

            //flag = !flag;
            //CheckOX();
            //btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //b[1] = 0;
            //if (flag)
            //{
            //    b[1] = -1;
            //    this.btn2.Text = "X";
            //}
            //else
            //{
            //    b[1] = 1;
            //    btn2.Text = "O";
            //}

            //flag = !flag;
            //CheckOX();
            //btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //b[2] = 0;
            //if (flag)
            //{
            //    b[2] = -1;
            //    this.btn3.Text = "X";
            //}
            //else
            //{
            //    b[2] = 1;
            //    btn3.Text = "O";
            //}
            //flag = !flag;
            //CheckOX();
            //btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //b[3] = 0;
            //if (flag)
            //{
            //    b[3] = -1;
            //    this.btn4.Text = "X";
            //}
            //else {
            //    btn4.Text = "O";
           
            //    b[3] = 1;
                
            //}flag = !flag;
            //CheckOX();
            //btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //b[4] = 0;
            //if (flag)
            //{
            //    b[4] = -1;
            //    this.btn5.Text = "X";
            //}
            //else
            //    btn5.Text = "O";
            //{
            //    b[4] = 1;
                
            //}flag = !flag;
            //CheckOX();
            //btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //b[5] = 0;
            //if (flag)
            //{
            //    b[5]= -1;
            //    this.btn6.Text = "X";
            //}
            //else
            //    btn6.Text = "O";
            //{
            //    b[5] = 1;
                
            //}flag = !flag;
            //CheckOX();
            //btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //b[6] = 0;
            //if (flag)
            //{
            //    b[6] = -1;
            //    this.btn7.Text = "X";
            //}
            //else
            //  {
            //    b[6] = 1;
            //    btn7.Text = "O";           
            //  }
            // flag = !flag;
            //CheckOX();
            //btn7.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //b[7] = 0;
            //if (flag)
            //{
            //    b[7] = -1;
            //    this.btn8.Text = "X";
            //}
            //else
            //{
            //    b[7] = 1;
            //    btn8.Text = "O";
            //}
            //    flag = !flag;
            //CheckOX();
            //btn8.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //b[8] = 0;
            //if (flag)
            //{
            //    b[8] = -1;
            //    this.btn9.Text = "X";
            //}
            //else
            //  {
            //    b[8] = 1;
            //    btn9.Text = "O";
            //  }
            //    flag = !flag;
            //CheckOX();
            //btn9.Enabled = false;
            
        }
        void CheckOX()
        { 
            if (b[0] + b[1] + b[2] == 3)
            {
                MessageBox.Show("O贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }

            }
            else if (b[0] + b[1] + b[2] == -3)
            {
                MessageBox.Show("X贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            else if (b[0] + b[3] + b[6] == 3)
            {
                MessageBox.Show("O贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            else if (b[0] + b[3] + b[6] == -3)
            {
                MessageBox.Show("X贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            /////
            else if (b[0] + b[4] + b[8] == 3)
            {
                MessageBox.Show("O贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            else if (b[0] + b[4] + b[8] == -3)
            {
                MessageBox.Show("X贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            ////
            else if (b[1] + b[4] + b[7] == 3)
            {
                MessageBox.Show("O贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            else if (b[1] + b[4] + b[7] == -3)
            {
                MessageBox.Show("X贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            /////
            else if (b[2] + b[5] + b[8] == 3)
            {
                MessageBox.Show("O贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            else if (b[2] + b[5] + b[8] == -3)
            {
                MessageBox.Show("X贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            /////
            else if (b[2] + b[4] + b[6] == 3)
            {
                MessageBox.Show("O贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            else if (b[2] + b[4] + b[6] == -3)
            {
                MessageBox.Show("X贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            ////////
            else if (b[3] + b[4] + b[5] == 3)
            {
                MessageBox.Show("O贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            else if (b[3] + b[4] + b[5] == -3)
            {
                MessageBox.Show("X贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            ///////
            else if (b[6] + b[7] + b[8] == 3)
            {
                MessageBox.Show("O贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            else if (b[6] + b[7] + b[8] == -3)
            {
                MessageBox.Show("X贏");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
            else if (b[0]!=0&&b[1] != 0 && b[2] != 0 && b[3] != 0 && b[4] != 0 && b[5] != 0
                && b[6] != 0 && b[7] != 0 && b[8] != 0)
            {
                MessageBox.Show("平手");
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            flag = true;
            b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            foreach (Control x in this.Controls)
                if (x is Label)
                {
                    ((Label)x).Text = "";
                    ((Label)x).Enabled = true;
                }
        }

        private void Frm_xoGame_Load(object sender, EventArgs e)
        {

        }

        private void lab1_Click(object sender, EventArgs e)
        {
            //b[0] = 0;
            if (flag)
            {
                b[0] = -1;
                lab1.Text = "X";
            }
            else
            {
                b[0] = 1;
                lab1.Text = "O";
            }
            flag = !flag;
            CheckOX();
            lab1.Enabled = false;
        }

        private void lab2_Click(object sender, EventArgs e)
        {
          //  b[1] = 0;
            if (flag)
            {
                b[1] = -1;
                lab2.Text = "X";
            }
            else
            {
                b[1] = 1;
                lab2.Text = "O";
            }

            flag = !flag;
            CheckOX();
            lab2.Enabled = false;
        }

        private void lab3_Click(object sender, EventArgs e)
        {
           // b[2] = 0;
            if (flag)
            {
                b[2] = -1;
                lab3.Text = "X";
            }
            else
            {
                b[2] = 1;
                lab3.Text = "O";
            }
            flag = !flag;
            CheckOX();
            lab3.Enabled = false;
        }

        private void lab4_Click(object sender, EventArgs e)
        {
          //  b[3] = 0;
            if (flag)
            {
                b[3] = -1;
                lab4.Text = "X";
            }
            else
            {
                lab4.Text = "O";

                b[3] = 1;

            }
            flag = !flag;
            CheckOX();
            lab4.Enabled = false;
        }

        private void lab5_Click(object sender, EventArgs e)
        {
           // b[4] = 0;
            if (flag)
            {
                b[4] = -1;
                lab5.Text = "X";
            }
            else
                
            {
                b[4] = 1;
                lab5.Text = "O";
            }
            flag = !flag;
            CheckOX();
            lab5.Enabled = false;
        }

        private void lab6_Click(object sender, EventArgs e)
        {
          //  b[5] = 0;
            if (flag)
            {
                b[5] = -1;
                lab6.Text = "X";
            }
            else
                
            {
                b[5] = 1;
                lab6.Text = "O";
            }
            flag = !flag;
            CheckOX();
            lab6.Enabled = false;
        }

        private void lab7_Click(object sender, EventArgs e)
        {
          //  b[6] = 0;
            if (flag)
            {
                b[6] = -1;
                lab7.Text = "X";
            }
            else
            {
                b[6] = 1;
                lab7.Text = "O";
            }
            flag = !flag;
            CheckOX();
            lab7.Enabled = false;
        }

        private void lab8_Click(object sender, EventArgs e)
        {
          //  b[7] = 0;
            if (flag)
            {
                b[7] = -1;
                lab8.Text = "X";
            }
            else
            {
                b[7] = 1;
                lab8.Text = "O";
            }
            flag = !flag;
            CheckOX();
            lab8.Enabled = false;
        }

        private void lab9_Click(object sender, EventArgs e)
        {
           // b[8] = 0;
            if (flag)
            {
                b[8] = -1;
                lab9.Text = "X";
            }
            else
            {
                b[8] = 1;
                lab9.Text = "O";
            }
            flag = !flag;
            CheckOX();
            lab9.Enabled = false;
        }

        private void Frm_xoGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyData == Keys.R)
            {
                flag = true;
                b = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                foreach (Control x in this.Controls)
                    if (x is Label)
                    {
                        ((Label)x).Text = "";
                        ((Label)x).Enabled = true;
                    }
            }
        }
    }
}

