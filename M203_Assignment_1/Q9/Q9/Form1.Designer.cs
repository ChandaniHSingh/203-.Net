namespace Q9
{
    partial class frmQ9
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
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.lblDT1 = new System.Windows.Forms.Label();
            this.lblDT2 = new System.Windows.Forms.Label();
            this.dpt2 = new System.Windows.Forms.DateTimePicker();
            this.txtDayBetween = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(179, 65);
            this.dtp1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(265, 21);
            this.dtp1.TabIndex = 0;
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // lblDT1
            // 
            this.lblDT1.AutoSize = true;
            this.lblDT1.Location = new System.Drawing.Point(51, 72);
            this.lblDT1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDT1.Name = "lblDT1";
            this.lblDT1.Size = new System.Drawing.Size(99, 15);
            this.lblDT1.TabIndex = 1;
            this.lblDT1.Text = "Date-Time-1 : ";
            // 
            // lblDT2
            // 
            this.lblDT2.AutoSize = true;
            this.lblDT2.Location = new System.Drawing.Point(51, 122);
            this.lblDT2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDT2.Name = "lblDT2";
            this.lblDT2.Size = new System.Drawing.Size(99, 15);
            this.lblDT2.TabIndex = 3;
            this.lblDT2.Text = "Date-Time-2 : ";
            // 
            // dpt2
            // 
            this.dpt2.Location = new System.Drawing.Point(179, 115);
            this.dpt2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dpt2.Name = "dpt2";
            this.dpt2.Size = new System.Drawing.Size(265, 21);
            this.dpt2.TabIndex = 2;
            this.dpt2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // txtDayBetween
            // 
            this.txtDayBetween.Location = new System.Drawing.Point(164, 290);
            this.txtDayBetween.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDayBetween.Name = "txtDayBetween";
            this.txtDayBetween.ReadOnly = true;
            this.txtDayBetween.Size = new System.Drawing.Size(136, 21);
            this.txtDayBetween.TabIndex = 4;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(109, 250);
            this.lblAns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(273, 15);
            this.lblAns.TabIndex = 5;
            this.lblAns.Text = "Days-Between (DateTime1 - DateTime2): ";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(179, 192);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 27);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmQ9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 378);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.txtDayBetween);
            this.Controls.Add(this.lblDT2);
            this.Controls.Add(this.dpt2);
            this.Controls.Add(this.lblDT1);
            this.Controls.Add(this.dtp1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQ9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question-9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label lblDT1;
        private System.Windows.Forms.Label lblDT2;
        private System.Windows.Forms.DateTimePicker dpt2;
        private System.Windows.Forms.TextBox txtDayBetween;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Button btnCheck;
    }
}

