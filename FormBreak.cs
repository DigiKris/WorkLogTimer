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
    public partial class FormBreak : Form
    {
        private int totalSeconds;

        DateTime stopTime = DateTime.Now;
        public FormBreak()
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

        #region Buttons
        private void buttonBreakStart_Click(object sender, EventArgs e)
        {
            buttonBreakStart.Enabled = false;
            buttonBreakStop.Enabled = true;
            buttonBreakPause.Enabled = true;

            int hours = int.Parse(comboBoxBreakHours.SelectedItem.ToString());
            int minutes = int.Parse(comboBoxBreakMinutes.SelectedItem.ToString());
            int seconds = int.Parse(comboBoxBreakSeconds.SelectedItem.ToString());

            totalSeconds = (minutes * 60) + (hours * 3600) + seconds;

            timerBreak.Enabled = true;
        }

        private void buttonBreakPause_Click(object sender, EventArgs e)
        {
            buttonBreakPause.Enabled = true;
            buttonBreakStart.Enabled = false;

            if (buttonBreakPause.Text == "Pause")
            {
                timerBreak.Stop();
                buttonBreakPause.Text = "Resume";
                stopTime = DateTime.Now;
            }
            else
            {
                buttonBreakPause.Text = "Pause";

                timerBreak.Start();
                timerBreak.Enabled = true;
            }
        }

        private void buttonBreakStop_Click(object sender, EventArgs e)
        {
            totalSeconds = 0;

            buttonBreakStop.Enabled = false;
            buttonBreakStart.Enabled = true;
            timerBreak.Enabled = false;
            buttonBreakPause.Enabled = false;

            int hours = totalSeconds / 3600;
            int minutes = totalSeconds / 60 % 60;
            int seconds = totalSeconds % 60;

            labelBreakCountdown.Text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');

            buttonBreakPause.Text = "Pause";
        }
        #endregion

        #region Timer
        private void timerBreak_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;

                int hours = totalSeconds / 3600;
                int minutes = totalSeconds / 60 % 60;
                int seconds = totalSeconds % 60;

                labelBreakCountdown.Text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            }

            else
            {
                timerBreak.Stop();

                System.Media.SystemSounds.Hand.Play();

                var randomMessage = new Random();
                var messageList = new List<string> {"It always seems impossible until it is done.", "If you can dream it, you can do it.", 
                "Problems are not stop signs, they are guidelines.", "In order to succeed, we must first believe that we can.", 
                "The sercret of getting ahead is getting started.", "Either find a way, or make one.", "Act as if what you do makes a difference. It does.", 
                "Step by step and the thing is done.", "A will finds a way!", "There is a way to do it better, find it."};
                int index = randomMessage.Next(messageList.Count);

                string messageBoxTitle = "WorkLogTimer Time's up!";
                MessageBox.Show(messageList[index], messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Console.Beep();

                this.Hide();
                FormWork f1 = new FormWork();
                f1.ShowDialog();
                this.Close();

                buttonBreakStart.Enabled = true;
            }
        }
        #endregion

        #region Navigation
        private void workTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timerBreak.Enabled == true)
            {
                //https://www.c-sharpcorner.com/uploadfile/mahesh/understanding-message-box-in-windows-forms-using-C-Sharp/
                string messageBoxTitle = "WorkLogTimer";
                string messageBoxMessage = "Countdown is running, are you sure you wish to navigate ?";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(messageBoxMessage, messageBoxTitle, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    FormWork f1 = new FormWork();
                    f1.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                FormWork f1 = new FormWork();
                f1.ShowDialog();
                this.Close();
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutMessageBox f3 = new FormAboutMessageBox();
            f3.ShowDialog();
        }
        #endregion
    }
}
