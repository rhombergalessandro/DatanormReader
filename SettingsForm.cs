using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatanormReader
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LogSpeicherPfad = txtSettingsPfad.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            txtSettingsPfad.Text = Properties.Settings.Default.LogSpeicherPfad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtSettingsPfad.Text = ofd.SelectedPath;
            }
        }
    }
}
