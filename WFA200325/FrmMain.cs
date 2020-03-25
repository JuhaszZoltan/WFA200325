using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA200325
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.cficon;

            rbKV.CheckedChanged += RbNCbChecks;
            rbFcsoki.CheckedChanged += RbNCbChecks;
            rbTea.CheckedChanged += RbNCbChecks;
            cbCukor.CheckedChanged += RbNCbChecks;
            cbTej.CheckedChanged += RbNCbChecks;
            cbPohar.CheckedChanged += RbNCbChecks;
        }

        private void RbNCbChecks(object sender, EventArgs e)
        {
            int ar = 0;

            if (rbKV.Checked) ar = 80;
            if (rbFcsoki.Checked) ar = 120;
            if (rbTea.Checked)
            {
                cbTej.Checked = false;
                cbTej.Enabled = false;
                ar = 100;
            }
            else cbTej.Enabled = true;

            

            if (cbCukor.Checked) ar += 20;
            if (cbPohar.Checked) ar -= 10;
            if (cbTej.Checked) ar += 10;

            lblAr.Text = $"{ar} Ft";
        }

        private void btnKeszit_Click(object sender, EventArgs e)
        {
            if (!lblEgs.Visible)
            {
                lblEgs.Visible = true;
                btnKeszit.Enabled = false;
            }
        }
    }
}
