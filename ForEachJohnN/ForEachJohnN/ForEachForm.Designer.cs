namespace ForEachJohnN
{
    partial class frmForEach
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
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.lblChangeColor = new System.Windows.Forms.Label();
            this.grbGroupBox = new System.Windows.Forms.GroupBox();
            this.lblText = new System.Windows.Forms.Label();
            this.grbGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColor.Location = new System.Drawing.Point(96, 40);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(85, 64);
            this.btnChangeColor.TabIndex = 0;
            this.btnChangeColor.Text = "Change\r\n Color";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // lblChangeColor
            // 
            this.lblChangeColor.AutoSize = true;
            this.lblChangeColor.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeColor.Location = new System.Drawing.Point(65, 156);
            this.lblChangeColor.Name = "lblChangeColor";
            this.lblChangeColor.Size = new System.Drawing.Size(144, 28);
            this.lblChangeColor.TabIndex = 1;
            this.lblChangeColor.Text = "Change Color";
            this.lblChangeColor.Click += new System.EventHandler(this.lblChangeColor_Click);
            // 
            // grbGroupBox
            // 
            this.grbGroupBox.Controls.Add(this.lblText);
            this.grbGroupBox.Location = new System.Drawing.Point(96, 206);
            this.grbGroupBox.Name = "grbGroupBox";
            this.grbGroupBox.Size = new System.Drawing.Size(85, 43);
            this.grbGroupBox.TabIndex = 2;
            this.grbGroupBox.TabStop = false;
            this.grbGroupBox.Text = "GroupBox";
            this.grbGroupBox.Enter += new System.EventHandler(this.grbGroupBox_Enter);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(20, 16);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Text";
            // 
            // frmForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grbGroupBox);
            this.Controls.Add(this.lblChangeColor);
            this.Controls.Add(this.btnChangeColor);
            this.Name = "frmForEach";
            this.Text = "For Each";
            this.grbGroupBox.ResumeLayout(false);
            this.grbGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Label lblChangeColor;
        private System.Windows.Forms.GroupBox grbGroupBox;
        private System.Windows.Forms.Label lblText;
    }
}

