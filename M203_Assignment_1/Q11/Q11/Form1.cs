using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q11
{
    public partial class frmQ11 : Form
    {
        public frmQ11()
        {
            InitializeComponent();
        }

        private void txtEnter_TextChanged(object sender, EventArgs e)
        {
            if (txtEnter.Text.Length > 3)
            {
                MessageBox.Show("Please Enter Number in 3 digit Only....\nExample:- 2 like 002 ,12 like 012,123 like 123 ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /*
            for (int i = 0; i < lstBox.Items.Count; i++)
            {
                for (int j = 0; j < (lstBox.Items.Count) - i - 1; j++)
                {
                    int a = Convert.ToInt32(lstBox.Items[j]);
                    int b = Convert.ToInt32(lstBox.Items[j + 1]);
                    if (a < b)
                    {
                        int temp = a;
                        a = b;
                        b = temp;
                    }
                }
            }
            */
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (Int32.TryParse(txtEnter.Text, out x))
            {
                if (txtEnter.Text.Length == 3)
                {
                    if (!lstBox.Items.Contains(txtEnter.Text))
                    {
                        lstBox.Items.Add(txtEnter.Text);
                    }
                    else
                    {
                        MessageBox.Show("Item is Already Exists in ListBox.. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (txtEnter.Text.Length > 3)
                {
                    MessageBox.Show("Please Enter Number in 3 digit Only....\nExample:- 2 like 002 ,12 like 012,123 like 123 ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Numbers Only..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            lstBox.Sorted = true;
        }
    }
}
