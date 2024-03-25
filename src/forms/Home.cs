using ImmichGoGui.util;
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ImmichGoGui
{
    public partial class Home : Form
    {
        private const string FILE = "File";
        private const string FOLDER = "Folder";
        private const string GOOGLE_PHOTOS = "Google Photos";

        private AppConfig config;

        public Home()
        {
            InitializeComponent();
            config = ConfigUtils.GetConfig();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Text = Constants.APPLICATION_NAME;
            labelVersion.Text = "Version " + Constants.VERSION;
            comboBoxUploadType.Text = "File";

            textBoxURL.Text = config.ImmichURL;
            textBoxAPIKey.Text = config.APIKey;
            comboBoxSkipSSLVerification.Checked = config.SkipSSLVerification;
        }

        private void ButtonUploadPathBrowse_Click(object sender, EventArgs e)
        {
            if (comboBoxUploadType.Text.Equals(FILE) || comboBoxUploadType.Text.Equals(GOOGLE_PHOTOS))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog(); //
                textBoxUploadPath.Text = dialog.FileName;

            }
            else if (comboBoxUploadType.Text.Equals(FOLDER))
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.ShowDialog();
                textBoxUploadPath.Text = dialog.SelectedPath;
            }

        }

        private void ButtonSaveInstanceSettings_Click(object sender, EventArgs e)
        {
            this.config = new AppConfig(textBoxURL.Text, textBoxAPIKey.Text);
            ConfigUtils.SaveConfig(config);
        }

        private void ButtonClearOutput_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = string.Empty;
        }

        private void ButtonRun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxURL.Text) ||
                String.IsNullOrEmpty(textBoxAPIKey.Text) ||
                String.IsNullOrEmpty(textBoxUploadPath.Text))
            {
                MessageBox.Show("A required field is empty");
            }
            else
            {
                StartImmichGo();
            }
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void StartImmichGo()
        {
            Process process = new Process();
            process.StartInfo.FileName = "immich-go";
            if (Environment.OSVersion.Platform.Equals(PlatformID.Win32NT))
            {
                process.StartInfo.FileName += ".exe";
            }
            process.StartInfo.Arguments = CreateArguments();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.OutputDataReceived += (s, e) => AppendTextBoxOutput(e.Data);
            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();
        }

        private string CreateArguments()
        {
            StringBuilder argument = new StringBuilder();
            argument.Append("-server=" + textBoxURL.Text);
            argument.Append(" -key=" + textBoxAPIKey.Text);

            if (textBoxURL.Text.ToLower().StartsWith("https") && comboBoxSkipSSLVerification.Checked)
            {
                argument.Append(" -skip-verify-ssl=true");
            }

            argument.Append(" upload");

            if (!String.IsNullOrEmpty(textBoxAlbumName.Text))
            {
                argument.Append(" -album=\"" + textBoxAlbumName.Text + "\"");
            }

            if (comboBoxUploadType.Text.Equals(GOOGLE_PHOTOS))
            {
                argument.Append(" -create-albums -google-photos");
            }

            argument.Append(" \"" + textBoxUploadPath.Text + "\"");

            if (comboBoxUploadType.Text.Equals(FOLDER))
            {
                argument.Append("\\*");
            }
            return argument.ToString();
        }

        public void AppendTextBoxOutput(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBoxOutput), new object[] { value });
                return;
            }
            textBoxOutput.AppendText(value);
        }
    }
}

