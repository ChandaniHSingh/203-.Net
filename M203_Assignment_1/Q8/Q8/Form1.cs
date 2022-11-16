using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q8
{
    public partial class frmQ8 : Form
    {
        public frmQ8()
        {
            InitializeComponent();
        }

        int N1, N2;

        private void rdbHCF_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbHCF.Checked == true)
            {
                if (!check_txt())
                {
                    MessageBox.Show("Please Enter Number-1 and Number-2 ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!check_num())
                {
                    MessageBox.Show("Please Enter Numbers Only.. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int temp, Num1 = N1, Num2 = N2;
                while (Num2 != 0)
                {
                    temp = Num2;
                    Num2 = Num1 % Num2;
                    Num1 = temp;
                }
                int GCD = Num1;
                int LCM = (N1 * N2) / GCD;
                lblAns.Text = GCD.ToString();
            }            
        }

        private void rdbLCM_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbLCM.Checked == true)
            {
                if (!check_txt())
                {
                    MessageBox.Show("Please Enter Number-1 and Number-2 ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!check_num())
                {
                    MessageBox.Show("Please Enter Numbers Only.. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int temp, Num1 = N1, Num2 = N2;
                while (Num2 != 0)
                {
                    temp = Num2;
                    Num2 = Num1 % Num2;
                    Num1 = temp;
                }
                int GCD = Num1;
                int LCM = (N1 * N2) / GCD;
                lblAns.Text = LCM.ToString();
            }            
        }


        private bool check_txt()
        {
            if (txtNum1.Text != "")
            {
                if (txtNum2.Text != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        private bool check_num()
        {
            int x = 0;
            if (Int32.TryParse(txtNum1.Text, out x))
            {
                N1 = Convert.ToInt32(txtNum1.Text);
                if (Int32.TryParse(txtNum2.Text, out x))
                {
                    N2 = Convert.ToInt32(txtNum2.Text);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            lblAns.Text = "";
            rdbLCM.Checked = false;
            rdbHCF.Checked = false;
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            lblAns.Text = "";
            rdbLCM.Checked = false;
            rdbHCF.Checked = false;
        }
        
    }
}
