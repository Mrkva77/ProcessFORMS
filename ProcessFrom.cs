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

namespace KlasaProcess1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            Process.Start("wordpad.exe");
        }

        private void buttonExel_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }

        private void buttonStartInfo_Click(object sender, EventArgs e)
        {
            // novi objekt klase ProcessStartInfo

            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");

            startInfo.WindowStyle = ProcessWindowStyle.Normal;

            // početna web adresa

            startInfo.Arguments = "www.sser.hr";

            // pokretanje Internet Explorer-a

            Process.Start(startInfo);
        }
    }
}
