using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkLogTimer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        #region Add to combobox
        private void Form2_Load(object sender, EventArgs e)
        {
            buttonBreakStop.Enabled = false;
            buttonBreakPause.Enabled = false;

            for (int i = 0; i < 61; i++)
            { 
                comboBoxBreakMinutes.Items.Add(i.ToString());
                comboBoxBreakSeconds.Items.Add(i.ToString());
            }
            for (int i = 0; i < 3; i++)
            {
                comboBoxBreakHours.Items.Add(i.ToString());
            }
            comboBoxBreakHours.SelectedIndex = 00;
            comboBoxBreakMinutes.SelectedIndex = 15;
            comboBoxBreakSeconds.SelectedIndex = 00;
        }
        #endregion

        #region Navigation
        private void workTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
        #endregion       
    }
}
