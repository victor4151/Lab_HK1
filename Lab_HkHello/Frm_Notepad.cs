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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing.Printing;



namespace Lab_HkHello
{
    public partial class Frm_Notepad : Form
    {
        public Frm_Notepad()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = @"D:\ruyut\Download";
            System.Diagnostics.Process.Start("Explorer.exe", $"/e, {filename}");
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtShow.Text = rtxtShow.Text.ToUpper();
        }

        private void toToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtShow.Text = rtxtShow.Text.ToLower();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtShow.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtShow.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtShow.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtShow.ForeColor = Color.Black;
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyColorDialog = new ColorDialog();//開啟clolr
            if (MyColorDialog.ShowDialog() == DialogResult.OK)
                rtxtShow.ForeColor = MyColorDialog.Color;
           
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtShow.Cut();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            string filename = @"D:\ruyut\Download";
            System.Diagnostics.Process.Start("Explorer.exe", $"/e, {filename}");
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtShow.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(rtxtShow.SelectedText);
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtShow.Text += (String)Clipboard.GetDataObject().GetData(DataFormats.Text);
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(rtxtShow.SelectedText);
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            rtxtShow.Text += (String)Clipboard.GetDataObject().GetData(DataFormats.Text);
        }

        private void 字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog MyFontDialog = new FontDialog();//開啟clolr
            if (MyFontDialog.ShowDialog() == DialogResult.OK)
                rtxtShow.ForeColor = MyFontDialog.Color;
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Notepad_about frm = new Frm_Notepad_about();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("ok");
            }
        }

        private void 列印PToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 預覽列印VToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
