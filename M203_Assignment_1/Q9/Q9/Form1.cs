using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q9
{
    public partial class frmQ9 : Form
    {
        public frmQ9()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            check_days();
        }

        private void check_days()
        {
            DateTime dt1, dt2;
            dt1 = Convert.ToDateTime(dtp1.Text);
            dt2 = Convert.ToDateTime(dpt2.Text);
            txtDayBetween.Text = (dt1 - dt2).TotalDays.ToString();
          //  MessageBox.Show("DaysBetween (Time1 - Time2) is "+ txtDayBetween.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            check_days();
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            check_days();
        }
       
    }
}
