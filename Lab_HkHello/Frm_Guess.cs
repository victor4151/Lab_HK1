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
    public partial class Frm_Guess : Form
    {
        public Frm_Guess()
        {
            InitializeComponent();
        }
        public static int ans = 0;
        private void btnGuess_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            ans = n.Next(0, 101);
            Frm_GuessTable frm  = new Frm_GuessTable(this);// this開啟表單時將值也一起傳送
            frm.ShowDialog();
            
        }

        private void btnSAnswer_Click(object sender, EventArgs e)
        {
            Random n = new Random();
            ans = n.Next(1, 100);
            MessageBox.Show($"答案就是:{ans}");
        }
    }
}
