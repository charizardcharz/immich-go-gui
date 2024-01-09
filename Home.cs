using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ImmichGoGui
{
    public partial class Home : Form
    {
        private AppConfig config;
        public Home()
        {
            InitializeComponent();
            config = ConfigUtils.getConfig();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Text = Constants.APPLICATION_NAME;
            labelVersion.Text = "Version " + Constants.VERSION;
            comboBoxUploadType.Text = "File";

            textBoxURL.Text = config.immichURL;
            textBoxAPIKey.Text = config.APIKey;
        }

        private void buttonUploadPathBrowse_Click(object sender, EventArgs e)
        {
            if (comboBoxUploadType.Text.Equals("File") || comboBoxUploadType.Text.Equals("Google Photos")) {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog(); // Show the dialog.
                textBoxUploadPath.Text = dialog.FileName;

            } else if (comboBoxUploadType.Text.Equals("Folder")){
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.ShowDialog(); // Show the dialog.
                textBoxUploadPath.Text = dialog.SelectedPath;
            }
            
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxURL.Text) ||
                String.IsNullOrEmpty(textBoxAPIKey.Text) ||
                String.IsNullOrEmpty(textBoxUploadPath.Text))
            {  }
            else
            {
                startImmichGo();
            }
        }

        private void startImmichGo()
        {
            Process process = new Process();
            if (Environment.OSVersion.Platform.Equals(PlatformID.Win32NT))
            {
                process.StartInfo.FileName = "immich-go.exe";
            } else
            {
                process.StartInfo.FileName = "immich-go";
            }
            process.StartInfo.Arguments = createArgument();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.Start();
            while (!process.StandardOutput.EndOfStream)
            {
                string output = process.StandardOutput.ReadLine();
                textBoxOutput.AppendText(output + Environment.NewLine);
            }
            process.WaitForExit();
        }

        private string createArgument()
        {
            StringBuilder argument = new StringBuilder();
            argument.Append("-server=" + textBoxURL.Text);
            argument.Append(" -key=" + textBoxAPIKey.Text);

            if (textBoxURL.Text.ToLower().StartsWith("https"))
            {
                argument.Append(" -skip-verify-ssl=true");
            }

            argument.Append(" upload");
            
            if (!String.IsNullOrEmpty(textBoxAlbumName.Text))
            {
                argument.Append(" -album=\"" + textBoxAlbumName.Text + "\"");
            }

            argument.Append(" " + textBoxUploadPath.Text);

            if (comboBoxUploadType.Text.Equals("Folder"))
            {
                argument.Append("*");
            }
            return argument.ToString();
        }

        private void buttonSaveInstanceSettings_Click(object sender, EventArgs e)
        {
            ConfigUtils.saveConfig(new AppConfig(textBoxURL.Text, textBoxAPIKey.Text));
        }

        private void buttonClearOutput_Click(object sender, EventArgs e)
        {
           textBoxOutput.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}

