using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaroWinkler
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            JaroWinklerDistance jw = new JaroWinklerDistance();
            jw.Threshold = 0.7f;
            float ans = jw.GetDistance(txtInput.Text, txtCurrentValue.Text);
            float formattedPercent = ans * 100;
            double formattedAns = Math.Round(formattedPercent, 2);
            lblScore.Text = formattedAns.ToString() + "%";

        }
    }
}
