using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WorkLogTimer
{
    public partial class FormBreak : Form
    {
        private int totalSeconds;

        DateTime stopTime = DateTime.Now;

        //For writefile
        FileInfo logFile = new FileInfo("WorkLogTimerLogFile.txt");

        //For logfile timespan between button clicks
        private DateTime buttonStartClick;
        private DateTime buttonStopClick;
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

            //For file writing
            buttonStartClick = DateTime.Now;
            labelBreakCountdown.Text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            DateTime startTime = DateTime.Now;
            using (StreamWriter sw = logFile.AppendText())
            {

                sw.WriteLine("Break: " + startTime + " " + labelBreakCountdown.Text);
            }
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

            //For file writing
            DateTime pauseResumeTime = DateTime.Now;
            using (StreamWriter sw = logFile.AppendText())
            {
                sw.WriteLine("Break pause/resume: " + pauseResumeTime);
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

            //For writefile
            buttonStopClick = DateTime.Now;
            TimeSpan timespan = buttonStopClick - buttonStartClick;
            DateTime stopTime = DateTime.Now;
            using (StreamWriter sw = logFile.AppendText())
            {

                sw.WriteLine("Break stop: " + stopTime + " " + "Break time: " + timespan);
            }
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

                notifyIconBreak.Visible = false;

                Hide();
                FormWork f1 = new FormWork();
                f1.ShowDialog();

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
                    Hide();
                    FormWork f1 = new FormWork();
                    f1.ShowDialog();
                }
            }
            else
            {
                Hide();
                FormWork f1 = new FormWork();
                f1.ShowDialog();
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutMessageBox f3 = new FormAboutMessageBox();
            f3.ShowDialog();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings f5 = new FormSettings();
            f5.ShowDialog();
        }
        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogWindow f4 = new FormLogWindow();
            f4.ShowDialog();
        }
        //Exit application on File - Exit click
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        #region Close to tray
        private void FormBreak_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormSettings frm = new FormSettings();
            frm.checkBoxMinimizeToTray.Checked = Properties.Settings.Default.SettingMinimizeTotray;
            if (frm.checkBoxMinimizeToTray.CheckState == CheckState.Checked)
            {
                e.Cancel = true;
                Hide();
                notifyIconBreak.Visible = true;
                notifyIconBreak.ShowBalloonTip(1000);
            }
        }
        private void notifyIconBreak_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconBreak.Visible = false;
        }
        #endregion
    }
}
