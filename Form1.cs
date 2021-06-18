﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.buttonWorkStop.Enabled = false;



            for (int i = 0; i < 60; i++)

            {

                this.comboBoxWorkHours.Items.Add(i.ToString());

                this.comboBoxWorkMinutes.Items.Add(i.ToString());

                this.comboBoxWorkSeconds.Items.Add(i.ToString());

            }

            this.comboBoxWorkHours.SelectedIndex = 00;

            this.comboBoxWorkMinutes.SelectedIndex = 00;

            this.comboBoxWorkSeconds.SelectedIndex = 00;

        }

        private void buttonWorkStart_Click(object sender, EventArgs e)
        {
            this.buttonWorkStart.Enabled = false;

            this.buttonWorkStop.Enabled = true;



            int hours = int.Parse(this.comboBoxWorkHours.SelectedItem.ToString());

            int minutes = int.Parse(this.comboBoxWorkMinutes.SelectedItem.ToString());

            int seconds = int.Parse(this.comboBoxWorkSeconds.SelectedItem.ToString());

            totalSeconds = (minutes * 60) + (hours * 3600) + seconds;

            this.timerWork.Enabled = true;
        }

        private void buttonWorkStop_Click(object sender, EventArgs e)
        {
            totalSeconds = 0;

            this.buttonWorkStop.Enabled = false;

            this.buttonWorkStart.Enabled = true;

            this.timerWork.Enabled = false;

            int hours = totalSeconds / 3600;

            int minutes = totalSeconds / 60;

            int seconds = totalSeconds - (minutes * 60);

            this.labelWorkCountdown.Text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)

            {

                totalSeconds--;

                int hours = totalSeconds / 3600;

                int minutes = totalSeconds / 60;

                int seconds = totalSeconds - (minutes * 60);

                this.labelWorkCountdown.Text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');

            }

            else

            {

                this.timerWork.Stop();

                System.Media.SystemSounds.Hand.Play();

                MessageBox.Show("Take a break!");

                Console.Beep();

            }
        }
    }
}