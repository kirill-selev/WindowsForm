﻿namespace Clock
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topmostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.chooseFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fregroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbPin = new System.Windows.Forms.CheckBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ContextMenuStrip = this.contextMenuStrip1;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(27, 71);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(144, 51);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "label1";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topmostToolStripMenuItem,
            this.showControlsToolStripMenuItem,
            this.showDateToolStripMenuItem,
            this.toolStripSeparator2,
            this.chooseFontToolStripMenuItem,
            this.colorsToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem,
            this.alarmToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 170);
            // 
            // topmostToolStripMenuItem
            // 
            this.topmostToolStripMenuItem.CheckOnClick = true;
            this.topmostToolStripMenuItem.Name = "topmostToolStripMenuItem";
            this.topmostToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.topmostToolStripMenuItem.Text = "Topmost";
            this.topmostToolStripMenuItem.CheckedChanged += new System.EventHandler(this.topmostToolStripMenuItem_CheckedChanged);
            // 
            // showControlsToolStripMenuItem
            // 
            this.showControlsToolStripMenuItem.Checked = true;
            this.showControlsToolStripMenuItem.CheckOnClick = true;
            this.showControlsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showControlsToolStripMenuItem.Name = "showControlsToolStripMenuItem";
            this.showControlsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showControlsToolStripMenuItem.Text = "Show controls";
            this.showControlsToolStripMenuItem.Click += new System.EventHandler(this.showControlsToolStripMenuItem_Click);
            // 
            // showDateToolStripMenuItem
            // 
            this.showDateToolStripMenuItem.CheckOnClick = true;
            this.showDateToolStripMenuItem.Name = "showDateToolStripMenuItem";
            this.showDateToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showDateToolStripMenuItem.Text = "Show date";
            this.showDateToolStripMenuItem.Click += new System.EventHandler(this.showDateToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // chooseFontToolStripMenuItem
            // 
            this.chooseFontToolStripMenuItem.Name = "chooseFontToolStripMenuItem";
            this.chooseFontToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.chooseFontToolStripMenuItem.Text = "Choose font";
            this.chooseFontToolStripMenuItem.Click += new System.EventHandler(this.chooseFontToolStripMenuItem_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.fregroundColorToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // fregroundColorToolStripMenuItem
            // 
            this.fregroundColorToolStripMenuItem.Name = "fregroundColorToolStripMenuItem";
            this.fregroundColorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.fregroundColorToolStripMenuItem.Text = "Freground color";
            this.fregroundColorToolStripMenuItem.Click += new System.EventHandler(this.fregroundColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // alarmToolStripMenuItem
            // 
            this.alarmToolStripMenuItem.Name = "alarmToolStripMenuItem";
            this.alarmToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alarmToolStripMenuItem.Text = "Alarm";
            this.alarmToolStripMenuItem.Click += new System.EventHandler(this.alarmToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowDate.Location = new System.Drawing.Point(36, 166);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(245, 41);
            this.cbShowDate.TabIndex = 1;
            this.cbShowDate.Text = "Показать дату";
            this.cbShowDate.UseVisualStyleBackColor = true;
            this.cbShowDate.CheckedChanged += new System.EventHandler(this.cbShowDate_CheckedChanged);
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.Location = new System.Drawing.Point(36, 230);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(227, 55);
            this.btnHideControls.TabIndex = 2;
            this.btnHideControls.Text = "Hide controls";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "Clock";
            this.notifyIconSystemTray.Visible = true;
            this.notifyIconSystemTray.DoubleClick += new System.EventHandler(this.notifyIconSystemTray_DoubleClick);
            // 
            // cbPin
            // 
            this.cbPin.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbPin.AutoSize = true;
            this.cbPin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbPin.BackgroundImage")));
            this.cbPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbPin.FlatAppearance.BorderSize = 0;
            this.cbPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPin.Location = new System.Drawing.Point(199, 12);
            this.cbPin.MaximumSize = new System.Drawing.Size(64, 64);
            this.cbPin.MinimumSize = new System.Drawing.Size(64, 64);
            this.cbPin.Name = "cbPin";
            this.cbPin.Size = new System.Drawing.Size(64, 64);
            this.cbPin.TabIndex = 3;
            this.cbPin.UseVisualStyleBackColor = true;
            this.cbPin.CheckedChanged += new System.EventHandler(this.cbPin_CheckedChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(54, 342);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(227, 47);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.cbPin);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.labelTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.CheckBox cbShowDate;
		private System.Windows.Forms.Button btnHideControls;
		private System.Windows.Forms.NotifyIcon notifyIconSystemTray;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem showControlsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showDateToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fregroundColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chooseFontToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem topmostToolStripMenuItem;
		private System.Windows.Forms.CheckBox cbPin;
        private System.Windows.Forms.ToolStripMenuItem alarmToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

