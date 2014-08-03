using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KatawaTranslater
{
    public partial class GoogleTranslate : Form
    {
        #region 基本定义
        Translater Translate;
        public bool JustShown;
        public GoogleTranslate()
        {
            InitializeComponent();
        }
        #endregion
        #region 事件处理方法
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            JustShown = false;
        }
        private void GoogleTranslate_Load(object sender, EventArgs e)
        {
            Translate = new Translater();
        }
        private void btnEnter(object sender, EventArgs e)
        {
            if (JustShown)
            {
                JustShown = false;
                Hide();
            }
            else
            {
                txtOutput.Text = Translate.Describe(txtInput.Text);
                List<string> l = new List<string>();
                foreach (string s in txtOutput.Lines)
                {
                    if (s != "")
                    {
                        l.Add(s);
                    }
                }
                txtOutput.Lines = l.ToArray();
                try
                {
                    txtOutput.Select(txtOutput.Text.Length - 1, 0);
                }
                catch { }
                txtOutput.ScrollToCaret();
                JustShown = true;
                Activate();
                Parent.FindForm().Activate();
            }
        }
        private void GoogleTranslate_Shown(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(200, Parent.FindForm().Height - 200);
            Location = new System.Drawing.Point(Parent.FindForm().Width - Width - 34, 50);
        }
        #endregion

    }
}
