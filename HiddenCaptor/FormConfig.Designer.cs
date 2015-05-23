namespace HiddenCaptor
{
    partial class FormConfig
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSaveFolder = new System.Windows.Forms.Button();
            this.txtSaveFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkSourceClipboard = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkSaveAlways = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSaveFolder);
            this.tabPage1.Controls.Add(this.txtSaveFolder);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "保存設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSaveFolder
            // 
            this.btnSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFolder.Location = new System.Drawing.Point(226, 6);
            this.btnSaveFolder.Name = "btnSaveFolder";
            this.btnSaveFolder.Size = new System.Drawing.Size(44, 19);
            this.btnSaveFolder.TabIndex = 2;
            this.btnSaveFolder.Text = "参照";
            this.btnSaveFolder.UseVisualStyleBackColor = true;
            this.btnSaveFolder.Click += new System.EventHandler(this.btnSaveFolder_Click);
            // 
            // txtSaveFolder
            // 
            this.txtSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveFolder.Location = new System.Drawing.Point(67, 6);
            this.txtSaveFolder.Name = "txtSaveFolder";
            this.txtSaveFolder.Size = new System.Drawing.Size(153, 19);
            this.txtSaveFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "保存場所";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkSourceClipboard);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "取得元";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkSourceClipboard
            // 
            this.chkSourceClipboard.AutoSize = true;
            this.chkSourceClipboard.Checked = true;
            this.chkSourceClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSourceClipboard.Location = new System.Drawing.Point(8, 6);
            this.chkSourceClipboard.Name = "chkSourceClipboard";
            this.chkSourceClipboard.Size = new System.Drawing.Size(84, 16);
            this.chkSourceClipboard.TabIndex = 0;
            this.chkSourceClipboard.Text = "クリップボード";
            this.chkSourceClipboard.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.AutoScrollMargin = new System.Drawing.Size(8, 6);
            this.tabPage3.Controls.Add(this.chkSaveAlways);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(276, 236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "保存条件";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chkSaveAlways
            // 
            this.chkSaveAlways.AutoSize = true;
            this.chkSaveAlways.Checked = true;
            this.chkSaveAlways.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveAlways.Location = new System.Drawing.Point(8, 6);
            this.chkSaveAlways.Name = "chkSaveAlways";
            this.chkSaveAlways.Size = new System.Drawing.Size(168, 16);
            this.chkSaveAlways.TabIndex = 0;
            this.chkSaveAlways.Text = "見つけ次第(クリップボードのみ)";
            this.chkSaveAlways.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "終了(&X)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.MinimizeBox = false;
            this.Name = "FormConfig";
            this.Text = "HiddenCaptor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfig_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConfig_FormClosed);
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSaveFolder;
        private System.Windows.Forms.TextBox txtSaveFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkSourceClipboard;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkSaveAlways;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

