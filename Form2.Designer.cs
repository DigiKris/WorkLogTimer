
namespace WorkLogTimer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBreakPause
            // 
            this.buttonBreakPause.Location = new System.Drawing.Point(98, 120);
            this.buttonBreakPause.Name = "buttonBreakPause";
            this.buttonBreakPause.Size = new System.Drawing.Size(75, 23);
            this.buttonBreakPause.TabIndex = 29;
            this.buttonBreakPause.Text = "Pause";
            this.buttonBreakPause.UseVisualStyleBackColor = true;
            // 
            // buttonBreakStop
            // 
            this.buttonBreakStop.Location = new System.Drawing.Point(178, 119);
            this.buttonBreakStop.Name = "buttonBreakStop";
            this.buttonBreakStop.Size = new System.Drawing.Size(75, 23);
            this.buttonBreakStop.TabIndex = 28;
            this.buttonBreakStop.Text = "Stop";
            this.buttonBreakStop.UseVisualStyleBackColor = true;
            // 
            // buttonBreakStart
            // 
            this.buttonBreakStart.Location = new System.Drawing.Point(18, 120);
            this.buttonBreakStart.Name = "buttonBreakStart";
            this.buttonBreakStart.Size = new System.Drawing.Size(75, 23);
            this.buttonBreakStart.TabIndex = 27;
            this.buttonBreakStart.Text = "Start break";
            this.buttonBreakStart.UseVisualStyleBackColor = true;
            // 
            // labelBreakCountdown
            // 
            this.labelBreakCountdown.AutoSize = true;
            this.labelBreakCountdown.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBreakCountdown.Location = new System.Drawing.Point(78, 80);
            this.labelBreakCountdown.Name = "labelBreakCountdown";
            this.labelBreakCountdown.Size = new System.Drawing.Size(119, 37);
            this.labelBreakCountdown.TabIndex = 26;
            this.labelBreakCountdown.Text = "00:00:00";
            // 
            // labelBreakSeconds
            // 
            this.labelBreakSeconds.AutoSize = true;
            this.labelBreakSeconds.Location = new System.Drawing.Point(175, 35);
            this.labelBreakSeconds.Name = "labelBreakSeconds";
            this.labelBreakSeconds.Size = new System.Drawing.Size(82, 15);
            this.labelBreakSeconds.TabIndex = 25;
            this.labelBreakSeconds.Text = "Break seconds";
            // 
            // comboBoxBreakSeconds
            // 
            this.comboBoxBreakSeconds.FormattingEnabled = true;
            this.comboBoxBreakSeconds.Location = new System.Drawing.Point(192, 53);
            this.comboBoxBreakSeconds.Name = "comboBoxBreakSeconds";
            this.comboBoxBreakSeconds.Size = new System.Drawing.Size(40, 23);
            this.comboBoxBreakSeconds.TabIndex = 24;
            // 
            // comboBoxBreakMinutes
            // 
            this.comboBoxBreakMinutes.FormattingEnabled = true;
            this.comboBoxBreakMinutes.Location = new System.Drawing.Point(109, 54);
            this.comboBoxBreakMinutes.Name = "comboBoxBreakMinutes";
            this.comboBoxBreakMinutes.Size = new System.Drawing.Size(40, 23);
            this.comboBoxBreakMinutes.TabIndex = 23;
            // 
            // labelBreakMinutes
            // 
            this.labelBreakMinutes.AutoSize = true;
            this.labelBreakMinutes.Location = new System.Drawing.Point(88, 35);
            this.labelBreakMinutes.Name = "labelBreakMinutes";
            this.labelBreakMinutes.Size = new System.Drawing.Size(82, 15);
            this.labelBreakMinutes.TabIndex = 22;
            this.labelBreakMinutes.Text = "Break minutes";
            // 
            // comboBoxBreakHours
            // 
            this.comboBoxBreakHours.FormattingEnabled = true;
            this.comboBoxBreakHours.Location = new System.Drawing.Point(27, 53);
            this.comboBoxBreakHours.Name = "comboBoxBreakHours";
            this.comboBoxBreakHours.Size = new System.Drawing.Size(39, 23);
            this.comboBoxBreakHours.TabIndex = 21;
            // 
            // labelBreakHours
            // 
            this.labelBreakHours.AutoSize = true;
            this.labelBreakHours.Location = new System.Drawing.Point(14, 35);
            this.labelBreakHours.Name = "labelBreakHours";
            this.labelBreakHours.Size = new System.Drawing.Size(69, 15);
            this.labelBreakHours.TabIndex = 20;
            this.labelBreakHours.Text = "Break hours";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(274, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.breakTimerToolStripMenuItem,
            this.workTimerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // breakTimerToolStripMenuItem
            // 
            this.breakTimerToolStripMenuItem.Name = "breakTimerToolStripMenuItem";
            this.breakTimerToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.breakTimerToolStripMenuItem.Text = "Break Timer";
            // 
            // workTimerToolStripMenuItem
            // 
            this.workTimerToolStripMenuItem.Name = "workTimerToolStripMenuItem";
            this.workTimerToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.workTimerToolStripMenuItem.Text = "Work Timer";
            this.workTimerToolStripMenuItem.Click += new System.EventHandler(this.workTimerToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(274, 162);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "WorkLogTimer";
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
    }
}