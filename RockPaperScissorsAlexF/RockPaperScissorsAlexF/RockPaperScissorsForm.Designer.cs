namespace RockPaperScissorsAlexF
{
    partial class frmRockPaperScissors
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
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.grbCom = new System.Windows.Forms.GroupBox();
            this.radScissorsCom = new System.Windows.Forms.RadioButton();
            this.radPaperCom = new System.Windows.Forms.RadioButton();
            this.radRockCom = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grbUser.SuspendLayout();
            this.grbCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUser
            // 
            this.grbUser.Controls.Add(this.radScissors);
            this.grbUser.Controls.Add(this.radPaper);
            this.grbUser.Controls.Add(this.radRock);
            this.grbUser.Location = new System.Drawing.Point(47, 140);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(200, 115);
            this.grbUser.TabIndex = 0;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "You";
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Location = new System.Drawing.Point(7, 68);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(64, 17);
            this.radScissors.TabIndex = 2;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(7, 44);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 1;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(7, 20);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 0;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            // 
            // grbCom
            // 
            this.grbCom.Controls.Add(this.radScissorsCom);
            this.grbCom.Controls.Add(this.radPaperCom);
            this.grbCom.Controls.Add(this.radRockCom);
            this.grbCom.Location = new System.Drawing.Point(47, 275);
            this.grbCom.Name = "grbCom";
            this.grbCom.Size = new System.Drawing.Size(200, 115);
            this.grbCom.TabIndex = 3;
            this.grbCom.TabStop = false;
            this.grbCom.Text = "Computer (Opponent)";
            // 
            // radScissorsCom
            // 
            this.radScissorsCom.AutoSize = true;
            this.radScissorsCom.Location = new System.Drawing.Point(7, 68);
            this.radScissorsCom.Name = "radScissorsCom";
            this.radScissorsCom.Size = new System.Drawing.Size(64, 17);
            this.radScissorsCom.TabIndex = 2;
            this.radScissorsCom.TabStop = true;
            this.radScissorsCom.Text = "Scissors";
            this.radScissorsCom.UseVisualStyleBackColor = true;
            // 
            // radPaperCom
            // 
            this.radPaperCom.AutoSize = true;
            this.radPaperCom.Location = new System.Drawing.Point(7, 43);
            this.radPaperCom.Name = "radPaperCom";
            this.radPaperCom.Size = new System.Drawing.Size(53, 17);
            this.radPaperCom.TabIndex = 1;
            this.radPaperCom.TabStop = true;
            this.radPaperCom.Text = "Paper";
            this.radPaperCom.UseVisualStyleBackColor = true;
            // 
            // radRockCom
            // 
            this.radRockCom.AutoSize = true;
            this.radRockCom.Location = new System.Drawing.Point(7, 20);
            this.radRockCom.Name = "radRockCom";
            this.radRockCom.Size = new System.Drawing.Size(51, 17);
            this.radRockCom.TabIndex = 0;
            this.radRockCom.TabStop = true;
            this.radRockCom.Text = "Rock";
            this.radRockCom.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RockPaperScissorsAlexF.Properties.Resources._43417431_you_lose_red_stamp_text_on_white;
            this.pictureBox1.Location = new System.Drawing.Point(330, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(236, 446);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(95, 45);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 544);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbCom);
            this.Controls.Add(this.grbUser);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock Paper Scissors Alex Forgeron";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.grbCom.ResumeLayout(false);
            this.grbCom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.GroupBox grbCom;
        private System.Windows.Forms.RadioButton radScissorsCom;
        private System.Windows.Forms.RadioButton radPaperCom;
        private System.Windows.Forms.RadioButton radRockCom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPlay;
    }
}

