namespace ChocoBoxesJohnN
{
    partial class frmChocolateBoxes
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
            this.lblChocolateBox = new System.Windows.Forms.Label();
            this.txtChocolateBoxes = new System.Windows.Forms.TextBox();
            this.lblPrize = new System.Windows.Forms.Label();
            this.btnPrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChocolateBox
            // 
            this.lblChocolateBox.AutoSize = true;
            this.lblChocolateBox.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChocolateBox.Location = new System.Drawing.Point(12, 92);
            this.lblChocolateBox.Name = "lblChocolateBox";
            this.lblChocolateBox.Size = new System.Drawing.Size(318, 28);
            this.lblChocolateBox.TabIndex = 0;
            this.lblChocolateBox.Text = "How many Boxes have you sold";
            // 
            // txtChocolateBoxes
            // 
            this.txtChocolateBoxes.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChocolateBoxes.Location = new System.Drawing.Point(355, 89);
            this.txtChocolateBoxes.Name = "txtChocolateBoxes";
            this.txtChocolateBoxes.Size = new System.Drawing.Size(100, 36);
            this.txtChocolateBoxes.TabIndex = 1;
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.Location = new System.Drawing.Point(64, 284);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(92, 44);
            this.lblPrize.TabIndex = 2;
            this.lblPrize.Text = "Prize";
            // 
            // btnPrize
            // 
            this.btnPrize.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrize.Location = new System.Drawing.Point(215, 178);
            this.btnPrize.Name = "btnPrize";
            this.btnPrize.Size = new System.Drawing.Size(115, 34);
            this.btnPrize.TabIndex = 3;
            this.btnPrize.Text = "Get Prize";
            this.btnPrize.UseVisualStyleBackColor = true;
            this.btnPrize.Click += new System.EventHandler(this.btnPrize_Click);
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 391);
            this.Controls.Add(this.btnPrize);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.txtChocolateBoxes);
            this.Controls.Add(this.lblChocolateBox);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChocolateBox;
        private System.Windows.Forms.TextBox txtChocolateBoxes;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Button btnPrize;
    }
}

