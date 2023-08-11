namespace GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.bntApply = new System.Windows.Forms.Button();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.txtVTApiKey = new System.Windows.Forms.TextBox();
            this.lblVTApiKey = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.NotifyMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.gbSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipTitle = "SecureBox";
            this.notifyIcon.ContextMenuStrip = this.NotifyMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SecureBox";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // NotifyMenu
            // 
            this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.NotifyMenu.Name = "NotifyMenu";
            this.NotifyMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip.Location = new System.Drawing.Point(0, 228);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(433, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(12, 17);
            this.Status.Text = "-";
            // 
            // bntApply
            // 
            this.bntApply.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntApply.Location = new System.Drawing.Point(346, 190);
            this.bntApply.Name = "bntApply";
            this.bntApply.Size = new System.Drawing.Size(75, 23);
            this.bntApply.TabIndex = 2;
            this.bntApply.Text = "Apply";
            this.bntApply.UseVisualStyleBackColor = true;
            this.bntApply.Click += new System.EventHandler(this.bntApply_Click);
            // 
            // gbSetting
            // 
            this.gbSetting.Controls.Add(this.txtVTApiKey);
            this.gbSetting.Controls.Add(this.lblVTApiKey);
            this.gbSetting.Location = new System.Drawing.Point(12, 12);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(409, 172);
            this.gbSetting.TabIndex = 5;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "Setting";
            // 
            // txtVTApiKey
            // 
            this.txtVTApiKey.Location = new System.Drawing.Point(22, 135);
            this.txtVTApiKey.Name = "txtVTApiKey";
            this.txtVTApiKey.Size = new System.Drawing.Size(368, 20);
            this.txtVTApiKey.TabIndex = 6;
            // 
            // lblVTApiKey
            // 
            this.lblVTApiKey.AutoSize = true;
            this.lblVTApiKey.Location = new System.Drawing.Point(19, 119);
            this.lblVTApiKey.Name = "lblVTApiKey";
            this.lblVTApiKey.Size = new System.Drawing.Size(98, 13);
            this.lblVTApiKey.TabIndex = 5;
            this.lblVTApiKey.Text = "Virus Total API Key";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(265, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.bntApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(433, 250);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbSetting);
            this.Controls.Add(this.bntApply);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecureBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.NotifyMenu.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbSetting.ResumeLayout(false);
            this.gbSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.Button bntApply;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.TextBox txtVTApiKey;
        private System.Windows.Forms.Label lblVTApiKey;
        private System.Windows.Forms.Button btnCancel;
    }
}

