using System;
using System.Windows.Forms;

namespace KatawaTranslater
{
    class Translater
    {
        private bool cancel;
        private int trail = 0;
        public void Cancel()
        {
            cancel = true;
        }
        public string Translate(string content)
        {
            if (content.Trim() == "")
            {
                return "";
            }
            HtmlElement e;
            cancel = false;
            WebBrowser WB = new WebBrowser();
            WB.WebBrowserShortcutsEnabled = false;
            WB.ScriptErrorsSuppressed = true;
            WB.DocumentCompleted += WB_DocumentCompleted;
            WB.Navigate("http://translate.google.cn/#en/zh-CN/" + content);
            DateTime d = DateTime.Now;
            while (true)
            {
                try
                {
                    if (cancel)
                    {
                        WB.Dispose();
                        trail++;
                        return "";
                    }
                    e = WB.Document.GetElementById("result_box");
                    if (e.InnerHtml.Length > 1)
                    {
                        WB.Dispose();
                        trail = 0;
                        return e.InnerText;
                    }
                }
                catch
                {
                    Application.DoEvents();
                }
                cancel = new TimeSpan(DateTime.Now.Ticks - d.Ticks).Seconds > 10;
            }
        }

        public string Describe(string content)
        {
            if (content.Trim() == "")
            {
                return "";
            }
            HtmlElement e;
            cancel = false;
            WebBrowser WB = new WebBrowser();
            WB.WebBrowserShortcutsEnabled = false;
            WB.ScriptErrorsSuppressed = true;
            WB.DocumentCompleted += WB_DocumentCompleted;
            WB.Navigate("http://translate.google.cn/#en/zh-CN/" + content);
            DateTime d = DateTime.Now;
            while (true)
            {
                try
                {
                    if (cancel)
                    {
                        WB.Dispose();
                        return "";
                    }
                    e = WB.Document.GetElementById("gt-lc");
                    if (e.Children[1].InnerText.Length > 1)
                    {
                        string s = e.InnerText.Trim() + "\r\n直译:" + WB.Document.GetElementById("result_box").InnerText;
                        WB.Dispose();
                        return s;
                    }
                }
                catch
                {
                    Application.DoEvents();
                }
                cancel = new TimeSpan(DateTime.Now.Ticks - d.Ticks).Seconds > 10;
            }
        }

        void WB_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            cancel = true;
        }
    }
}
