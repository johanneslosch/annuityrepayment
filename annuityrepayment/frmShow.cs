using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace annuityrepayment
{
    public partial class frmShow : Form
    {
        public frmShow()
        {
            InitializeComponent();
            richTextBox1.Text = File.ReadAllText(@"../../test1.txt");
            if (File.Exists(@"../../test1.txt"))
            {
                File.Delete(@"../../test1.txt");
            }
        }
    }
}
