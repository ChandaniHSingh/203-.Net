namespace Q6
{
    partial class frmQ6
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbDelete = new System.Windows.Forms.RadioButton();
            this.rdbAdd = new System.Windows.Forms.RadioButton();
            this.btnCmd = new System.Windows.Forms.Button();
            this.lstAns = new System.Windows.Forms.ListBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(16, 104);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(95, 15);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter String : ";
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(119, 100);
            this.txtEnter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(163, 21);
            this.txtEnter.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbDelete);
            this.panel1.Controls.Add(this.rdbAdd);
            this.panel1.Location = new System.Drawing.Point(119, 160);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 58);
            this.panel1.TabIndex = 2;
            // 
            // rdbDelete
            // 
            this.rdbDelete.AutoSize = true;
            this.rdbDelete.Location = new System.Drawing.Point(5, 31);
            this.rdbDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbDelete.Name = "rdbDelete";
            this.rdbDelete.Size = new System.Drawing.Size(67, 19);
            this.rdbDelete.TabIndex = 1;
            this.rdbDelete.TabStop = true;
            this.rdbDelete.Text = "Delete";
            this.rdbDelete.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            this.rdbAdd.AutoSize = true;
            this.rdbAdd.Location = new System.Drawing.Point(5, 5);
            this.rdbAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbAdd.Name = "rdbAdd";
            this.rdbAdd.Size = new System.Drawing.Size(49, 19);
            this.rdbAdd.TabIndex = 0;
            this.rdbAdd.TabStop = true;
            this.rdbAdd.Text = "Add";
            this.rdbAdd.UseVisualStyleBackColor = true;
            // 
            // btnCmd
            // 
            this.btnCmd.Location = new System.Drawing.Point(97, 241);
            this.btnCmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(100, 27);
            this.btnCmd.TabIndex = 3;
            this.btnCmd.Text = "Command";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnCmd_Click);
            // 
            // lstAns
            // 
            this.lstAns.FormattingEnabled = true;
            this.lstAns.ItemHeight = 15;
            this.lstAns.Location = new System.Drawing.Point(363, 74);
            this.lstAns.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstAns.Name = "lstAns";
            this.lstAns.Size = new System.Drawing.Size(159, 244);
            this.lstAns.TabIndex = 4;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(28, 160);
            this.lblOp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(82, 15);
            this.lblOp.TabIndex = 5;
            this.lblOp.Text = "Operation : ";
            // 
            // frmQ6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 388);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lstAns);
            this.Controls.Add(this.btnCmd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.lblEnter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQ6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question-6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbDelete;
        private System.Windows.Forms.RadioButton rdbAdd;
        private System.Windows.Forms.Button btnCmd;
        private System.Windows.Forms.ListBox lstAns;
        private System.Windows.Forms.Label lblOp;
    }
}

