using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q7
{
    public partial class frmQ7 : Form
    {
        String str;
        public frmQ7()
        {
            InitializeComponent();
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            if(txtEnter.Text == "")
            {
                MessageBox.Show("Please Enter Something into TextBox...Then Click Command Button to Blink Text..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               // lblAns.Text = txtEnter.Text;
                str = txtEnter.Text;
                timer1.Enabled = true;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // lblAns.Visible = !lblAns.Visible;
            if (txtEnter.Text == "")
            {
                txtEnter.Text = str;
            }
            else
            {
                txtEnter.Text = "";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                MessageBox.Show("Blinking is not Started yet..Please enter Command Button to Start Blinking Text..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                timer1.Enabled = false;
                txtEnter.Text = str;
              //  lblAns.Text = str;
            }
        }
    }
}
