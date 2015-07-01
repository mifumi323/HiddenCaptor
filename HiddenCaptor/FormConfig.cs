using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiddenCaptor.Properties;

namespace HiddenCaptor
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Directory.Exists(txtSaveFolder.Text))
            {
                if (chkSaveAlways.Checked) SaveFromClipboard();
            }
        }

        private void SaveFromClipboard()
        {
            if (!Clipboard.ContainsImage()) return;
            var image = Clipboard.GetImage();
            Save(image);
            Clipboard.Clear();
        }

        private void Save(Image image)
        {
            string filename = GetValidFilename();
            image.Save(filename);
        }

        private string GetValidFilename()
        {
            string filename;
            int i = 0;
            do
            {
                i++;
                filename = Path.Combine(txtSaveFolder.Text, string.Format("SS{0:000}.png", i));
            } while (File.Exists(filename));
            return filename;
        }

        private void btnSaveFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtSaveFolder.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSaveFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            LoadSettings();
            notifyIcon1.Icon = Icon;
            notifyIcon1.Text = Text;
            notifyIcon1.Visible = true;
        }

        private void LoadSettings()
        {
            var setting = Settings.Default;
            if (setting.UpgradeRequired)
            {
                setting.Upgrade();
                setting.UpgradeRequired = false;
                setting.Save();
            }
            txtSaveFolder.Text = setting.SaveFolder;
            chkSourceClipboard.Checked = setting.SourceClipboard;
            chkSaveAlways.Checked = setting.SaveAlways;
        }

        private void FormConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Visible = false;
            SaveSettings();
        }

        private void SaveSettings()
        {
            var setting = Settings.Default;
            setting.SaveFolder = txtSaveFolder.Text;
            setting.SourceClipboard = chkSourceClipboard.Checked;
            setting.SaveAlways = chkSaveAlways.Checked;
            setting.Save();
        }

        private void FormConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitToolStripMenuItem.Checked)
            {
                Hide();
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitToolStripMenuItem.Checked = true;
            Close();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button!= MouseButtons.Left) return;
            Visible = !Visible;
        }
    }
}
