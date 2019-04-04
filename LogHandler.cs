using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatanormReader
{
    class LogHandler
    {

        public static void Log(string logMessage)
        {
            string path;
            string defaultPath = Properties.Settings.Default.LogSpeicherPfad;

            if (defaultPath == "Debug Verzeichnis")
            {
                path = @"DatanormReader.log";
            }
            else
            {
                path = Properties.Settings.Default.LogSpeicherPfad + @"\DatanormReader.log";
            }
            try
            {
                using (StreamWriter sw = (File.Exists(path)) ? File.AppendText(path) : File.CreateText(path))
                {
                    sw.WriteLine($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}: " + logMessage);
                }
            }
            catch (DirectoryNotFoundException)
            {


                MessageBox.Show("Der angegebene Verzeichnis für die Logdatei wurde nicht gefunden! In den Settings können Sie das angegebene Verzeichnis abändern! ", "DirectoryNotFoundException", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SettingsForm Form2 = new SettingsForm();
                Form2.ShowDialog();
            }
        }
    
    }
}
