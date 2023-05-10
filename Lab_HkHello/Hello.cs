using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_HkHello
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name1 = txtname.Text;
            string name2 = txtEname.Text;
            string name3 = txtSex.Text;
            string name4 = txtStar.Text;
            MessageBox.Show("Hello 我是" + name1 + "\n" + "英文明子是" + name2 + "\n" + "性別是" + name3 + 
                "\n" + "星座是" + name4 + "\n" + "很高興認識你");
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string name1 = txtname.Text;
            string name2 = txtEname.Text;
            string name3 = txtSex.Text;
            string name4 = txtStar.Text;
            MessageBox.Show("Hi 我是" + name1 + "\n" + "英文明子是" + name2 + "\n" + "性別是" + name3 +
                "\n" + "星座是" + name4 + "\n" + "很高興認識你");
        }
    }
}
