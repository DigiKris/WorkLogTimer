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

namespace WorkLogTimer
{
    public partial class FormLogWindow : Form
    {
        public FormLogWindow()
        {
            InitializeComponent();

            TextReader reader = new StreamReader(@"c:\temp\WorkLogTimerLogFile.txt");
            richTextBoxLog.Text = reader.ReadToEnd();
            reader.Close();
        }
    }
}
