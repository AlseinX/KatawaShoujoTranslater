using System;
using System.Windows.Forms;

namespace KatawaTranslater
{
    static class Program
    {
        public static string OpenPath;
        public static string SettingPath;
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                OpenPath = args[0];
            }
            catch
            {
                OpenPath = "";
            }
            SettingPath = Application.UserAppDataPath + "\\Settings.bin";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
