namespace SumOfNumJohnN
{
    partial class frmSumOfNum
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstSumNumbers = new System.Windows.Forms.ListBox();
            this.lblSumAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(12, 46);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(164, 26);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter the number:";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(182, 52);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(100, 20);
            this.txtSum.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(110, 101);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(66, 30);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstSumNumbers
            // 
            this.lstSumNumbers.FormattingEnabled = true;
            this.lstSumNumbers.Location = new System.Drawing.Point(12, 155);
            this.lstSumNumbers.Name = "lstSumNumbers";
            this.lstSumNumbers.Size = new System.Drawing.Size(287, 173);
            this.lstSumNumbers.TabIndex = 3;
            // 
            // lblSumAnswer
            // 
            this.lblSumAnswer.AutoSize = true;
            this.lblSumAnswer.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumAnswer.Location = new System.Drawing.Point(109, 362);
            this.lblSumAnswer.Name = "lblSumAnswer";
            this.lblSumAnswer.Size = new System.Drawing.Size(57, 28);
            this.lblSumAnswer.TabIndex = 4;
            this.lblSumAnswer.Text = "Sum";
            // 
            // frmSumOfNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 408);
            this.Controls.Add(this.lblSumAnswer);
            this.Controls.Add(this.lstSumNumbers);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmSumOfNum";
            this.Text = "Sum Of Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstSumNumbers;
        private System.Windows.Forms.Label lblSumAnswer;
    }
}

