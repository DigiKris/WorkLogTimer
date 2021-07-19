using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WorkLogTimer
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }
        #region Start with windows
        private void checkBoxStartWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (checkBoxStartWithWindows.Checked)
                rk.SetValue("WorkLogTimer", Application.ExecutablePath);
            else
                rk.DeleteValue("WorkLogTimer", false);
        }
        #endregion

        #region Close to tray
        private void checkBoxMinimizeToTray_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            checkBoxStartWithWindows.Checked = Properties.Settings.Default.SettingStartWithWindows;
            checkBoxMinimizeToTray.Checked = Properties.Settings.Default.SettingMinimizeTotray;
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SettingStartWithWindows = checkBoxStartWithWindows.Checked;
            Properties.Settings.Default.SettingMinimizeTotray = checkBoxMinimizeToTray.Checked;
            Properties.Settings.Default.Save();
        }
        #endregion
    }
}
