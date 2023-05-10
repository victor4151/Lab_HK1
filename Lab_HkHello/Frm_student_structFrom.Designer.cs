namespace Lab_HkHello
{
    partial class Frm_student_structFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labEng = new System.Windows.Forms.Label();
            this.labMat = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowSave = new System.Windows.Forms.Button();
            this.groScore = new System.Windows.Forms.GroupBox();
            this.btnShowAvg = new System.Windows.Forms.Button();
            this.labAvg = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.groScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(32, 82);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(78, 28);
            this.labChi.TabIndex = 1;
            this.labChi.Text = "國文:";
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(32, 142);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(78, 28);
            this.labEng.TabIndex = 2;
            this.labEng.Text = "英文:";
            // 
            // labMat
            // 
            this.labMat.AutoSize = true;
            this.labMat.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMat.Location = new System.Drawing.Point(32, 204);
            this.labMat.Name = "labMat";
            this.labMat.Size = new System.Drawing.Size(78, 28);
            this.labMat.TabIndex = 3;
            this.labMat.Text = "數學:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(164, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 46);
            this.txtName.TabIndex = 4;
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChi.Location = new System.Drawing.Point(164, 76);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(181, 46);
            this.txtChi.TabIndex = 5;
            this.txtChi.Text = "0";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(164, 135);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(181, 46);
            this.txtEng.TabIndex = 6;
            this.txtEng.Text = "0";
            // 
            // txtMat
            // 
            this.txtMat.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMat.Location = new System.Drawing.Point(164, 196);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(181, 46);
            this.txtMat.TabIndex = 7;
            this.txtMat.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(38, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 52);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "存檔";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowSave
            // 
            this.btnShowSave.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowSave.Location = new System.Drawing.Point(206, 318);
            this.btnShowSave.Name = "btnShowSave";
            this.btnShowSave.Size = new System.Drawing.Size(165, 52);
            this.btnShowSave.TabIndex = 9;
            this.btnShowSave.Text = "顯示儲存項目";
            this.btnShowSave.UseVisualStyleBackColor = true;
            this.btnShowSave.Click += new System.EventHandler(this.btnShowSave_Click);
            // 
            // groScore
            // 
            this.groScore.Controls.Add(this.btnShowAvg);
            this.groScore.Controls.Add(this.labAvg);
            this.groScore.Controls.Add(this.labScore);
            this.groScore.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groScore.Location = new System.Drawing.Point(398, 12);
            this.groScore.Name = "groScore";
            this.groScore.Size = new System.Drawing.Size(390, 426);
            this.groScore.TabIndex = 10;
            this.groScore.TabStop = false;
            this.groScore.Text = "成績";
            this.groScore.Enter += new System.EventHandler(this.groScore_Enter);
            // 
            // btnShowAvg
            // 
            this.btnShowAvg.Location = new System.Drawing.Point(87, 363);
            this.btnShowAvg.Name = "btnShowAvg";
            this.btnShowAvg.Size = new System.Drawing.Size(276, 42);
            this.btnShowAvg.TabIndex = 2;
            this.btnShowAvg.Text = "顯示最高最低成績";
            this.btnShowAvg.UseVisualStyleBackColor = true;
            this.btnShowAvg.Click += new System.EventHandler(this.btnShowAvg_Click);
            // 
            // labAvg
            // 
            this.labAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labAvg.Location = new System.Drawing.Point(28, 244);
            this.labAvg.Name = "labAvg";
            this.labAvg.Size = new System.Drawing.Size(356, 101);
            this.labAvg.TabIndex = 1;
            // 
            // labScore
            // 
            this.labScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labScore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labScore.Location = new System.Drawing.Point(28, 38);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(356, 208);
            this.labScore.TabIndex = 0;
            // 
            // Frm_student_structFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groScore);
            this.Controls.Add(this.btnShowSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMat);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.label1);
            this.Name = "Frm_student_structFrom";
            this.Text = "Frm_student_structFrom";
            this.groScore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Label labMat;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowSave;
        private System.Windows.Forms.GroupBox groScore;
        private System.Windows.Forms.Button btnShowAvg;
        private System.Windows.Forms.Label labAvg;
        private System.Windows.Forms.Label labScore;
    }
}