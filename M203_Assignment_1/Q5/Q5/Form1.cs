using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q5
{
    public partial class frmQ5 : Form
    {
        public frmQ5()
        {
            InitializeComponent();
        }

        private void txtEnter_TextChanged(object sender, EventArgs e)
        {
           // txtEnter.Text = txtEnter.Text.ToUpper();
            txtEnter.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
