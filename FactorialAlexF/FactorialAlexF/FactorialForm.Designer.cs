namespace FactorialAlexF
{
    partial class FactorialForm
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
            this.lstNum = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstNum
            // 
            this.lstNum.FormattingEnabled = true;
            this.lstNum.Location = new System.Drawing.Point(281, 306);
            this.lstNum.Name = "lstNum";
            this.lstNum.Size = new System.Drawing.Size(120, 95);
            this.lstNum.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(281, 213);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(170, 162);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(158, 18);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Imput the number here!";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(358, 162);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(128, 20);
            this.txtInput.TabIndex = 3;
            // 
            // FactorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FactorialAlexF.Properties.Resources.the_room_tommy_wiseau_;
            this.ClientSize = new System.Drawing.Size(715, 521);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstNum);
            this.Name = "FactorialForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNum;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtInput;
    }
}

