using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q6
{
    public partial class frmQ6 : Form
    {
        public frmQ6()
        {
            InitializeComponent();
        }

        private void btnCmd_Click(object sender, EventArgs e)
        {
            if(txtEnter.Text == "")
            {
                MessageBox.Show("Please Enter any String to Perform Operation on it..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String s = txtEnter.Text;
                if (rdbAdd.Checked == true)
                {
                    if (!lstAns.Items.Contains(s))
                    {
                        lstAns.Items.Add(s);
                    }
                    else
                    {
                        MessageBox.Show("Entered Item is Already Exists in ListBox...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rdbDelete.Checked == true)
                {
                    if (!lstAns.Items.Contains(s))
                    {
                        MessageBox.Show("Entered Item is Not Exists in ListBox...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        lstAns.Items.Remove(s);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Any one Operation to perform..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } 
        }
        
    }
}
