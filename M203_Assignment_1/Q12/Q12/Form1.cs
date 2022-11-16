using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q12
{
    public partial class frmQ12 : Form
    {
        public frmQ12()
        {
            InitializeComponent();
            txtEnter.ScrollBars = ScrollBars.Horizontal;
            txtEnter.WordWrap = false;
            txtEnter.Multiline = true;

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            txtValue.Text = hScrollBar1.Value.ToString();
        }
    }
}
