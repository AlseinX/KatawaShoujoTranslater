using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace KatawaTranslater
{
    public partial class MainForm : Form
    {
        #region 私有字段
        private List<string> FileContent, tableContent;
        string[] TableContent;
        private string[] TFrom, TTo, FFrom, FTo;
        private int redraw = -1;
        private int AutoSaveSecond = 0;
        private Settings Settings;
        private GoogleTranslate gt;
        private int RightClickIndex;
        #endregion
        #region 私有属性
        private bool Openning
        {
            get
            {
                return dgvContent.Enabled;
            }
            set
            {
                dgvContent.Enabled = value;
                Changed = false;
            }
        }
        private bool Changed
        {
            get
            {
                return btnSaveAs.Enabled;
            }
            set
            {
                btnSave.Enabled = value;
                btnSaveAs.Enabled = value;
            }
        }
        private Color TC
        {
            get { return Settings.TC; }
            set
            {
                Settings.TC = value;
                RefreshList();
            }
        }
        private Color SC
        {
            get { return Settings.SC; }
            set
            {
                Settings.SC = value;
                RefreshList();
            }
        }
        private Font TFont
        {
            get { return Settings.Font; }
            set
            {
                Settings.Font = value;
                dgvContent.RowHeadersWidth = getWidth((int)value.Size);
                RefreshList();
            }
        }
        #endregion
        #region 构造方法
        public MainForm()
        {
            Settings = new Settings();
            InitTrans();
            InitializeComponent();
        }
        #endregion
        #region 私有方法
        private int getWidth(int Size)
        {
            return Size * 5 + 50;
        }
        private void RefreshList()
        {
            DataGridViewCell cu = dgvContent.CurrentCell, fd = dgvContent.FirstDisplayedCell;
            DataGridViewRow[] dc = new DataGridViewRow[dgvContent.Rows.Count];
            dgvContent.Rows.CopyTo(dc, 0);
            dgvContent.Rows.Clear();
            foreach (DataGridViewRow d in dc)
            {
                d.Cells[0].Style.Font = Settings.Font;
                d.Cells[0].Style.ForeColor = d.HeaderCell.Value.ToString().StartsWith("原") ? SC : TC;
                d.HeaderCell.Style.ForeColor = d.Cells[0].Style.ForeColor;
                d.HeaderCell.Style.BackColor = d.Cells[0].Style.BackColor;
                d.HeaderCell.Style.Font = Settings.Font;
                dgvContent.Rows.Add(d);
            }
            dgvContent.CurrentCell = cu;
            Application.DoEvents();
            dgvContent.FirstDisplayedCell = fd;

        }
        private string ForeString(string s, char mark)
        {
            return TranslateFore(s.Substring(1, s.IndexOf(mark) - 1).Trim());
        }
        private string DeFore(string s)
        {
            return s.Substring(s.IndexOf(':') + 1);
        }
        private bool InitSettings()
        {
            btnAutoSave.Checked = Settings.AutoSave;
            btnAutoOpen.Checked = Settings.AutoOpen != "Disabled";
            TFont = Settings.Font;
            if (Program.OpenPath != "")
            {
                return true;
            }
            if (!(Settings.AutoOpen == "" || Settings.AutoOpen == "Disabled"))
            {
                OFD.FileName = Settings.AutoOpen;
                OpenText(OFD.FileName);
            }
            return false;
        }
        private void SplitArray(string s, ref string[] from, ref string[] to)
        {
            string[] sa = s.Replace("\r\n", "\n").Split('\n');
            from = new string[sa.Length];
            to = new string[sa.Length];
            for (int i = 0; i < sa.Length; i++)
            {
                from[i] = sa[i].Substring(0, sa[i].IndexOf(','));
                to[i] = sa[i].Substring(sa[i].IndexOf(',') + 1);
            }
        }
        private void InitTrans()
        {
            SplitArray(global::KatawaTranslater.TransTable.TT, ref TFrom, ref TTo);
            SplitArray(global::KatawaTranslater.TransTable.FS, ref FFrom, ref FTo);
        }
        private string Translate(string s)
        {
            for (int i = 0; i < TFrom.Length; i++)
            {
                s = s.Replace(TFrom[i], TTo[i]);
            }
            return s;
        }
        private string TranslateFore(string s)
        {
            if (s == "") s = "NONE";
            for (int i = 0; i < FFrom.Length; i++)
            {
                s = s.Replace(FFrom[i], FTo[i]);
            }
            return s;
        }
        private void DataUpdate(int index, string value)
        {
            try
            {
                string s = TableContent[index];
                TableContent[index] = value;
                if (s == TableContent[index])
                {
                    return;
                }
                Changed = true;
                FileContent[(int)dgvContent.Rows[index].Tag] = FileContent[(int)dgvContent.Rows[index].Tag - 1].Replace(DeFore(TableContent[index - 1]), TableContent[index]).Substring(1).Replace("\r\n", "");
                redraw = index;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool OpenText(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(File.OpenRead(path), Encoding.UTF8))
                {
                    dgvContent.Rows.Clear();
                    FileContent = new List<string>();
                    tableContent = new List<string>();
                    bool t = false;
                    while (!sr.EndOfStream)
                    {
                        string s = sr.ReadLine();
                        if (s.IndexOf('\"') >= 0 && !s.Contains("$ renpy.music.set_volume(0.5, 0.0, channel="))
                        {
                            if (s.StartsWith("#"))
                            {
                                if (t)
                                {
                                    AddContent("");
                                }
                                t = true;
                                AddContent(s);
                            }
                            else if (!t)
                            {
                                s = "#" + s;
                                t = true;
                                AddContent(s);
                            }
                            else
                            {
                                AddContent(s);
                                t = false;
                            }
                        }
                        else
                        {
                            if (t)
                            {
                                AddContent("");
                                t = false;
                            }
                        }
                        FileContent.Add(s);
                    }
                }
                TableContent = tableContent.ToArray();
                dgvContent.Focus();
                Openning = true;
                if (Settings.AutoOpen != "Disabled")
                {
                    Settings.AutoOpen = OFD.FileName;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void AddContent(string text)
        {
            bool type = text.StartsWith("#");
            string fs = "";
            if (type)
            {
                fs = ForeString(text, '\"');
            }
            bool _new = text == "";
            if (_new)
            {
                text = Translate(DeFore(tableContent[tableContent.Count - 1]));
            }
            else
            {
                if (text.Count(x => x == '\"') >= 2)
                {
                    text = text.Substring(text.IndexOf('\"') + 1);
                    text = text.Substring(0, text.LastIndexOf('\"'));
                }
            }
            if (type)
            {
                text = fs + ":" + text;
            }
            DataGridViewRow n = new DataGridViewRow();
            n.Tag = FileContent.Count;
            n.Cells.Add(new DataGridViewTextBoxCell());
            n.Cells[0].Value = text;
            n.Cells[0].ReadOnly = type;
            n.Cells[0].Style.Alignment = DataGridViewContentAlignment.TopLeft;
            n.Cells[0].Style.ForeColor = type ? SC : TC;
            n.Cells[0].Style.BackColor = type ? Color.FromArgb(200, 210, 255) : Color.FromArgb(210, 220, 255);
            n.Cells[0].Style.Font = TFont;
            n.HeaderCell.Style.ForeColor = n.Cells[0].Style.ForeColor;
            n.HeaderCell.Style.BackColor = n.Cells[0].Style.BackColor;
            n.HeaderCell.Value = (type ? "原" : "译") + (tableContent.Count / 2 + 1);
            n.HeaderCell.Style.Font = TFont;
            n.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (_new)
            {
                FileContent.Add(Translate(FileContent[FileContent.Count - 1].Substring(1)));
            }
            tableContent.Add(text);
            dgvContent.Rows.Add(n);
        }
        private bool SaveText(string path)
        {
            try
            {
                using (StreamWriter sr = new StreamWriter(File.Open(path, FileMode.Create), Encoding.UTF8))
                {
                    foreach (string s in FileContent)
                    {
                        sr.WriteLine(s);
                    }
                }
                Changed = false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void MasTrans()
        {
            string[] s = new string[dgvContent.Rows.Count / 2];
            for (int i = RightClickIndex; i < dgvContent.Rows.Count; i += 2)
            {
                s[(i - 1) / 2] = TableContent[i];
            }
            s = TranslateTool.Translate(s);
            for (int i = RightClickIndex; i < dgvContent.Rows.Count; i += 2)
            {
                TableContent[i] = s[(i - 1) / 2];
            }
            dgvContent.EndEdit();
        }
        #endregion
        #region 事件处理方法
        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvContent.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Openning = false;
            bwAutoSave.RunWorkerAsync();
            if (InitSettings())
            {
                OFD.FileName = Program.OpenPath;
                OpenText(Program.OpenPath);
            }
            Activate();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (Changed)
            {
                DialogResult dr = MessageBox.Show(this, "尚未保存，是否保存？", "片轮少女专用翻译工具", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    break;
                }
                else if (dr == DialogResult.Yes)
                {
                    btnSave_Click(null, null);
                }
                else
                {
                    return;
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                OpenText(OFD.FileName);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveText(OFD.FileName);
            AutoSaveSecond = 0;
        }
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (SFD.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                SaveText(SFD.FileName);
            }
        }
        private void btnFont_Click(object sender, EventArgs e)
        {
            FD.Font = TFont;
            FD.ShowDialog();
            TFont = FD.Font;
        }
        private void btnSC_Click(object sender, EventArgs e)
        {
            CD.Color = SC;
            CD.ShowDialog();
            SC = CD.Color;
        }
        private void btnTC_Click(object sender, EventArgs e)
        {
            CD.Color = TC;
            CD.ShowDialog();
            TC = CD.Color;
        }
        private void btnAutoSave_Click(object sender, EventArgs e)
        {
            AutoSaveSecond = 0;
            Settings.AutoSave = btnAutoSave.Checked;
        }
        private void btnAutoOpen_Click(object sender, EventArgs e)
        {
            if (btnAutoOpen.Checked)
            {
                if (File.Exists(OFD.FileName))
                {
                    Settings.AutoOpen = OFD.FileName;
                }
                else
                {
                    Settings.AutoOpen = "";
                }
            }
            else
            {
                Settings.AutoOpen = "Disabled";
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Settings.Reset();
            InitSettings();
            RefreshList();
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            new About().ShowDialog(this);
        }
        private void lblAbout_DoubleClick(object sender, EventArgs e)
        {
            btnAbout_Click(sender, e);
        }
        private void dgvContent_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                bool b = ((string)dgvContent.CurrentRow.HeaderCell.Value).StartsWith("原");
                if (b)
                {
                    dgvContent.CurrentCell = dgvContent.Rows[dgvContent.CurrentRow.Index + 1].Cells[0];

                }
                if (!dgvContent.clicked)
                {
                    dgvContent.FirstDisplayedCell = dgvContent.Rows[dgvContent.CurrentRow.Index - 2].Cells[0];
                }
                if (!b)
                {
                    dgvContent.clicked = false;
                }
            }
            catch { }
            try
            {
                dgvContent.BeginEdit(false);
            }
            catch { }
        }
        private void dgvContent_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataUpdate(e.RowIndex, e.FormattedValue.ToString());
        }
        private void dgvContent_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (TableContent != null)
            {
                if (e.RowIndex < TableContent.Length)
                {
                    e.Value = TableContent[e.RowIndex];
                }
                else
                {
                    e.Value = "Exception:Index out of range";
                }
            }
            else
            {
                if (e.RowIndex < tableContent.Count)
                {
                    e.Value = tableContent[e.RowIndex];
                }
                else
                {
                    e.Value = "Exception:Index out of range";
                }
            }
        }
        private void dgvContent_Paint(object sender, PaintEventArgs e)
        {
            if (redraw >= 0)
            {
                try
                {
                    DataGridViewRow r = dgvContent.Rows[redraw];
                    dgvContent.Rows.RemoveAt(redraw);
                    dgvContent.Rows.Insert(redraw, r);
                }
                catch { }
                redraw = -1;
            }
            if ((!gt.Visible) && (!dgvContent.IsCurrentCellInEditMode))
            {
                try
                {
                    dgvContent.BeginEdit(false);
                }
                catch { }
            }
        }
        private void bwAutoSave_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(1000);
                try
                {
                    if (btnAutoSave.Checked && Openning)
                    {
                        if (++AutoSaveSecond >= 60)
                        {
                            btnSave_Click(null, null);
                        }
                        lblAutoSave.Text = (60 - AutoSaveSecond) + "秒后自动保存";
                    }
                    else
                    {
                        lblAutoSave.Text = Openning ? "自动保存已关闭" : "自动保存已开启";
                    }
                    lblTime.Text = DateTime.Now.ToString();
                }
                catch { }
            }
        }
        private void btnTransAll_Click(object sender, EventArgs e)
        {
            RightClickIndex = 1;
            MasTrans();
            Changed = true;
        }
        private void rbtnReset_Click(object sender, EventArgs e)
        {
            dgvContent.CurrentCell = dgvContent.Rows[RightClickIndex].Cells[0];
            Application.DoEvents();
            TableContent[RightClickIndex] = Translate(DeFore(TableContent[RightClickIndex - 1]));
            dgvContent.EndEdit();
            Changed = true;
        }
        private void dgvContent_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && !dgvContent.Rows[e.RowIndex].Cells[0].IsInEditMode)
            {
                RightClickIndex = e.RowIndex;
                if (RightClickIndex % 2 == 0)
                {
                    RightClickIndex++;
                }
                cmsCell.Show(MousePosition);
            }
        }
        private void rbtnClear_Click(object sender, EventArgs e)
        {
            dgvContent.CurrentCell = dgvContent.Rows[RightClickIndex].Cells[0];
            Application.DoEvents();
            TableContent[RightClickIndex] = "";
            dgvContent.EndEdit();
            Changed = true;
        }
        private void rbtnTransThis_Click(object sender, EventArgs e)
        {
            dgvContent.CurrentCell = dgvContent.Rows[RightClickIndex].Cells[0];
            Application.DoEvents();
            TableContent[RightClickIndex] = TranslateTool.Translate(new string[] { Translate(DeFore(TableContent[RightClickIndex - 1])) })[0];
            dgvContent.EndEdit();
            Changed = true;
        }
        private void rbtnTransFollow_Click(object sender, EventArgs e)
        {
            dgvContent.CurrentCell = dgvContent.Rows[RightClickIndex].Cells[0];
            Application.DoEvents();
            MasTrans();
            Changed = true;
        }
        private void btnDescribe_Click(object sender, EventArgs e)
        {
            gt.Show();
            gt.Activate();
            gt.txtInput.Text = "";
            gt.txtInput.Focus();
        }
        private void gt_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            gt.JustShown = false;
            gt.Hide();
        }
        private void dgvContent_GotFocus(object sender, System.EventArgs e)
        {
            dgvContent.BeginEdit(false);
        }
        private void dgvContent_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            SendKeys.Send("{HOME}{LEFT}{HOME}{LEFT}{HOME}{LEFT}{HOME}{LEFT}{HOME}{LEFT}{HOME}");
            dgvContent.CurrentCell.Style.BackColor = Color.FromArgb(220, 250, 255);
        }
        private void dgvContent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvContent.CurrentCell.Style.BackColor = dgvContent.CurrentRow.HeaderCell.Value.ToString().StartsWith("原") ? Color.FromArgb(200, 210, 255) : Color.FromArgb(210, 220, 255);
            DataUpdate(e.RowIndex, dgvContent.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        #endregion
        #region 内部类定义

        class MyGrid : DataGridView
        {
            public bool ln = false;
            public bool clicked = false;
            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x201)
                {
                    clicked = true;
                }
                base.WndProc(ref m);
            }
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                MainForm mf = (MainForm)FindForm();
                if (keyData == Keys.Down || keyData == (Keys.Down | Keys.Shift))
                {
                    SendKeys.Send("{END}{RIGHT}");
                }
                else if (keyData == Keys.Up)
                {
                    SendKeys.Send("{HOME}{LEFT}");
                }
                else if (keyData == (Keys.Enter | Keys.Shift))
                {
                    while ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                    {
                        Application.DoEvents();
                    }
                    ln = true;
                    string s = CurrentCell.EditedFormattedValue.ToString();
                    SendKeys.SendWait("n");
                    if (s != CurrentCell.EditedFormattedValue.ToString())
                    {
                        SendKeys.SendWait("{BACKSPACE}");
                        SendKeys.SendWait("\\n");
                    }
                    else
                    {
                        SendKeys.SendWait("{BACKSPACE}");
                        SendKeys.SendWait("+");
                        SendKeys.SendWait("\\n");
                        SendKeys.SendWait("+");
                    }
                }
                else if (keyData == (Keys.S | Keys.Control))
                {
                    mf.DataUpdate(CurrentCell.RowIndex, CurrentCell.EditedFormattedValue.ToString());
                    mf.btnSave_Click(null, null);
                }
                else if (keyData == ((Keys)220))
                {
                    if (!ln)
                    {
                        try
                        {
                            CurrentCell = Rows[CurrentRow.Index - 2].Cells[0];
                            Application.DoEvents();
                            BeginEdit(false);
                        }
                        catch { }
                    }
                    else
                    {
                        ln = false;
                        return base.ProcessCmdKey(ref msg, keyData);
                    }
                }
                else
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }
                return true;
            }
        }
        #endregion
    }
}
