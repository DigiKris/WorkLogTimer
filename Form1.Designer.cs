
namespace WorkLogTimer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.SuspendLayout();
            // 
            // labelWorkHours
            // 
            this.labelWorkHours.AutoSize = true;
            this.labelWorkHours.Location = new System.Drawing.Point(13, 13);
            this.labelWorkHours.Name = "labelWorkHours";
            this.labelWorkHours.Size = new System.Drawing.Size(68, 15);
            this.labelWorkHours.TabIndex = 0;
            this.labelWorkHours.Text = "Work hours";
            // 
            // comboBoxWorkHours
            // 
            this.comboBoxWorkHours.FormattingEnabled = true;
            this.comboBoxWorkHours.Location = new System.Drawing.Point(26, 31);
            this.comboBoxWorkHours.Name = "comboBoxWorkHours";
            this.comboBoxWorkHours.Size = new System.Drawing.Size(39, 23);
            this.comboBoxWorkHours.TabIndex = 1;
            // 
            // labelWorkMinutes
            // 
            this.labelWorkMinutes.AutoSize = true;
            this.labelWorkMinutes.Location = new System.Drawing.Point(87, 13);
            this.labelWorkMinutes.Name = "labelWorkMinutes";
            this.labelWorkMinutes.Size = new System.Drawing.Size(81, 15);
            this.labelWorkMinutes.TabIndex = 2;
            this.labelWorkMinutes.Text = "Work minutes";
            // 
            // comboBoxWorkMinutes
            // 
            this.comboBoxWorkMinutes.FormattingEnabled = true;
            this.comboBoxWorkMinutes.Location = new System.Drawing.Point(108, 32);
            this.comboBoxWorkMinutes.Name = "comboBoxWorkMinutes";
            this.comboBoxWorkMinutes.Size = new System.Drawing.Size(40, 23);
            this.comboBoxWorkMinutes.TabIndex = 3;
            // 
            // comboBoxWorkSeconds
            // 
            this.comboBoxWorkSeconds.FormattingEnabled = true;
            this.comboBoxWorkSeconds.Location = new System.Drawing.Point(191, 31);
            this.comboBoxWorkSeconds.Name = "comboBoxWorkSeconds";
            this.comboBoxWorkSeconds.Size = new System.Drawing.Size(40, 23);
            this.comboBoxWorkSeconds.TabIndex = 4;
            // 
            // labelWorkSeconds
            // 
            this.labelWorkSeconds.AutoSize = true;
            this.labelWorkSeconds.Location = new System.Drawing.Point(174, 13);
            this.labelWorkSeconds.Name = "labelWorkSeconds";
            this.labelWorkSeconds.Size = new System.Drawing.Size(81, 15);
            this.labelWorkSeconds.TabIndex = 5;
            this.labelWorkSeconds.Text = "Work seconds";
            // 
            // labelWorkCountdown
            // 
            this.labelWorkCountdown.AutoSize = true;
            this.labelWorkCountdown.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWorkCountdown.Location = new System.Drawing.Point(68, 58);
            this.labelWorkCountdown.Name = "labelWorkCountdown";
            this.labelWorkCountdown.Size = new System.Drawing.Size(119, 37);
            this.labelWorkCountdown.TabIndex = 6;
            this.labelWorkCountdown.Text = "00:00:00";
            // 
            // buttonWorkStart
            // 
            this.buttonWorkStart.Location = new System.Drawing.Point(51, 98);
            this.buttonWorkStart.Name = "buttonWorkStart";
            this.buttonWorkStart.Size = new System.Drawing.Size(75, 23);
            this.buttonWorkStart.TabIndex = 7;
            this.buttonWorkStart.Text = "Start";
            this.buttonWorkStart.UseVisualStyleBackColor = true;
            this.buttonWorkStart.Click += new System.EventHandler(this.buttonWorkStart_Click);
            // 
            // buttonWorkStop
            // 
            this.buttonWorkStop.Location = new System.Drawing.Point(133, 97);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(274, 161);
            this.Controls.Add(this.buttonWorkStop);
            this.Controls.Add(this.buttonWorkStart);
            this.Controls.Add(this.labelWorkCountdown);
            this.Controls.Add(this.labelWorkSeconds);
            this.Controls.Add(this.comboBoxWorkSeconds);
            this.Controls.Add(this.comboBoxWorkMinutes);
            this.Controls.Add(this.labelWorkMinutes);
            this.Controls.Add(this.comboBoxWorkHours);
            this.Controls.Add(this.labelWorkHours);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WorkLogTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

