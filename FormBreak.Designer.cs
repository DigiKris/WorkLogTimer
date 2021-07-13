
namespace WorkLogTimer
{
    partial class FormBreak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBreak));
            this.buttonBreakPause = new System.Windows.Forms.Button();
            this.buttonBreakStop = new System.Windows.Forms.Button();
            this.buttonBreakStart = new System.Windows.Forms.Button();
            this.labelBreakCountdown = new System.Windows.Forms.Label();
            this.labelBreakSeconds = new System.Windows.Forms.Label();
            this.comboBoxBreakSeconds = new System.Windows.Forms.ComboBox();
            this.comboBoxBreakMinutes = new System.Windows.Forms.ComboBox();
            this.labelBreakMinutes = new System.Windows.Forms.Label();
            this.comboBoxBreakHours = new System.Windows.Forms.ComboBox();
            this.labelBreakHours = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBreak = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBreakPause
            // 
            this.buttonBreakPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBreakPause.Location = new System.Drawing.Point(103, 128);
            this.buttonBreakPause.Name = "buttonBreakPause";
            this.buttonBreakPause.Size = new System.Drawing.Size(75, 23);
            this.buttonBreakPause.TabIndex = 29;
            this.buttonBreakPause.Text = "Pause";
            this.buttonBreakPause.UseVisualStyleBackColor = true;
            this.buttonBreakPause.Click += new System.EventHandler(this.buttonBreakPause_Click);
            // 
            // buttonBreakStop
            // 
            this.buttonBreakStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBreakStop.Location = new System.Drawing.Point(183, 128);
            this.buttonBreakStop.Name = "buttonBreakStop";
            this.buttonBreakStop.Size = new System.Drawing.Size(75, 23);
            this.buttonBreakStop.TabIndex = 28;
            this.buttonBreakStop.Text = "Stop";
            this.buttonBreakStop.UseVisualStyleBackColor = true;
            this.buttonBreakStop.Click += new System.EventHandler(this.buttonBreakStop_Click);
            // 
            // buttonBreakStart
            // 
            this.buttonBreakStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBreakStart.Location = new System.Drawing.Point(23, 128);
            this.buttonBreakStart.Name = "buttonBreakStart";
            this.buttonBreakStart.Size = new System.Drawing.Size(75, 23);
            this.buttonBreakStart.TabIndex = 27;
            this.buttonBreakStart.Text = "Start break";
            this.buttonBreakStart.UseVisualStyleBackColor = true;
            this.buttonBreakStart.Click += new System.EventHandler(this.buttonBreakStart_Click);
            // 
            // labelBreakCountdown
            // 
            this.labelBreakCountdown.AutoSize = true;
            this.labelBreakCountdown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBreakCountdown.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBreakCountdown.Location = new System.Drawing.Point(83, 81);
            this.labelBreakCountdown.Name = "labelBreakCountdown";
            this.labelBreakCountdown.Size = new System.Drawing.Size(121, 39);
            this.labelBreakCountdown.TabIndex = 26;
            this.labelBreakCountdown.Text = "00:00:00";
            // 
            // labelBreakSeconds
            // 
            this.labelBreakSeconds.AutoSize = true;
            this.labelBreakSeconds.Location = new System.Drawing.Point(217, 32);
            this.labelBreakSeconds.Name = "labelBreakSeconds";
            this.labelBreakSeconds.Size = new System.Drawing.Size(13, 15);
            this.labelBreakSeconds.TabIndex = 25;
            this.labelBreakSeconds.Text = "S";
            // 
            // comboBoxBreakSeconds
            // 
            this.comboBoxBreakSeconds.FormattingEnabled = true;
            this.comboBoxBreakSeconds.Location = new System.Drawing.Point(207, 50);
            this.comboBoxBreakSeconds.Name = "comboBoxBreakSeconds";
            this.comboBoxBreakSeconds.Size = new System.Drawing.Size(35, 23);
            this.comboBoxBreakSeconds.TabIndex = 24;
            // 
            // comboBoxBreakMinutes
            // 
            this.comboBoxBreakMinutes.FormattingEnabled = true;
            this.comboBoxBreakMinutes.Location = new System.Drawing.Point(124, 51);
            this.comboBoxBreakMinutes.Name = "comboBoxBreakMinutes";
            this.comboBoxBreakMinutes.Size = new System.Drawing.Size(35, 23);
            this.comboBoxBreakMinutes.TabIndex = 23;
            // 
            // labelBreakMinutes
            // 
            this.labelBreakMinutes.AutoSize = true;
            this.labelBreakMinutes.Location = new System.Drawing.Point(132, 32);
            this.labelBreakMinutes.Name = "labelBreakMinutes";
            this.labelBreakMinutes.Size = new System.Drawing.Size(18, 15);
            this.labelBreakMinutes.TabIndex = 22;
            this.labelBreakMinutes.Text = "M";
            // 
            // comboBoxBreakHours
            // 
            this.comboBoxBreakHours.FormattingEnabled = true;
            this.comboBoxBreakHours.Location = new System.Drawing.Point(42, 50);
            this.comboBoxBreakHours.Name = "comboBoxBreakHours";
            this.comboBoxBreakHours.Size = new System.Drawing.Size(35, 23);
            this.comboBoxBreakHours.TabIndex = 21;
            // 
            // labelBreakHours
            // 
            this.labelBreakHours.AutoSize = true;
            this.labelBreakHours.Location = new System.Drawing.Point(52, 32);
            this.labelBreakHours.Name = "labelBreakHours";
            this.labelBreakHours.Size = new System.Drawing.Size(16, 15);
            this.labelBreakHours.TabIndex = 20;
            this.labelBreakHours.Text = "H";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(279, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.breakTimerToolStripMenuItem,
            this.workTimerToolStripMenuItem,
            this.logToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // breakTimerToolStripMenuItem
            // 
            this.breakTimerToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.breakTimerToolStripMenuItem.Name = "breakTimerToolStripMenuItem";
            this.breakTimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.breakTimerToolStripMenuItem.Text = "Break Timer";
            // 
            // workTimerToolStripMenuItem
            // 
            this.workTimerToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.workTimerToolStripMenuItem.Name = "workTimerToolStripMenuItem";
            this.workTimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.workTimerToolStripMenuItem.Text = "Work Timer";
            this.workTimerToolStripMenuItem.Click += new System.EventHandler(this.workTimerToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timerBreak
            // 
            this.timerBreak.Interval = 1000;
            this.timerBreak.Tick += new System.EventHandler(this.timerBreak_Tick);
            // 
            // FormBreak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::WorkLogTimer.Properties.Resources.digitalents_logo_plain_copy;
            this.ClientSize = new System.Drawing.Size(279, 162);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonBreakPause);
            this.Controls.Add(this.buttonBreakStop);
            this.Controls.Add(this.buttonBreakStart);
            this.Controls.Add(this.labelBreakCountdown);
            this.Controls.Add(this.labelBreakSeconds);
            this.Controls.Add(this.comboBoxBreakSeconds);
            this.Controls.Add(this.comboBoxBreakMinutes);
            this.Controls.Add(this.labelBreakMinutes);
            this.Controls.Add(this.comboBoxBreakHours);
            this.Controls.Add(this.labelBreakHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBreak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkLogTimer Break";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBreakPause;
        private System.Windows.Forms.Button buttonBreakStop;
        private System.Windows.Forms.Button buttonBreakStart;
        private System.Windows.Forms.Label labelBreakCountdown;
        private System.Windows.Forms.Label labelBreakSeconds;
        private System.Windows.Forms.ComboBox comboBoxBreakSeconds;
        private System.Windows.Forms.ComboBox comboBoxBreakMinutes;
        private System.Windows.Forms.Label labelBreakMinutes;
        private System.Windows.Forms.ComboBox comboBoxBreakHours;
        private System.Windows.Forms.Label labelBreakHours;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workTimerToolStripMenuItem;
        private System.Windows.Forms.Timer timerBreak;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
    }
}