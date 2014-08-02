using System;
using System.Windows.Forms;

namespace KatawaTranslater
{
    public partial class TranslateTool : Form
    {
        #region 静态方法
        public static string[] Translate(string[] c)
        {
            TranslateTool t = new TranslateTool();
            t.Content = c;
            t.ShowDialog();
            c = t.Content;
            return c;
        }
        #endregion
        #region 私有字段
        private string[] Content;
        private Translater tr;
        private bool cancel;
        #endregion
        #region 私有方法
        private void Cancel()
        {
            tr.Cancel();
            cancel = true;
        }
        private TranslateTool()
        {
            tr = new Translater();
            InitializeComponent();
        }
        private void RunTranslate()
        {
            PB.Maximum = Content.Length;
            for (int i = 0; i < Content.Length; i++)
            {
                if (Content[i] == null) { continue; }
                Content[i] = tr.Translate(Content[i]).Replace("\\ n", "\\n").Replace("\\n \\n", "\\n\\n");
                PB.Value = i;
                Text = "正在翻译(" + i + "/" + Content.Length + ")......";
                if (cancel)
                {
                    this.Close();
                    return;
                }
            }
            this.Close();
        }
        private void TranslateTool_Shown(object sender, EventArgs e)
        {
            RunTranslate();
        }
        private void TranslateTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cancel();
        }
        #endregion
    }
}
