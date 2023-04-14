using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccse
{
    public partial class links : Form
    {
        public links()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = "https://www.youtube.com/watch?v=bIC2l0ZzraY",
                UseShellExecute = true
            };
            Process.Start(psi);

        }
    }
}
