using System;
using System.Windows.Forms;

namespace annuityrepayment
{
    public partial class frmMain : Form
    {
        public static double darlehn, year, tilgung, zinssatz, repayment;

        private void Button2_Click(object sender, EventArgs e)
        {
            frmTutorial frmTutorial = new frmTutorial();
            frmTutorial.Show();
            Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmInfo frmInfo = new frmInfo();
            frmInfo.Show();
            Hide();
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnCalcAndShow_Click(object sender, EventArgs e)
        {
            //Convertierung nicht möglich string -> double
            Calculate.calculate(Convert.ToDouble(txtTilgung.Text)/100, Convert.ToDouble(txtZinssatz.Text) / 100, Convert.ToDouble(txtDarlehn.Text));
            frmShow frmShow = new frmShow();
            frmShow.Show();
            Hide();
        }
    }
}
