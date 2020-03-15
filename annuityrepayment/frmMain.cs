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
    public partial class frmMain : Form
    {
        public static double darlehn, year, tilgung, zinssatz, repayment;
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnCalcAndShow_Click(object sender, EventArgs e)
        {
            Calculate.calculate(Convert.ToDouble(txtTilgung.Text), Convert.ToDouble(txtZinssatz.Text), Convert.ToDouble(txtDarlehn.Text));
            frmShow frmShow = new frmShow();
            frmShow.Show();
        }
    }
}
