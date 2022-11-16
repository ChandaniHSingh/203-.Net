using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q10
{
    public partial class frmQ10 : Form
    {
        public frmQ10()
        {
            InitializeComponent();
            sort_item();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtEnter.Text == "")
            {
                MessageBox.Show("Please First Enter Number into TextBox...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int x = 0;
                if (Int32.TryParse(txtEnter.Text, out x))
                {
                    cmbNum.Items.Add(txtEnter.Text);
                    sort_item();
                }
                else
                {
                    MessageBox.Show("Please Enter Numbers Only..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }               
            }
        }

        private void sort_item()
        {
            int min = Int32.MaxValue;
            foreach (object k in cmbNum.Items)
            {
                int i = Convert.ToInt32(k);
                if (i < min)
                {
                    min = i;
                }
            }
            txtLeastNum.Text = min.ToString();
        }
    }
}
