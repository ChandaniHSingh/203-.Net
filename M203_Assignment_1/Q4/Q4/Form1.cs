using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class frmQ4 : Form
    {
        public frmQ4()
        {
            InitializeComponent();
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            if(txtEnter.Text == "")
            {
                MessageBox.Show("Please Enter String into TextBox..that Program can count number of Special Characters..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                String str = txtEnter.Text;
                int count = str.Count(c => !char.IsLetterOrDigit(c));
                lblAns.Text = "Number of Special Characters : " + count;
            }
            
        }

        private void txtEnter_TextChanged(object sender, EventArgs e)
        {
            lblAns.Text = "";
        }
    }
}
