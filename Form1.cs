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
    public partial class Form1 : Form
    {
        private int totalSeconds;

        DateTime stopTime = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }
        #region Add to combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonWorkStop.Enabled = false;
            buttonWorkPause.Enabled = false;

            for (int i = 0; i < 60; i++)

            {

                comboBoxWorkHours.Items.Add(i.ToString());
                comboBoxWorkMinutes.Items.Add(i.ToString());
                comboBoxWorkSeconds.Items.Add(i.ToString());

            }

            comboBoxWorkHours.SelectedIndex = 00;
            comboBoxWorkMinutes.SelectedIndex = 00;
            comboBoxWorkSeconds.SelectedIndex = 00;

        }
        #endregion

        #region Buttons
        private void buttonWorkStart_Click(object sender, EventArgs e)
        {
            buttonWorkStart.Enabled = false;
            buttonWorkStop.Enabled = true;
            buttonWorkPause.Enabled = true;

            int hours = int.Parse(comboBoxWorkHours.SelectedItem.ToString());
            int minutes = int.Parse(comboBoxWorkMinutes.SelectedItem.ToString());
            int seconds = int.Parse(comboBoxWorkSeconds.SelectedItem.ToString());

            totalSeconds = (minutes * 60) + (hours * 3600) + seconds;

            timerWork.Enabled = true;
        }

        private void buttonWorkPause_Click(object sender, EventArgs e)
        {
            buttonWorkPause.Enabled = true;
            buttonWorkStart.Enabled = false;

            if (buttonWorkPause.Text == "Pause")
            {
                timerWork.Stop();
                buttonWorkPause.Text = "Resume";
                stopTime = DateTime.Now;
            }
            else
            {
                buttonWorkPause.Text = "Pause";
                
                timerWork.Start();
                timerWork.Enabled = true;
            }
        }

        private void buttonWorkStop_Click(object sender, EventArgs e)
        {
            totalSeconds = 0;

            buttonWorkStop.Enabled = false;
            buttonWorkStart.Enabled = true;
            timerWork.Enabled = false;
            buttonWorkPause.Enabled = false;

            int hours = totalSeconds / 3600;
            int minutes = totalSeconds / 60 % 60;
            int seconds = totalSeconds % 60;

            labelWorkCountdown.Text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');

            buttonWorkPause.Text = "Pause";
        }
        #endregion

        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                
                int hours = totalSeconds / 3600;
                int minutes = totalSeconds / 60 % 60;
                int seconds = totalSeconds % 60;
                
                labelWorkCountdown.Text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            }

            else
            {
                timerWork.Stop();

                System.Media.SystemSounds.Hand.Play();

                MessageBox.Show("Take a break!");

                Console.Beep();

                buttonWorkStart.Enabled = true;
            }
        }

        #endregion

        #region Test region

        #endregion

        
    }
}
