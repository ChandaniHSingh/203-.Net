namespace Q10
{
    partial class frmQ10
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
            this.cmbNum = new System.Windows.Forms.ComboBox();
            this.txtLeastNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCmb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbNum
            // 
            this.cmbNum.FormattingEnabled = true;
            this.cmbNum.Items.AddRange(new object[] {
            "100"});
            this.cmbNum.Location = new System.Drawing.Point(228, 183);
            this.cmbNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbNum.Name = "cmbNum";
            this.cmbNum.Size = new System.Drawing.Size(132, 23);
            this.cmbNum.TabIndex = 4;
            // 
            // txtLeastNum
            // 
            this.txtLeastNum.Location = new System.Drawing.Point(228, 265);
            this.txtLeastNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLeastNum.Name = "txtLeastNum";
            this.txtLeastNum.ReadOnly = true;
            this.txtLeastNum.Size = new System.Drawing.Size(132, 21);
            this.txtLeastNum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Least Number : ";
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(228, 57);
            this.txtEnter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(132, 21);
            this.txtEnter.TabIndex = 1;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(111, 57);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(108, 15);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter Number : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(169, 115);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 27);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCmb
            // 
            this.lblCmb.AutoSize = true;
            this.lblCmb.Location = new System.Drawing.Point(111, 187);
            this.lblCmb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCmb.Name = "lblCmb";
            this.lblCmb.Size = new System.Drawing.Size(88, 15);
            this.lblCmb.TabIndex = 3;
            this.lblCmb.Text = "ComboBox : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Showing least number in ComboBox";
            // 
            // frmQ10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCmb);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLeastNum);
            this.Controls.Add(this.cmbNum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQ10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question-10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNum;
        private System.Windows.Forms.TextBox txtLeastNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCmb;
        private System.Windows.Forms.Label label2;
    }
}

