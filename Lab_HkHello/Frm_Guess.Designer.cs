namespace Lab_HkHello
{
    partial class Frm_Guess
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
            this.labGuessC = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnSAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labGuessC
            // 
            this.labGuessC.AutoSize = true;
            this.labGuessC.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGuessC.Location = new System.Drawing.Point(83, 77);
            this.labGuessC.Name = "labGuessC";
            this.labGuessC.Size = new System.Drawing.Size(643, 36);
            this.labGuessC.TabIndex = 0;
            this.labGuessC.Text = "Please Select A Number Between 0 To 100";
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(116, 251);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(240, 84);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnSAnswer
            // 
            this.btnSAnswer.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSAnswer.Location = new System.Drawing.Point(392, 251);
            this.btnSAnswer.Name = "btnSAnswer";
            this.btnSAnswer.Size = new System.Drawing.Size(240, 84);
            this.btnSAnswer.TabIndex = 2;
            this.btnSAnswer.Text = "Show Answer";
            this.btnSAnswer.UseVisualStyleBackColor = true;
            this.btnSAnswer.Click += new System.EventHandler(this.btnSAnswer_Click);
            // 
            // Frm_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSAnswer);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.labGuessC);
            this.Name = "Frm_Guess";
            this.Text = "Frm_Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnSAnswer;
        public System.Windows.Forms.Label labGuessC;
    }
}