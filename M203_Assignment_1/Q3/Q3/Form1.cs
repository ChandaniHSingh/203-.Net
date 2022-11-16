using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class frmQ3 : Form
    {
        public frmQ3()
        {
            InitializeComponent();
            
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            if (txtEnter.Text == "")
            {
                MessageBox.Show("Please Enter any Input...then Click command Button to see effect..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtEnter.Text = txtEnter.Text.ToUpper();
                lblAns.Text = "TextBox Content Changed to Upper Case.";
            }
            
        }

        private void txtEnter_TextChanged(object sender, EventArgs e)
        {
            lblAns.Text = "";
        }
    }
}
