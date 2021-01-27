using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyScoreboard
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void layersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnColorFirst_Click(object sender, EventArgs e)
        {
            clrDialog1.ShowDialog();
            btnColorFirst.BackColor = clrDialog1.Color;
        }

        private void btnColorSecond_Click(object sender, EventArgs e)
        {
            clrDialog1.ShowDialog();
            btnColorSecond.BackColor = clrDialog1.Color;
        }
    }
}
