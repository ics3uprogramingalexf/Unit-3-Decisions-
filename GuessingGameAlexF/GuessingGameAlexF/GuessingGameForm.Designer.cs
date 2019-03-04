namespace GuessingGameAlexF
{
    partial class frmGuessingGame
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnCheckNumber = new System.Windows.Forms.Button();
            this.picCorrectOrWrong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCorrectOrWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("PMingLiU-ExtB", 12.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblQuestion.Location = new System.Drawing.Point(12, 42);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(247, 17);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Guess the random number (1-10)";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(263, 42);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // btnCheckNumber
            // 
            this.btnCheckNumber.Location = new System.Drawing.Point(369, 40);
            this.btnCheckNumber.Name = "btnCheckNumber";
            this.btnCheckNumber.Size = new System.Drawing.Size(75, 23);
            this.btnCheckNumber.TabIndex = 2;
            this.btnCheckNumber.Text = "Check Number";
            this.btnCheckNumber.UseVisualStyleBackColor = true;
            this.btnCheckNumber.Click += new System.EventHandler(this.btnCheckNumber_Click);
            // 
            // picCorrectOrWrong
            // 
            this.picCorrectOrWrong.Image = global::GuessingGameAlexF.Properties.Resources.red_x;
            this.picCorrectOrWrong.Location = new System.Drawing.Point(93, 130);
            this.picCorrectOrWrong.Name = "picCorrectOrWrong";
            this.picCorrectOrWrong.Size = new System.Drawing.Size(327, 253);
            this.picCorrectOrWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCorrectOrWrong.TabIndex = 3;
            this.picCorrectOrWrong.TabStop = false;
            // 
            // frmGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 441);
            this.Controls.Add(this.picCorrectOrWrong);
            this.Controls.Add(this.btnCheckNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmGuessingGame";
            this.Text = "Guessing Game Alex Forgeron";
            ((System.ComponentModel.ISupportInitialize)(this.picCorrectOrWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnCheckNumber;
        private System.Windows.Forms.PictureBox picCorrectOrWrong;
    }
}

