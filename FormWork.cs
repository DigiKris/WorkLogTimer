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
    public partial class FormWork : Form
    {
        private int totalSeconds;
        
        DateTime stopTime = DateTime.Now;

        //For logfile timespan between button clicks
        private DateTime buttonStartClick;
        private DateTime buttonStopClick;
        public FormWork()
        {
            InitializeComponent();
        }
        #region Add to combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonWorkStop.Enabled = false;
            buttonWorkPause.Enabled = false;

            for (int i = 0; i < 61; i++)
            {   
                comboBoxWorkMinutes.Items.Add(i.ToString());
                comboBoxWorkSeconds.Items.Add(i.ToString());
            }
            for (int i = 0; i < 5; i++)
            {
                comboBoxWorkHours.Items.Add(i.ToString());
            }
            comboBoxWorkHours.SelectedIndex = 2;
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

            //For file writing
            FileInfo logFile = new FileInfo(@"c:\temp\WorkLogTimerLogFile.txt");
            logFile.Directory.Create();
            //String fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WorkLogTimerLog.txt");
            //string fileName = System.IO.Path.Combine(Environment.SpecialFolder.MyDocuments.ToString(), "userinfo.txt");
            buttonStartClick = DateTime.Now;
            labelWorkCountdown.Text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            DateTime startTime = DateTime.Now;
            using (StreamWriter sw = logFile.AppendText())
            {
                sw.WriteLine("Work: " + startTime + " " + labelWorkCountdown.Text);
            }
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

            //For file writing
            FileInfo logFile = new FileInfo(@"c:\temp\WorkLogTimerLogFile.txt");
            logFile.Directory.Create();
            DateTime pauseResumeTime = DateTime.Now;
            using (StreamWriter sw = logFile.AppendText())
            {
                sw.WriteLine("Work pause/resume: " + pauseResumeTime);
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

            //For writefile
            FileInfo logFile = new FileInfo(@"c:\temp\WorkLogTimerLogFile.txt");
            logFile.Directory.Create();
            buttonStopClick = DateTime.Now;
            TimeSpan timespan = buttonStopClick - buttonStartClick;
            DateTime stopTime = DateTime.Now;
            using (StreamWriter sw = logFile.AppendText())
            {
                
                sw.WriteLine("Work stop: " + stopTime + " " + "Work time: " + timespan);
            }
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
                
                var randomMessage = new Random();
                var messageList = new List<string> {"Take a break!", "Meditate", "Relax!", "Get some fresh air.", 
                    "Nature does not hurry, yet everything is accomplished.", "Empty your mind.", "Relax! Life is beautiful!", "Go for a walk!", 
                "Time out!", "Time for a break!", "Either move or be moved."};
                int index = randomMessage.Next(messageList.Count);
                
                string messageBoxTitle = "WorkLogTimer Time's up!";
                MessageBox.Show(messageList[index], messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
                Console.Beep();
                
                notifyIconWork.Visible = false;

                FormBreak formBreak = new FormBreak();
                formBreak.Show();
                WindowState = FormWindowState.Normal;

                buttonWorkStart.Enabled = true;
            }
        }
        #endregion

        #region Navigation
        private void breakTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timerWork.Enabled == true)
            {
                //https://www.c-sharpcorner.com/uploadfile/mahesh/understanding-message-box-in-windows-forms-using-C-Sharp/
                string messageBoxTitle = "WorkLogTimer";
                string messageBoxMessage = "Countdown is running, are you sure you wish to navigate ?";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(messageBoxMessage, messageBoxTitle, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    Hide();
                    FormBreak f2 = new FormBreak();
                    f2.ShowDialog();
                }
            }
            else
            {
                Hide();
                FormBreak f2 = new FormBreak();
                f2.ShowDialog();
            } 
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutMessageBox f3 = new FormAboutMessageBox();
            f3.ShowDialog();

            /*string messageBoxTitle = "WorkLogTimer About";
            string messageBoxMessage = " Digitalents Helsinki \n\r WorkLogTimer by DigiKris";
            MessageBox.Show(messageBoxMessage, messageBoxTitle);*/
        }
        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogWindow f4 = new FormLogWindow();
            f4.ShowDialog();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings f5 = new FormSettings();
            f5.ShowDialog();
        }
        //Exit application on File - Exit click
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        #region Close to tray
        private void FormWork_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            /*if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }*/
        }
        //Minimize to system tray on close
        private void FormWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormSettings frm = new FormSettings();
            frm.checkBoxMinimizeToTray.Checked = Properties.Settings.Default.SettingMinimizeTotray;
            if (frm.checkBoxMinimizeToTray.CheckState == CheckState.Checked)
            {
                e.Cancel = true;
                Hide();
                notifyIconWork.Visible = true;
                notifyIconWork.ShowBalloonTip(1000);
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconWork.Visible = false;
        }
        //ContextMenu system tray icon right click exit
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
    }
}
