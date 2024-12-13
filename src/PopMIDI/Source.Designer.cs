namespace PopMIDI
{
    partial class Source
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.audioTimer = new System.Windows.Forms.Timer(this.components);
            this.sPlayButton = new System.Windows.Forms.Button();
            this.sStopButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.sProgressbar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileButton,
            this.toolStripSeparator,
            this.ExitButton});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFileButton.Size = new System.Drawing.Size(180, 22);
            this.OpenFileButton.Text = "開く(&O)";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 22);
            this.ExitButton.Text = "終了(&X)";
            // 
            // audioTimer
            // 
            this.audioTimer.Interval = 500;
            this.audioTimer.Tick += new System.EventHandler(this.audioTimer_Tick);
            // 
            // sPlayButton
            // 
            this.sPlayButton.Location = new System.Drawing.Point(28, 104);
            this.sPlayButton.Name = "sPlayButton";
            this.sPlayButton.Size = new System.Drawing.Size(76, 38);
            this.sPlayButton.TabIndex = 2;
            this.sPlayButton.Text = "再生";
            this.sPlayButton.UseVisualStyleBackColor = true;
            this.sPlayButton.Click += new System.EventHandler(this.sPlayButton_Click);
            // 
            // sStopButton
            // 
            this.sStopButton.Location = new System.Drawing.Point(110, 104);
            this.sStopButton.Name = "sStopButton";
            this.sStopButton.Size = new System.Drawing.Size(76, 38);
            this.sStopButton.TabIndex = 3;
            this.sStopButton.Text = "停止";
            this.sStopButton.UseVisualStyleBackColor = true;
            this.sStopButton.Click += new System.EventHandler(this.sStopButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(26, 53);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(71, 12);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "00:00 / 00:00";
            // 
            // sProgressbar
            // 
            this.sProgressbar.Location = new System.Drawing.Point(28, 72);
            this.sProgressbar.Name = "sProgressbar";
            this.sProgressbar.Size = new System.Drawing.Size(258, 10);
            this.sProgressbar.TabIndex = 5;
            // 
            // Source
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 552);
            this.Controls.Add(this.sStopButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.sProgressbar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.sPlayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Source";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pop MIDI   |   Sakamochanq";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.Button sPlayButton;
        private System.Windows.Forms.Button sStopButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ProgressBar sProgressbar;
        private System.Windows.Forms.Timer audioTimer;
    }
}

