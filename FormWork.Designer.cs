
namespace WorkLogTimer
{
    partial class FormWork
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWork));
            this.labelWorkHours = new System.Windows.Forms.Label();
            this.comboBoxWorkHours = new System.Windows.Forms.ComboBox();
            this.labelWorkMinutes = new System.Windows.Forms.Label();
            this.comboBoxWorkMinutes = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkSeconds = new System.Windows.Forms.ComboBox();
            this.labelWorkSeconds = new System.Windows.Forms.Label();
            this.labelWorkCountdown = new System.Windows.Forms.Label();
            this.buttonWorkStart = new System.Windows.Forms.Button();
            this.buttonWorkStop = new System.Windows.Forms.Button();
            this.timerWork = new System.Windows.Forms.Timer(this.components);
            this.buttonWorkPause = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWorkHours
            // 
            this.labelWorkHours.AutoSize = true;
            this.labelWorkHours.Location = new System.Drawing.Point(47, 32);
            this.labelWorkHours.Name = "labelWorkHours";
            this.labelWorkHours.Size = new System.Drawing.Size(16, 15);
            this.labelWorkHours.TabIndex = 0;
            this.labelWorkHours.Text = "H";
            // 
            // comboBoxWorkHours
            // 
            this.comboBoxWorkHours.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxWorkHours.DropDownWidth = 35;
            this.comboBoxWorkHours.FormattingEnabled = true;
            this.comboBoxWorkHours.Location = new System.Drawing.Point(37, 50);
            this.comboBoxWorkHours.Name = "comboBoxWorkHours";
            this.comboBoxWorkHours.Size = new System.Drawing.Size(35, 23);
            this.comboBoxWorkHours.TabIndex = 1;
            // 
            // labelWorkMinutes
            // 
            this.labelWorkMinutes.AutoSize = true;
            this.labelWorkMinutes.BackColor = System.Drawing.Color.LightGray;
            this.labelWorkMinutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWorkMinutes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWorkMinutes.Location = new System.Drawing.Point(128, 32);
            this.labelWorkMinutes.Name = "labelWorkMinutes";
            this.labelWorkMinutes.Size = new System.Drawing.Size(18, 15);
            this.labelWorkMinutes.TabIndex = 2;
            this.labelWorkMinutes.Text = "M";
            // 
            // comboBoxWorkMinutes
            // 
            this.comboBoxWorkMinutes.DropDownWidth = 35;
            this.comboBoxWorkMinutes.FormattingEnabled = true;
            this.comboBoxWorkMinutes.Location = new System.Drawing.Point(119, 51);
            this.comboBoxWorkMinutes.Name = "comboBoxWorkMinutes";
            this.comboBoxWorkMinutes.Size = new System.Drawing.Size(35, 23);
            this.comboBoxWorkMinutes.TabIndex = 3;
            // 
            // comboBoxWorkSeconds
            // 
            this.comboBoxWorkSeconds.DropDownWidth = 35;
            this.comboBoxWorkSeconds.FormattingEnabled = true;
            this.comboBoxWorkSeconds.Location = new System.Drawing.Point(202, 50);
            this.comboBoxWorkSeconds.Name = "comboBoxWorkSeconds";
            this.comboBoxWorkSeconds.Size = new System.Drawing.Size(35, 23);
            this.comboBoxWorkSeconds.TabIndex = 4;
            // 
            // labelWorkSeconds
            // 
            this.labelWorkSeconds.AutoSize = true;
            this.labelWorkSeconds.Location = new System.Drawing.Point(212, 32);
            this.labelWorkSeconds.Name = "labelWorkSeconds";
            this.labelWorkSeconds.Size = new System.Drawing.Size(13, 15);
            this.labelWorkSeconds.TabIndex = 5;
            this.labelWorkSeconds.Text = "S";
            // 
            // labelWorkCountdown
            // 
            this.labelWorkCountdown.AutoSize = true;
            this.labelWorkCountdown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWorkCountdown.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWorkCountdown.Location = new System.Drawing.Point(77, 80);
            this.labelWorkCountdown.Name = "labelWorkCountdown";
            this.labelWorkCountdown.Size = new System.Drawing.Size(121, 39);
            this.labelWorkCountdown.TabIndex = 6;
            this.labelWorkCountdown.Text = "00:00:00";
            // 
            // buttonWorkStart
            // 
            this.buttonWorkStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkStart.Location = new System.Drawing.Point(19, 129);
            this.buttonWorkStart.Name = "buttonWorkStart";
            this.buttonWorkStart.Size = new System.Drawing.Size(75, 23);
            this.buttonWorkStart.TabIndex = 7;
            this.buttonWorkStart.Text = "Start";
            this.buttonWorkStart.UseVisualStyleBackColor = true;
            this.buttonWorkStart.Click += new System.EventHandler(this.buttonWorkStart_Click);
            // 
            // buttonWorkStop
            // 
            this.buttonWorkStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkStop.Location = new System.Drawing.Point(179, 129);
            this.buttonWorkStop.Name = "buttonWorkStop";
            this.buttonWorkStop.Size = new System.Drawing.Size(75, 23);
            this.buttonWorkStop.TabIndex = 8;
            this.buttonWorkStop.Text = "Stop";
            this.buttonWorkStop.UseVisualStyleBackColor = true;
            this.buttonWorkStop.Click += new System.EventHandler(this.buttonWorkStop_Click);
            // 
            // timerWork
            // 
            this.timerWork.Interval = 1000;
            this.timerWork.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonWorkPause
            // 
            this.buttonWorkPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkPause.Location = new System.Drawing.Point(99, 129);
            this.buttonWorkPause.Name = "buttonWorkPause";
            this.buttonWorkPause.Size = new System.Drawing.Size(75, 23);
            this.buttonWorkPause.TabIndex = 9;
            this.buttonWorkPause.Text = "Pause";
            this.buttonWorkPause.UseVisualStyleBackColor = true;
            this.buttonWorkPause.Click += new System.EventHandler(this.buttonWorkPause_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(274, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            this.breakTimerToolStripMenuItem.Name = "breakTimerToolStripMenuItem";
            this.breakTimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.breakTimerToolStripMenuItem.Text = "Break Timer";
            this.breakTimerToolStripMenuItem.Click += new System.EventHandler(this.breakTimerToolStripMenuItem_Click);
            // 
            // workTimerToolStripMenuItem
            // 
            this.workTimerToolStripMenuItem.Name = "workTimerToolStripMenuItem";
            this.workTimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.workTimerToolStripMenuItem.Text = "Work Timer";
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
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::WorkLogTimer.Properties.Resources.digitalents_logo_plain_copy;
            this.ClientSize = new System.Drawing.Size(274, 162);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonWorkPause);
            this.Controls.Add(this.buttonWorkStop);
            this.Controls.Add(this.buttonWorkStart);
            this.Controls.Add(this.labelWorkCountdown);
            this.Controls.Add(this.labelWorkSeconds);
            this.Controls.Add(this.comboBoxWorkSeconds);
            this.Controls.Add(this.comboBoxWorkMinutes);
            this.Controls.Add(this.labelWorkMinutes);
            this.Controls.Add(this.comboBoxWorkHours);
            this.Controls.Add(this.labelWorkHours);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkLogTimer Work";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWorkHours;
        private System.Windows.Forms.ComboBox comboBoxWorkHours;
        private System.Windows.Forms.Label labelWorkMinutes;
        private System.Windows.Forms.ComboBox comboBoxWorkMinutes;
        private System.Windows.Forms.ComboBox comboBoxWorkSeconds;
        private System.Windows.Forms.Label labelWorkSeconds;
        private System.Windows.Forms.Label labelWorkCountdown;
        private System.Windows.Forms.Button buttonWorkStart;
        private System.Windows.Forms.Button buttonWorkStop;
        private System.Windows.Forms.Timer timerWork;
        private System.Windows.Forms.Button buttonWorkPause;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
    }
}

