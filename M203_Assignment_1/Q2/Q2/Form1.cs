using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class frmQ2 : Form
    {
        public frmQ2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String input = txtInput.Text;
            if(input == "")
            {
                MessageBox.Show("Please Enter Input in TextBox..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblAns.Text = "";
            }
            else
            {
                lstLeft.Items.Add(input);
                lblAns.Text = "Item Added to Left ListBox..";
            }
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            if(lstRight.Items.Count == 0)
            {
                MessageBox.Show("There is No Items in Right ListBox..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblAns.Text = "";
            }
            else
            {
                foreach (object s in lstRight.Items)
                {
                    if (!(s.Equals("")))
                    {
                        lstLeft.Items.Add(s.ToString());
                    }
                }
                lstRight.Items.Clear();
                lblAns.Text = "All Items Added from Right to Left ListBox..";
            }
            
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            if (lstLeft.Items.Count == 0)
            {
                MessageBox.Show("There is No Items in Left ListBox..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblAns.Text = "";
            }
            else
            {
                foreach (object s in lstLeft.Items)
                {
                    if (!(s.Equals("")))
                    {
                        lstRight.Items.Add(s.ToString());
                    }

                }
                lstLeft.Items.Clear();
                lblAns.Text = "All Items Added from Left to Right ListBox..";
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lstRight.Items.Count == 0)
            {
                MessageBox.Show("There is No Items in Right ListBox..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblAns.Text = "";
            }
            else
            {
                String s = lstRight.GetItemText(lstRight.SelectedItem);
                if (!(s.Equals("")))
                {
                    lstLeft.Items.Add(s);
                    lstRight.Items.Remove(s);
                    lblAns.Text = "Selected Item Added from Right to Left ListBox..";
                }
                else
                {
                    MessageBox.Show("There is No Slected Items in Right ListBox..Please Select Item from Right ListBox..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblAns.Text = "";
                }
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lstLeft.Items.Count == 0)
            {
                MessageBox.Show("There is No Items in Left ListBox..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblAns.Text = "";
            }
            else
            {
                String s = lstLeft.GetItemText(lstLeft.SelectedItem);
                if (!(s.Equals("")))
                {
                    lstRight.Items.Add(s);
                    lstLeft.Items.Remove(s);
                    lblAns.Text = "Selected Item Added from Left to Right ListBox..";
                }
                else
                {
                    MessageBox.Show("There is No Slected Items in Left ListBox..Please Select Item from Left ListBox..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblAns.Text = "";
                }
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblAns.Text = "";
        }
    }
}
