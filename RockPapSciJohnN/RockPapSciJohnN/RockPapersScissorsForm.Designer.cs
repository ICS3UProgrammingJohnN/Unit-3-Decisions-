namespace RockPapSciJohnN
{
    partial class frmRockPapersScissors
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
            this.radPlayerRock = new System.Windows.Forms.RadioButton();
            this.radPlayerPaper = new System.Windows.Forms.RadioButton();
            this.radPlayerScissors = new System.Windows.Forms.RadioButton();
            this.radComPaper = new System.Windows.Forms.RadioButton();
            this.radComRock = new System.Windows.Forms.RadioButton();
            this.radComScissors = new System.Windows.Forms.RadioButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grbComputerChoice = new System.Windows.Forms.GroupBox();
            this.grbPlayerChoice = new System.Windows.Forms.GroupBox();
            this.picComChoice = new System.Windows.Forms.PictureBox();
            this.picPlayerChoice = new System.Windows.Forms.PictureBox();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.grbComputerChoice.SuspendLayout();
            this.grbPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // radPlayerRock
            // 
            this.radPlayerRock.AutoSize = true;
            this.radPlayerRock.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPlayerRock.Location = new System.Drawing.Point(27, 24);
            this.radPlayerRock.Name = "radPlayerRock";
            this.radPlayerRock.Size = new System.Drawing.Size(80, 32);
            this.radPlayerRock.TabIndex = 0;
            this.radPlayerRock.TabStop = true;
            this.radPlayerRock.Text = "Rock";
            this.radPlayerRock.UseVisualStyleBackColor = true;
            // 
            // radPlayerPaper
            // 
            this.radPlayerPaper.AutoSize = true;
            this.radPlayerPaper.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPlayerPaper.Location = new System.Drawing.Point(188, 24);
            this.radPlayerPaper.Name = "radPlayerPaper";
            this.radPlayerPaper.Size = new System.Drawing.Size(85, 32);
            this.radPlayerPaper.TabIndex = 1;
            this.radPlayerPaper.TabStop = true;
            this.radPlayerPaper.Text = "Paper";
            this.radPlayerPaper.UseVisualStyleBackColor = true;
            // 
            // radPlayerScissors
            // 
            this.radPlayerScissors.AutoSize = true;
            this.radPlayerScissors.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPlayerScissors.Location = new System.Drawing.Point(355, 24);
            this.radPlayerScissors.Name = "radPlayerScissors";
            this.radPlayerScissors.Size = new System.Drawing.Size(107, 32);
            this.radPlayerScissors.TabIndex = 2;
            this.radPlayerScissors.TabStop = true;
            this.radPlayerScissors.Text = "Scissors";
            this.radPlayerScissors.UseVisualStyleBackColor = true;
            // 
            // radComPaper
            // 
            this.radComPaper.AutoSize = true;
            this.radComPaper.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radComPaper.Location = new System.Drawing.Point(200, 19);
            this.radComPaper.Name = "radComPaper";
            this.radComPaper.Size = new System.Drawing.Size(85, 32);
            this.radComPaper.TabIndex = 3;
            this.radComPaper.TabStop = true;
            this.radComPaper.Text = "Paper";
            this.radComPaper.UseVisualStyleBackColor = true;
            this.radComPaper.CheckedChanged += new System.EventHandler(this.radComPaper_CheckedChanged);
            // 
            // radComRock
            // 
            this.radComRock.AutoSize = true;
            this.radComRock.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radComRock.Location = new System.Drawing.Point(6, 19);
            this.radComRock.Name = "radComRock";
            this.radComRock.Size = new System.Drawing.Size(77, 32);
            this.radComRock.TabIndex = 4;
            this.radComRock.TabStop = true;
            this.radComRock.Text = "Rock";
            this.radComRock.UseVisualStyleBackColor = true;
            // 
            // radComScissors
            // 
            this.radComScissors.AutoSize = true;
            this.radComScissors.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radComScissors.Location = new System.Drawing.Point(89, 19);
            this.radComScissors.Name = "radComScissors";
            this.radComScissors.Size = new System.Drawing.Size(105, 32);
            this.radComScissors.TabIndex = 5;
            this.radComScissors.TabStop = true;
            this.radComScissors.Text = "Scissors";
            this.radComScissors.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(378, 370);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(68, 35);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // grbComputerChoice
            // 
            this.grbComputerChoice.Controls.Add(this.radComRock);
            this.grbComputerChoice.Controls.Add(this.radComPaper);
            this.grbComputerChoice.Controls.Add(this.radComScissors);
            this.grbComputerChoice.Location = new System.Drawing.Point(545, 12);
            this.grbComputerChoice.Name = "grbComputerChoice";
            this.grbComputerChoice.Size = new System.Drawing.Size(283, 61);
            this.grbComputerChoice.TabIndex = 7;
            this.grbComputerChoice.TabStop = false;
            this.grbComputerChoice.Text = "Computer";
            // 
            // grbPlayerChoice
            // 
            this.grbPlayerChoice.BackColor = System.Drawing.Color.FloralWhite;
            this.grbPlayerChoice.Controls.Add(this.radPlayerRock);
            this.grbPlayerChoice.Controls.Add(this.radPlayerPaper);
            this.grbPlayerChoice.Controls.Add(this.radPlayerScissors);
            this.grbPlayerChoice.Location = new System.Drawing.Point(190, 623);
            this.grbPlayerChoice.Name = "grbPlayerChoice";
            this.grbPlayerChoice.Size = new System.Drawing.Size(467, 71);
            this.grbPlayerChoice.TabIndex = 8;
            this.grbPlayerChoice.TabStop = false;
            this.grbPlayerChoice.Text = "Player";
            // 
            // picComChoice
            // 
            this.picComChoice.Image = global::RockPapSciJohnN.Properties.Resources.rock;
            this.picComChoice.Location = new System.Drawing.Point(521, 79);
            this.picComChoice.Name = "picComChoice";
            this.picComChoice.Size = new System.Drawing.Size(338, 335);
            this.picComChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picComChoice.TabIndex = 9;
            this.picComChoice.TabStop = false;
            // 
            // picPlayerChoice
            // 
            this.picPlayerChoice.Image = global::RockPapSciJohnN.Properties.Resources.rock;
            this.picPlayerChoice.Location = new System.Drawing.Point(12, 70);
            this.picPlayerChoice.Name = "picPlayerChoice";
            this.picPlayerChoice.Size = new System.Drawing.Size(319, 335);
            this.picPlayerChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerChoice.TabIndex = 10;
            this.picPlayerChoice.TabStop = false;
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.BackColor = System.Drawing.Color.White;
            this.lblOutcome.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(235, 468);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(248, 86);
            this.lblOutcome.TabIndex = 11;
            this.lblOutcome.Text = "Winner";
            this.lblOutcome.Click += new System.EventHandler(this.lblOutcome_Click);
            // 
            // frmRockPapersScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RockPapSciJohnN.Properties.Resources.water_wallpaper;
            this.ClientSize = new System.Drawing.Size(871, 706);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.picPlayerChoice);
            this.Controls.Add(this.picComChoice);
            this.Controls.Add(this.grbPlayerChoice);
            this.Controls.Add(this.grbComputerChoice);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmRockPapersScissors";
            this.Text = "Rock Paper Scissors Game";
            this.grbComputerChoice.ResumeLayout(false);
            this.grbComputerChoice.PerformLayout();
            this.grbPlayerChoice.ResumeLayout(false);
            this.grbPlayerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radPlayerRock;
        private System.Windows.Forms.RadioButton radPlayerPaper;
        private System.Windows.Forms.RadioButton radPlayerScissors;
        private System.Windows.Forms.RadioButton radComPaper;
        private System.Windows.Forms.RadioButton radComRock;
        private System.Windows.Forms.RadioButton radComScissors;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox grbComputerChoice;
        private System.Windows.Forms.GroupBox grbPlayerChoice;
        private System.Windows.Forms.PictureBox picComChoice;
        private System.Windows.Forms.PictureBox picPlayerChoice;
        private System.Windows.Forms.Label lblOutcome;
    }
}

