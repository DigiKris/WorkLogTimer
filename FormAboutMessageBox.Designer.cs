
namespace WorkLogTimer
{
    partial class FormAboutMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutMessageBox));
            this.labellabelWorkLogTimerby = new System.Windows.Forms.Label();
            this.linkLabelDigiKris = new System.Windows.Forms.LinkLabel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labellabelWorkLogTimerby
            // 
            this.labellabelWorkLogTimerby.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labellabelWorkLogTimerby.Location = new System.Drawing.Point(41, 13);
            this.labellabelWorkLogTimerby.Name = "labellabelWorkLogTimerby";
            this.labellabelWorkLogTimerby.Size = new System.Drawing.Size(114, 23);
            this.labellabelWorkLogTimerby.TabIndex = 1;
            this.labellabelWorkLogTimerby.Text = "WorkLogTimer by";
            this.labellabelWorkLogTimerby.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelDigiKris
            // 
            this.linkLabelDigiKris.Location = new System.Drawing.Point(150, 17);
            this.linkLabelDigiKris.Name = "linkLabelDigiKris";
            this.linkLabelDigiKris.Size = new System.Drawing.Size(51, 23);
            this.linkLabelDigiKris.TabIndex = 2;
            this.linkLabelDigiKris.TabStop = true;
            this.linkLabelDigiKris.Text = "DigiKris";
            this.linkLabelDigiKris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDigiKris_LinkClicked);
            // 
            // labelVersion
            // 
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVersion.Location = new System.Drawing.Point(2, 36);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(247, 23);
            this.labelVersion.TabIndex = 3;
            this.labelVersion.Text = "2.0.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(62, 59);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://kkristjan.com/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormAboutMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(253, 94);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.linkLabelDigiKris);
            this.Controls.Add(this.labellabelWorkLogTimerby);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WorkLogTimer About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labellabelWorkLogTimerby;
        private System.Windows.Forms.LinkLabel linkLabelDigiKris;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}