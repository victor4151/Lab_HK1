namespace Lab_HkHello
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textRate = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textLoan = new System.Windows.Forms.TextBox();
            this.PTM = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(32, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "利率(%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "期限(年)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "貸款金額";
            // 
            // textRate
            // 
            this.textRate.Location = new System.Drawing.Point(214, 101);
            this.textRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textRate.Name = "textRate";
            this.textRate.Size = new System.Drawing.Size(68, 22);
            this.textRate.TabIndex = 12;
            this.textRate.TextChanged += new System.EventHandler(this.textRate_TextChanged);
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(214, 65);
            this.textDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(68, 22);
            this.textDate.TabIndex = 11;
            // 
            // textLoan
            // 
            this.textLoan.Location = new System.Drawing.Point(214, 39);
            this.textLoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textLoan.Name = "textLoan";
            this.textLoan.Size = new System.Drawing.Size(68, 22);
            this.textLoan.TabIndex = 10;
            // 
            // PTM
            // 
            this.PTM.Location = new System.Drawing.Point(116, 180);
            this.PTM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PTM.Name = "PTM";
            this.PTM.Size = new System.Drawing.Size(50, 30);
            this.PTM.TabIndex = 15;
            this.PTM.Text = "PTM";
            this.PTM.UseVisualStyleBackColor = true;
            this.PTM.Click += new System.EventHandler(this.PTM_Click);
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(245, 180);
            this.Report.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(50, 30);
            this.Report.TabIndex = 14;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(177, 180);
            this.Total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(50, 31);
            this.Total.TabIndex = 13;
            this.Total.Text = "Total";
            this.Total.UseVisualStyleBackColor = true;
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.PTM);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.textRate);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textLoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRate;
        private System.Windows.Forms.TextBox textDate;
        private System.Windows.Forms.TextBox textLoan;
        private System.Windows.Forms.Button PTM;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button Total;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}