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
    public partial class Frm_DrawPaint : Form
    {
        Graphics g;
        int x=0, y=0;
        bool moving=false;
        Pen pen;
        public Frm_DrawPaint()
        {
            InitializeComponent();
            g =panel1.CreateGraphics();//定義畫筆範圍
            pen = new Pen(Color.Black, 1);//定義預設範圍預設
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //系統上面MouseEventArgs e 抓取MouseEventArgsa是否為true當為真開始記錄
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //判斷滑鼠條件是否觸發
            if(moving && x!=0 && y!=0)
            {
                g.DrawLine(pen, new Point(x, y), e.Location); //當g的定義畫布範圍
                x=e.X;
                y=e.Y;  
            }
        }

        private void trackBarColor_Scroll(object sender, EventArgs e)
        {
            labpenSize.Text= trackBarColor.Value.ToString(); 
            pen.Width = trackBarColor.Value;//粗細值使用width  當Scroo發生時抓取屬性為value
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyColorDialog = new ColorDialog();//開啟color Dialog
            if (MyColorDialog.ShowDialog() == DialogResult.OK)//判斷開啟條件
            pictureColorShow.BackColor = MyColorDialog.Color;//Dialog顏色賦予到圖示上
            pen.Color = MyColorDialog.Color;// Dialog顏色賦予到pen的顏色上
        }



        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //當Mouse左鍵放開時將數值規0
            moving=false;
            x = 0;
            y = 0;
        }


    }
}
