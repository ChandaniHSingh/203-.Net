using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class frmQ1 : Form
    {
        public frmQ1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(txtNum.Text == "")
            {
                MessageBox.Show("Please Enter any Positive Number To Check.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblAns.Text = "";
            }
            else
            {
                int num = 0;
                if (check_num())
                {
                    num = Convert.ToInt32(txtNum.Text);
                }
                else
                {
                    MessageBox.Show("Please Enter any Positive Numbers Only..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                String op = cmbOp.Text;
                bool ans = true;
                if (op == "Prime")
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            ans = false;
                        }
                    }
                    if (ans == true)
                    {
                        lblAns.Text = "Prime Number";
                    }
                    else
                    {
                        lblAns.Text = "Not Prime Number";
                    }
                }
                else if (op == "Armstrong")
                {
                    int n1 = num;
                    int rem, sum = 0;
                    while (n1 > 0)
                    {
                        rem = n1 % 10;
                        sum = sum + (rem * rem * rem);
                        n1 = n1 / 10;
                    }
                    if (num == sum)
                    {
                        ans = true;
                    }
                    else
                    {
                        ans = false;
                    }
                    if (ans == true)
                    {
                        lblAns.Text = "Armstrong Number";
                    }
                    else
                    {
                        lblAns.Text = "Not Armstrong Number";
                    }
                }
                else if (op == "Palindrome")
                {
                    int n1 = num, n2 = 0;
                    int rem;
                    while (n1 > 0)
                    {
                        rem = n1 % 10;
                        n2 = (n2 * 10) + rem;
                        n1 = n1 / 10;
                    }
                    if (n2 == num)
                    {
                        ans = true;
                    }
                    else
                    {
                        ans = false;
                    }
                    if (ans == true)
                    {
                        lblAns.Text = "Palindorme Number";
                    }
                    else
                    {
                        lblAns.Text = "Not Palindorme Number";
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Any Operation.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblAns.Text = "";
                }
            }
            
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if(txtNum.Text == "")
            {
                lblAns.Text = "";
            }
        }

        private bool check_num()
        {

            int x = 0;
            if (Int32.TryParse(txtNum.Text, out x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
