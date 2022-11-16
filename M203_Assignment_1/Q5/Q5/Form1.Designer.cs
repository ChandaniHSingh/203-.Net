namespace Q5
{
    partial class frmQ5
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(45, 174);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(95, 15);
            this.lblEnter.TabIndex = 1;
            this.lblEnter.Text = "Enter String : ";
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(163, 171);
            this.txtEnter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtEnter.Size = new System.Drawing.Size(215, 21);
            this.txtEnter.TabIndex = 2;
            this.txtEnter.TextChanged += new System.EventHandler(this.txtEnter_TextChanged);
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDes.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblDes.Location = new System.Drawing.Point(113, 27);
            this.lblDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(185, 15);
            this.lblDes.TabIndex = 0;
            this.lblDes.Text = "Enter String in Textbox that ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(78, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "they will be displayed in UPPER-CASE ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(160, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "as you type.";
            // 
            // frmQ5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 308);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.lblEnter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQ5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question-5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

