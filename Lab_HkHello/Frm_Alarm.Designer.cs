namespace Lab_HkHello
{
    partial class Frm_Alarm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labtimeNow = new System.Windows.Forms.Label();
            this.groSelTim = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.checkAlarm = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeExplode = new System.Windows.Forms.Timer(this.components);
            this.labtimecheck = new System.Windows.Forms.Label();
            this.groSelTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labtimeNow
            // 
            this.labtimeNow.AutoSize = true;
            this.labtimeNow.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtimeNow.Location = new System.Drawing.Point(104, 59);
            this.labtimeNow.Name = "labtimeNow";
            this.labtimeNow.Size = new System.Drawing.Size(0, 36);
            this.labtimeNow.TabIndex = 0;
            // 
            // groSelTim
            // 
            this.groSelTim.Controls.Add(this.labtimecheck);
            this.groSelTim.Controls.Add(this.txtTime);
            this.groSelTim.Controls.Add(this.checkAlarm);
            this.groSelTim.Controls.Add(this.label2);
            this.groSelTim.Controls.Add(this.label1);
            this.groSelTim.Location = new System.Drawing.Point(149, 114);
            this.groSelTim.Name = "groSelTim";
            this.groSelTim.Size = new System.Drawing.Size(542, 277);
            this.groSelTim.TabIndex = 1;
            this.groSelTim.TabStop = false;
            this.groSelTim.Text = "Select time";
            this.groSelTim.Enter += new System.EventHandler(this.groSelTim_Enter);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTime.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTime.Location = new System.Drawing.Point(209, 128);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(149, 36);
            this.txtTime.TabIndex = 3;
            // 
            // checkAlarm
            // 
            this.checkAlarm.AutoSize = true;
            this.checkAlarm.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkAlarm.Location = new System.Drawing.Point(220, 196);
            this.checkAlarm.Name = "checkAlarm";
            this.checkAlarm.Size = new System.Drawing.Size(138, 28);
            this.checkAlarm.TabIndex = 2;
            this.checkAlarm.Text = "Set Alarm";
            this.checkAlarm.UseVisualStyleBackColor = true;
            this.checkAlarm.CheckedChanged += new System.EventHandler(this.checkAlarm_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(216, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = " Alarm Time";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(36, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = " Alarm Time:";
            // 
            // timeExplode
            // 
            this.timeExplode.Tick += new System.EventHandler(this.timeExplode_Tick);
            // 
            // labtimecheck
            // 
            this.labtimecheck.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labtimecheck.Location = new System.Drawing.Point(220, 170);
            this.labtimecheck.Name = "labtimecheck";
            this.labtimecheck.Size = new System.Drawing.Size(135, 23);
            this.labtimecheck.TabIndex = 4;
            this.labtimecheck.Text = "格式 00:00:00";
            // 
            // Frm_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groSelTim);
            this.Controls.Add(this.labtimeNow);
            this.Name = "Frm_Alarm";
            this.Text = "Frm_Alarm";
            this.Load += new System.EventHandler(this.Frm_Alarm_Load);
            this.groSelTim.ResumeLayout(false);
            this.groSelTim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labtimeNow;
        private System.Windows.Forms.GroupBox groSelTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkAlarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Timer timeExplode;
        private System.Windows.Forms.Label labtimecheck;
    }
}