using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WorkLogTimer
{
    public partial class FormAboutMessageBox : Form
    {
        public FormAboutMessageBox()
        {
            InitializeComponent();
        }

        private void linkLabelDigiKris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/DigiKris") { UseShellExecute = true });
        }
    }
}
