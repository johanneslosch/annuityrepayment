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
            //Convertierung nicht möglich string -> double
            Calculate.calculate(Convert.ToDouble(txtTilgung.Text).ToString("0.00"), Convert.ToDouble(txtZinssatz.Text).ToString("0.00"), Convert.ToDouble(txtDarlehn.Text).ToString("0.00"));
            frmShow frmShow = new frmShow();
            frmShow.Show();
        }
    }
}
