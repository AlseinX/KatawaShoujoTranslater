using System;
using System.Windows.Forms;
namespace KatawaTranslater
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            try
            {
                base.Dispose(disposing);
            }
            catch { }
        }
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlContent = new System.Windows.Forms.Panel();
            this.SPC = new System.Windows.Forms.SplitContainer();
            this.dgvContent = new KatawaTranslater.MainForm.MyGrid();
            this.clmContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsCell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rbtnReset = new System.Windows.Forms.ToolStripMenuItem();
            this.rbtnClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.rbtnTransThis = new System.Windows.Forms.ToolStripMenuItem();
            this.rbtnTransFollow = new System.Windows.Forms.ToolStripMenuItem();
            this.splTrans = new System.Windows.Forms.Splitter();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.MENU = new System.Windows.Forms.MenuStrip();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTools = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDescribe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOption = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFont = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSC = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTC = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAutoOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReset = new System.Windows.Forms.ToolStripMenuItem();
            this.STS = new System.Windows.Forms.StatusStrip();
            this.lblAutoSave = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAbout = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.FD = new System.Windows.Forms.FontDialog();
            this.CD = new System.Windows.Forms.ColorDialog();
            this.bwAutoSave = new System.ComponentModel.BackgroundWorker();
            this.rbtnCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent.SuspendLayout();
            this.SPC.Panel1.SuspendLayout();
            this.SPC.Panel2.SuspendLayout();
            this.SPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).BeginInit();
            this.cmsCell.SuspendLayout();
            this.MENU.SuspendLayout();
            this.STS.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.SPC);
            this.pnlContent.Controls.Add(this.MENU);
            this.pnlContent.Controls.Add(this.STS);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(944, 561);
            this.pnlContent.TabIndex = 3;
            // 
            // SPC
            // 
            this.SPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.SPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPC.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SPC.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SPC.Location = new System.Drawing.Point(0, 25);
            this.SPC.Name = "SPC";
            // 
            // SPC.Panel1
            // 
            this.SPC.Panel1.Controls.Add(this.dgvContent);
            // 
            // SPC.Panel2
            // 
            this.SPC.Panel2.Controls.Add(this.splTrans);
            this.SPC.Panel2.Controls.Add(this.txtOutput);
            this.SPC.Panel2.Controls.Add(this.txtInput);
            this.SPC.Panel2.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.SPC.Panel2Collapsed = true;
            this.SPC.Size = new System.Drawing.Size(944, 510);
            this.SPC.SplitterDistance = 747;
            this.SPC.TabIndex = 3;
            this.SPC.DoubleClick += new System.EventHandler(this.SPC_DoubleClick);
            // 
            // dgvContent
            // 
            this.dgvContent.AllowUserToAddRows = false;
            this.dgvContent.AllowUserToDeleteRows = false;
            this.dgvContent.AllowUserToResizeColumns = false;
            this.dgvContent.AllowUserToResizeRows = false;
            this.dgvContent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContent.ColumnHeadersVisible = false;
            this.dgvContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmContent});
            this.dgvContent.ContextMenuStrip = this.cmsCell;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContent.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContent.EnableHeadersVisualStyles = false;
            this.dgvContent.GridColor = System.Drawing.Color.White;
            this.dgvContent.Location = new System.Drawing.Point(0, 0);
            this.dgvContent.MultiSelect = false;
            this.dgvContent.Name = "dgvContent";
            this.dgvContent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvContent.RowHeadersWidth = 80;
            this.dgvContent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvContent.RowTemplate.Height = 23;
            this.dgvContent.Size = new System.Drawing.Size(944, 510);
            this.dgvContent.TabIndex = 0;
            this.dgvContent.VirtualMode = true;
            this.dgvContent.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvContent_CellBeginEdit);
            this.dgvContent.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContent_CellEndEdit);
            this.dgvContent.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvContent_CellMouseDown);
            this.dgvContent.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvContent_CellValidating);
            this.dgvContent.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvContent_CellValueNeeded);
            this.dgvContent.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvContent_Paint);
            this.dgvContent.GotFocus += new System.EventHandler(this.dgvContent_GotFocus);
            // 
            // clmContent
            // 
            this.clmContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmContent.HeaderText = "内容";
            this.clmContent.Name = "clmContent";
            this.clmContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmsCell
            // 
            this.cmsCell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rbtnCopy,
            this.toolStripMenuItem6,
            this.rbtnReset,
            this.rbtnClear,
            this.toolStripMenuItem4,
            this.rbtnTransThis,
            this.rbtnTransFollow});
            this.cmsCell.Name = "cmsCell";
            this.cmsCell.Size = new System.Drawing.Size(153, 126);
            // 
            // rbtnReset
            // 
            this.rbtnReset.Name = "rbtnReset";
            this.rbtnReset.Size = new System.Drawing.Size(152, 22);
            this.rbtnReset.Text = "重置为原文(&R)";
            this.rbtnReset.Click += new System.EventHandler(this.rbtnReset_Click);
            // 
            // rbtnClear
            // 
            this.rbtnClear.Name = "rbtnClear";
            this.rbtnClear.Size = new System.Drawing.Size(152, 22);
            this.rbtnClear.Text = "清空此句(&C)";
            this.rbtnClear.Click += new System.EventHandler(this.rbtnClear_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(149, 6);
            // 
            // rbtnTransThis
            // 
            this.rbtnTransThis.Name = "rbtnTransThis";
            this.rbtnTransThis.Size = new System.Drawing.Size(152, 22);
            this.rbtnTransThis.Text = "预翻译此句(&T)";
            this.rbtnTransThis.Click += new System.EventHandler(this.rbtnTransThis_Click);
            // 
            // rbtnTransFollow
            // 
            this.rbtnTransFollow.Name = "rbtnTransFollow";
            this.rbtnTransFollow.Size = new System.Drawing.Size(152, 22);
            this.rbtnTransFollow.Text = "预翻译以下(&F)";
            this.rbtnTransFollow.Click += new System.EventHandler(this.rbtnTransFollow_Click);
            // 
            // splTrans
            // 
            this.splTrans.Dock = System.Windows.Forms.DockStyle.Top;
            this.splTrans.Enabled = false;
            this.splTrans.Location = new System.Drawing.Point(0, 25);
            this.splTrans.Name = "splTrans";
            this.splTrans.Size = new System.Drawing.Size(92, 4);
            this.splTrans.TabIndex = 2;
            this.splTrans.TabStop = false;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtOutput.Location = new System.Drawing.Point(0, 25);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtOutput.Size = new System.Drawing.Size(92, 71);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.Text = "";
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtInput.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtInput.Location = new System.Drawing.Point(0, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(92, 21);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // MENU
            // 
            this.MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.btnTools,
            this.btnOption,
            this.btnHelp});
            this.MENU.Location = new System.Drawing.Point(0, 0);
            this.MENU.Name = "MENU";
            this.MENU.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MENU.Size = new System.Drawing.Size(944, 25);
            this.MENU.TabIndex = 1;
            this.MENU.Text = "menuStrip1";
            // 
            // btnFile
            // 
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.btnSaveAs,
            this.toolStripMenuItem1,
            this.btnExit});
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(58, 21);
            this.btnFile.Text = "文件(&F)";
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnOpen.Size = new System.Drawing.Size(165, 22);
            this.btnOpen.Text = "打开(&O)";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSave.Size = new System.Drawing.Size(165, 22);
            this.btnSave.Text = "保存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(165, 22);
            this.btnSaveAs.Text = "另存为(&A)";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnExit.Size = new System.Drawing.Size(165, 22);
            this.btnExit.Text = "关闭(&X)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTools
            // 
            this.btnTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCopyAll,
            this.btnTransAll,
            this.toolStripMenuItem5,
            this.btnDescribe});
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(59, 21);
            this.btnTools.Text = "工具(&T)";
            // 
            // btnTransAll
            // 
            this.btnTransAll.Name = "btnTransAll";
            this.btnTransAll.Size = new System.Drawing.Size(187, 22);
            this.btnTransAll.Text = "预翻译所有(&T)";
            this.btnTransAll.Click += new System.EventHandler(this.btnTransAll_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(184, 6);
            // 
            // btnDescribe
            // 
            this.btnDescribe.Name = "btnDescribe";
            this.btnDescribe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.btnDescribe.Size = new System.Drawing.Size(187, 22);
            this.btnDescribe.Text = "词典查询(&D)";
            this.btnDescribe.Click += new System.EventHandler(this.btnDescribe_Click);
            // 
            // btnOption
            // 
            this.btnOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFont,
            this.btnSC,
            this.btnTC,
            this.toolStripMenuItem2,
            this.btnAutoOpen,
            this.btnAutoSave});
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(62, 21);
            this.btnOption.Text = "选项(&O)";
            // 
            // btnFont
            // 
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(142, 22);
            this.btnFont.Text = "字体(&F)";
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnSC
            // 
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(142, 22);
            this.btnSC.Text = "原文染色(&S)";
            this.btnSC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // btnTC
            // 
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(142, 22);
            this.btnTC.Text = "译文染色(&T)";
            this.btnTC.Click += new System.EventHandler(this.btnTC_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(139, 6);
            // 
            // btnAutoOpen
            // 
            this.btnAutoOpen.Checked = true;
            this.btnAutoOpen.CheckOnClick = true;
            this.btnAutoOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnAutoOpen.Name = "btnAutoOpen";
            this.btnAutoOpen.Size = new System.Drawing.Size(142, 22);
            this.btnAutoOpen.Text = "自动打开(&O)";
            this.btnAutoOpen.Click += new System.EventHandler(this.btnAutoOpen_Click);
            // 
            // btnAutoSave
            // 
            this.btnAutoSave.Checked = true;
            this.btnAutoSave.CheckOnClick = true;
            this.btnAutoSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnAutoSave.Name = "btnAutoSave";
            this.btnAutoSave.Size = new System.Drawing.Size(142, 22);
            this.btnAutoSave.Text = "自动保存(&A)";
            this.btnAutoSave.Click += new System.EventHandler(this.btnAutoSave_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout,
            this.toolStripMenuItem3,
            this.btnReset});
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(61, 21);
            this.btnHelp.Text = "帮助(&H)";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(140, 22);
            this.btnAbout.Text = "关于(&A)";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(137, 6);
            // 
            // btnReset
            // 
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 22);
            this.btnReset.Text = "重置设置(&R)";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // STS
            // 
            this.STS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAutoSave,
            this.lblAbout,
            this.lblTime});
            this.STS.Location = new System.Drawing.Point(0, 535);
            this.STS.Name = "STS";
            this.STS.Size = new System.Drawing.Size(944, 26);
            this.STS.TabIndex = 2;
            // 
            // lblAutoSave
            // 
            this.lblAutoSave.Name = "lblAutoSave";
            this.lblAutoSave.Size = new System.Drawing.Size(92, 21);
            this.lblAutoSave.Text = "自动保存已开启";
            // 
            // lblAbout
            // 
            this.lblAbout.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.lblAbout.Image = global::KatawaTranslater.Properties.Resources.Art2;
            this.lblAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(781, 21);
            this.lblAbout.Spring = true;
            this.lblAbout.Text = "Etsnarl制作";
            this.lblAbout.DoubleClick += new System.EventHandler(this.lblAbout_DoubleClick);
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 21);
            this.lblTime.Text = "现在时间";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OFD
            // 
            this.OFD.Filter = "所有文件|*";
            // 
            // SFD
            // 
            this.SFD.Filter = "纯文本文件|*.txt|所有文件|*";
            // 
            // CD
            // 
            this.CD.AnyColor = true;
            this.CD.FullOpen = true;
            // 
            // bwAutoSave
            // 
            this.bwAutoSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAutoSave_DoWork);
            // 
            // rbtnCopy
            // 
            this.rbtnCopy.Name = "rbtnCopy";
            this.rbtnCopy.Size = new System.Drawing.Size(152, 22);
            this.rbtnCopy.Text = "复制原文(&S)";
            this.rbtnCopy.Click += new System.EventHandler(this.rbtnCopy_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(149, 6);
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(187, 22);
            this.btnCopyAll.Text = "复制所有(&C)";
            this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.pnlContent);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MENU;
            this.Name = "MainForm";
            this.Text = "かたわ少女中国語翻訳ツール";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.SPC.Panel1.ResumeLayout(false);
            this.SPC.Panel2.ResumeLayout(false);
            this.SPC.Panel2.PerformLayout();
            this.SPC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContent)).EndInit();
            this.cmsCell.ResumeLayout(false);
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            this.STS.ResumeLayout(false);
            this.STS.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private MyGrid dgvContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmContent;
        private System.Windows.Forms.MenuStrip MENU;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.StatusStrip STS;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnOption;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.ToolStripMenuItem btnFont;
        private System.Windows.Forms.ToolStripMenuItem btnSC;
        private System.Windows.Forms.ToolStripMenuItem btnTC;
        private System.Windows.Forms.ToolStripMenuItem btnAutoSave;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.ToolStripStatusLabel lblAutoSave;
        private System.Windows.Forms.FontDialog FD;
        private System.Windows.Forms.ColorDialog CD;
        private System.ComponentModel.BackgroundWorker bwAutoSave;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripStatusLabel lblAbout;
        private System.Windows.Forms.ToolStripMenuItem btnAutoOpen;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem btnReset;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnTools;
        private System.Windows.Forms.ToolStripMenuItem btnTransAll;
        private System.Windows.Forms.ContextMenuStrip cmsCell;
        private System.Windows.Forms.ToolStripMenuItem rbtnReset;
        private System.Windows.Forms.ToolStripMenuItem rbtnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem rbtnTransThis;
        private System.Windows.Forms.ToolStripMenuItem rbtnTransFollow;
        private System.Windows.Forms.ToolStripMenuItem btnDescribe;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.Panel pnlContent;
        private SplitContainer SPC;
        private RichTextBox txtOutput;
        private TextBox txtInput;
        private Splitter splTrans;
        private ToolStripMenuItem rbtnCopy;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem btnCopyAll;



    }
}

