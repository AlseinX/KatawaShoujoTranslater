using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace KatawaTranslater
{
    [Serializable]
    class Settings : IDisposable
    {
        private Color sC, tC;

        public Color TC
        {
            get { return tC; }
            set { tC = value; }
        }

        public Color SC
        {
            get { return sC; }
            set { sC = value; }
        }
        private Font font;

        public Font Font
        {
            get { return font; }
            set { font = value; }
        }
        private bool autoSave;

        public bool AutoSave
        {
            get { return autoSave; }
            set { autoSave = value; }
        }
        private string autoOpen;

        public string AutoOpen
        {
            get { return autoOpen; }
            set { autoOpen = value; }
        }
        public Settings()
        {
            try
            {
                IFormatter f = new BinaryFormatter();
                using (Stream st = File.Open(Program.SettingPath, FileMode.Open))
                {
                    Settings s = (Settings)f.Deserialize(st);
                    sC = s.sC;
                    tC = s.tC;
                    font = s.font;
                    autoSave = s.autoSave;
                    autoOpen = s.autoOpen;
                }
            }
            catch
            {
                Reset();
            }
        }
        private void Save()
        {
            IFormatter f = new BinaryFormatter();
            try
            {
                using (Stream st = File.Open(Program.SettingPath, FileMode.Create))
                {
                    f.Serialize(st, this);
                }
            }
            catch { }
        }
        public void Reset()
        {
            sC = Color.Red;
            tC = Color.Blue;
            font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            autoSave = true;
            autoOpen = "";
            Dispose();
        }
        ~Settings()
        {
            Dispose();
        }
        public void Dispose()
        {
            Save();
        }
    }
}
