namespace Lab_HkHello
{
    partial class Frm_DrawPaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureColorShow = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.trackBarColor = new System.Windows.Forms.TrackBar();
            this.labpenSize = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColorShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labpenSize);
            this.panel1.Controls.Add(this.pictureColorShow);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.trackBarColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 450);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureColorShow
            // 
            this.pictureColorShow.BackColor = System.Drawing.Color.Black;
            this.pictureColorShow.Location = new System.Drawing.Point(657, 87);
            this.pictureColorShow.Name = "pictureColorShow";
            this.pictureColorShow.Size = new System.Drawing.Size(100, 50);
            this.pictureColorShow.TabIndex = 2;
            this.pictureColorShow.TabStop = false;
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnColor.Location = new System.Drawing.Point(669, 30);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 51);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "顏色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // trackBarColor
            // 
            this.trackBarColor.Location = new System.Drawing.Point(675, 163);
            this.trackBarColor.Maximum = 100;
            this.trackBarColor.Name = "trackBarColor";
            this.trackBarColor.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarColor.Size = new System.Drawing.Size(69, 202);
            this.trackBarColor.TabIndex = 0;
            this.trackBarColor.Scroll += new System.EventHandler(this.trackBarColor_Scroll);
           
            // 
            // labpenSize
            // 
            this.labpenSize.AutoSize = true;
            this.labpenSize.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labpenSize.Location = new System.Drawing.Point(680, 368);
            this.labpenSize.Name = "labpenSize";
            this.labpenSize.Size = new System.Drawing.Size(18, 20);
            this.labpenSize.TabIndex = 3;
            this.labpenSize.Text = "0";
            // 
            // Frm_DrawPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_DrawPaint";
            this.Text = "Frm_DrawPaint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColorShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TrackBar trackBarColor;
        private System.Windows.Forms.PictureBox pictureColorShow;
        private System.Windows.Forms.Label labpenSize;
    }
}