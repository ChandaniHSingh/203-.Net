namespace Q8
{
    partial class frmQ8
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.panOp = new System.Windows.Forms.Panel();
            this.rdbLCM = new System.Windows.Forms.RadioButton();
            this.rdbHCF = new System.Windows.Forms.RadioButton();
            this.lblOp = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.panOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(80, 57);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(121, 15);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Enter Number-1 : ";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(217, 57);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(153, 21);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // panOp
            // 
            this.panOp.Controls.Add(this.rdbLCM);
            this.panOp.Controls.Add(this.rdbHCF);
            this.panOp.Location = new System.Drawing.Point(217, 203);
            this.panOp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panOp.Name = "panOp";
            this.panOp.Size = new System.Drawing.Size(155, 58);
            this.panOp.TabIndex = 2;
            // 
            // rdbLCM
            // 
            this.rdbLCM.AutoSize = true;
            this.rdbLCM.Location = new System.Drawing.Point(5, 31);
            this.rdbLCM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbLCM.Name = "rdbLCM";
            this.rdbLCM.Size = new System.Drawing.Size(54, 19);
            this.rdbLCM.TabIndex = 6;
            this.rdbLCM.TabStop = true;
            this.rdbLCM.Text = "LCM";
            this.rdbLCM.UseVisualStyleBackColor = true;
            this.rdbLCM.CheckedChanged += new System.EventHandler(this.rdbLCM_CheckedChanged);
            // 
            // rdbHCF
            // 
            this.rdbHCF.AutoSize = true;
            this.rdbHCF.Location = new System.Drawing.Point(5, 5);
            this.rdbHCF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbHCF.Name = "rdbHCF";
            this.rdbHCF.Size = new System.Drawing.Size(52, 19);
            this.rdbHCF.TabIndex = 5;
            this.rdbHCF.TabStop = true;
            this.rdbHCF.Text = "HCF";
            this.rdbHCF.UseVisualStyleBackColor = true;
            this.rdbHCF.CheckedChanged += new System.EventHandler(this.rdbHCF_CheckedChanged);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(80, 203);
            this.lblOp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(126, 15);
            this.lblOp.TabIndex = 4;
            this.lblOp.Text = "Select Operation : ";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(93, 288);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(69, 15);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Answer  : ";
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(189, 288);
            this.lblAns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(0, 15);
            this.lblAns.TabIndex = 8;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(217, 113);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(153, 21);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(80, 113);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(121, 15);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Enter Number-2 : ";
            // 
            // frmQ8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 402);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.panOp);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQ8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question-8";
            this.panOp.ResumeLayout(false);
            this.panOp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Panel panOp;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.RadioButton rdbLCM;
        private System.Windows.Forms.RadioButton rdbHCF;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblNum2;
    }
}

