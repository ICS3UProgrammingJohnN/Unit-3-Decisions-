namespace FactorialJohnN
{
    partial class frmFactorialDoWhile
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lstFactorialNumbers = new System.Windows.Forms.ListBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblTextbox = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblFactoralAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(160, 52);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // lstFactorialNumbers
            // 
            this.lstFactorialNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFactorialNumbers.FormattingEnabled = true;
            this.lstFactorialNumbers.ItemHeight = 25;
            this.lstFactorialNumbers.Location = new System.Drawing.Point(12, 239);
            this.lstFactorialNumbers.MultiColumn = true;
            this.lstFactorialNumbers.Name = "lstFactorialNumbers";
            this.lstFactorialNumbers.Size = new System.Drawing.Size(281, 154);
            this.lstFactorialNumbers.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(12, 46);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(142, 26);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Enter a number";
            // 
            // lblTextbox
            // 
            this.lblTextbox.AutoSize = true;
            this.lblTextbox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextbox.Location = new System.Drawing.Point(29, 184);
            this.lblTextbox.Name = "lblTextbox";
            this.lblTextbox.Size = new System.Drawing.Size(231, 52);
            this.lblTextbox.TabIndex = 3;
            this.lblTextbox.Text = "Muiltiply all the following \r\n      numbers together";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(106, 111);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(79, 32);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblFactoralAnswer
            // 
            this.lblFactoralAnswer.AutoSize = true;
            this.lblFactoralAnswer.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactoralAnswer.Location = new System.Drawing.Point(12, 418);
            this.lblFactoralAnswer.Name = "lblFactoralAnswer";
            this.lblFactoralAnswer.Size = new System.Drawing.Size(172, 28);
            this.lblFactoralAnswer.TabIndex = 5;
            this.lblFactoralAnswer.Text = "Factorial Answer";
            // 
            // frmFactorialDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 455);
            this.Controls.Add(this.lblFactoralAnswer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTextbox);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lstFactorialNumbers);
            this.Controls.Add(this.txtNumber);
            this.Name = "frmFactorialDoWhile";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ListBox lstFactorialNumbers;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblTextbox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblFactoralAnswer;
    }
}

