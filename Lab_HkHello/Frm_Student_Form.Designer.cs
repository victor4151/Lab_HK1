namespace Lab_HkHello
{
    partial class Frm_Student_Form
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
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labMat = new System.Windows.Forms.Label();
            this.labEng = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnTotsl = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnRandom20 = new System.Windows.Forms.Button();
            this.labData = new System.Windows.Forms.Label();
            this.labAvg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMat
            // 
            this.txtMat.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMat.Location = new System.Drawing.Point(148, 190);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(181, 46);
            this.txtMat.TabIndex = 15;
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(148, 129);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(181, 46);
            this.txtEng.TabIndex = 14;
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChi.Location = new System.Drawing.Point(148, 70);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(181, 46);
            this.txtChi.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(148, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 46);
            this.txtName.TabIndex = 12;
            // 
            // labMat
            // 
            this.labMat.AutoSize = true;
            this.labMat.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMat.Location = new System.Drawing.Point(16, 198);
            this.labMat.Name = "labMat";
            this.labMat.Size = new System.Drawing.Size(78, 28);
            this.labMat.TabIndex = 11;
            this.labMat.Text = "數學:";
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(16, 136);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(78, 28);
            this.labEng.TabIndex = 10;
            this.labEng.Text = "英文:";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(16, 76);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(78, 28);
            this.labChi.TabIndex = 9;
            this.labChi.Text = "國文:";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab.Location = new System.Drawing.Point(16, 14);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(78, 28);
            this.lab.TabIndex = 8;
            this.lab.Text = "姓名:";
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btncreate.Location = new System.Drawing.Point(45, 291);
            this.btncreate.Margin = new System.Windows.Forms.Padding(4);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(267, 69);
            this.btncreate.TabIndex = 16;
            this.btncreate.Text = "加入學生資料";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom.Location = new System.Drawing.Point(45, 369);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(267, 69);
            this.btnRandom.TabIndex = 17;
            this.btnRandom.Text = "隨機儲存資料";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnTotsl
            // 
            this.btnTotsl.Enabled = false;
            this.btnTotsl.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotsl.Location = new System.Drawing.Point(45, 447);
            this.btnTotsl.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotsl.Name = "btnTotsl";
            this.btnTotsl.Size = new System.Drawing.Size(267, 69);
            this.btnTotsl.TabIndex = 18;
            this.btnTotsl.Text = "各科統計";
            this.btnTotsl.UseVisualStyleBackColor = true;
            this.btnTotsl.Click += new System.EventHandler(this.btnTotsl_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClean.Location = new System.Drawing.Point(45, 594);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(267, 69);
            this.btnClean.TabIndex = 19;
            this.btnClean.Text = "重設所有資料";
            this.btnClean.UseVisualStyleBackColor = true;

            // 
            // btnRandom20
            // 
            this.btnRandom20.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom20.Location = new System.Drawing.Point(45, 672);
            this.btnRandom20.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandom20.Name = "btnRandom20";
            this.btnRandom20.Size = new System.Drawing.Size(267, 69);
            this.btnRandom20.TabIndex = 20;
            this.btnRandom20.Text = "隨機加入20筆資料";
            this.btnRandom20.UseVisualStyleBackColor = true;
            this.btnRandom20.Click += new System.EventHandler(this.btnRandom20_Click);
            // 
            // labData
            // 
            this.labData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labData.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labData.Location = new System.Drawing.Point(349, 9);
            this.labData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labData.Name = "labData";
            this.labData.Size = new System.Drawing.Size(1000, 524);
            this.labData.TabIndex = 21;
            this.labData.Text = "姓名            國文     英文     數學     總分     平均     最低     最高";
            // 
            // labAvg
            // 
            this.labAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labAvg.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAvg.Location = new System.Drawing.Point(349, 561);
            this.labAvg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAvg.Name = "labAvg";
            this.labAvg.Size = new System.Drawing.Size(1000, 285);
            this.labAvg.TabIndex = 22;
            // 
            // Frm_Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 900);
            this.Controls.Add(this.labAvg);
            this.Controls.Add(this.labData);
            this.Controls.Add(this.btnRandom20);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnTotsl);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMat);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.lab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Student_Form";
            this.Text = "Frm_Student_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labMat;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnTotsl;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnRandom20;
        private System.Windows.Forms.Label labData;
        private System.Windows.Forms.Label labAvg;
    }
}