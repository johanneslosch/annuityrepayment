using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace annuityrepayment
{
    public partial class frmTutorial : Form
    {
        public frmTutorial()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmInfo.ActiveForm.Close();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }
    }
}
