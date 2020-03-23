using System;
using System.IO;
using System.Windows.Forms;

namespace annuityrepayment
{
    public partial class frmShow : Form
    {
        public frmShow()
        {
            InitializeComponent();
            richTextBox1.Text = File.ReadAllText(@"./test1.txt");
            if (File.Exists(@"./test1.txt"))
            {
                File.Delete(@"./test1.txt");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}