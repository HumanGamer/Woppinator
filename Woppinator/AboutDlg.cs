using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Woppinator
{
    public partial class AboutDlg : Form
    {
        public AboutDlg()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutDlg_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "v" + Application.ProductVersion;
        }
    }
}
