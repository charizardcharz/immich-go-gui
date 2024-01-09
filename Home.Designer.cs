namespace ImmichGoGui
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxUploadType = new System.Windows.Forms.ComboBox();
            this.labelUploadType = new System.Windows.Forms.Label();
            this.groupBoxInstance = new System.Windows.Forms.GroupBox();
            this.textBoxAPIKey = new System.Windows.Forms.TextBox();
            this.labelAPIKey = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.labelUpload = new System.Windows.Forms.Label();
            this.textBoxUploadPath = new System.Windows.Forms.TextBox();
            this.buttonUploadPathBrowse = new System.Windows.Forms.Button();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.textBoxAlbumName = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonSaveInstanceSettings = new System.Windows.Forms.Button();
            this.buttonClearOutput = new System.Windows.Forms.Button();
            this.groupBoxInstance.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(440, 626);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(230, 36);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Immich Go GUI";
            // 
            // comboBoxUploadType
            // 
            this.comboBoxUploadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUploadType.FormattingEnabled = true;
            this.comboBoxUploadType.Items.AddRange(new object[] {
            "File",
            "Folder",
            "Google Photos"});
            this.comboBoxUploadType.Location = new System.Drawing.Point(114, 142);
            this.comboBoxUploadType.Name = "comboBoxUploadType";
            this.comboBoxUploadType.Size = new System.Drawing.Size(128, 24);
            this.comboBoxUploadType.TabIndex = 3;
            // 
            // labelUploadType
            // 
            this.labelUploadType.AutoSize = true;
            this.labelUploadType.Location = new System.Drawing.Point(21, 145);
            this.labelUploadType.Name = "labelUploadType";
            this.labelUploadType.Size = new System.Drawing.Size(87, 16);
            this.labelUploadType.TabIndex = 4;
            this.labelUploadType.Text = "Upload Type";
            // 
            // groupBoxInstance
            // 
            this.groupBoxInstance.Controls.Add(this.textBoxAPIKey);
            this.groupBoxInstance.Controls.Add(this.labelAPIKey);
            this.groupBoxInstance.Controls.Add(this.textBoxURL);
            this.groupBoxInstance.Controls.Add(this.labelURL);
            this.groupBoxInstance.Location = new System.Drawing.Point(18, 48);
            this.groupBoxInstance.Name = "groupBoxInstance";
            this.groupBoxInstance.Size = new System.Drawing.Size(497, 81);
            this.groupBoxInstance.TabIndex = 5;
            this.groupBoxInstance.TabStop = false;
            this.groupBoxInstance.Text = "Instance Settings";
            // 
            // textBoxAPIKey
            // 
            this.textBoxAPIKey.Location = new System.Drawing.Point(66, 47);
            this.textBoxAPIKey.Name = "textBoxAPIKey";
            this.textBoxAPIKey.Size = new System.Drawing.Size(420, 22);
            this.textBoxAPIKey.TabIndex = 2;
            this.textBoxAPIKey.UseSystemPasswordChar = true;
            // 
            // labelAPIKey
            // 
            this.labelAPIKey.AutoSize = true;
            this.labelAPIKey.Location = new System.Drawing.Point(6, 50);
            this.labelAPIKey.Name = "labelAPIKey";
            this.labelAPIKey.Size = new System.Drawing.Size(54, 16);
            this.labelAPIKey.TabIndex = 2;
            this.labelAPIKey.Text = "API Key";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(66, 19);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(420, 22);
            this.textBoxURL.TabIndex = 1;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(26, 22);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(34, 16);
            this.labelURL.TabIndex = 0;
            this.labelURL.Text = "URL";
            // 
            // labelUpload
            // 
            this.labelUpload.AutoSize = true;
            this.labelUpload.Location = new System.Drawing.Point(56, 175);
            this.labelUpload.Name = "labelUpload";
            this.labelUpload.Size = new System.Drawing.Size(52, 16);
            this.labelUpload.TabIndex = 6;
            this.labelUpload.Text = "Upload";
            // 
            // textBoxUploadPath
            // 
            this.textBoxUploadPath.Location = new System.Drawing.Point(114, 172);
            this.textBoxUploadPath.Name = "textBoxUploadPath";
            this.textBoxUploadPath.Size = new System.Drawing.Size(320, 22);
            this.textBoxUploadPath.TabIndex = 7;
            // 
            // buttonUploadPathBrowse
            // 
            this.buttonUploadPathBrowse.Location = new System.Drawing.Point(440, 172);
            this.buttonUploadPathBrowse.Name = "buttonUploadPathBrowse";
            this.buttonUploadPathBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadPathBrowse.TabIndex = 8;
            this.buttonUploadPathBrowse.Text = "Browse";
            this.buttonUploadPathBrowse.UseVisualStyleBackColor = true;
            this.buttonUploadPathBrowse.Click += new System.EventHandler(this.buttonUploadPathBrowse_Click);
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Location = new System.Drawing.Point(23, 203);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(85, 16);
            this.labelAlbumName.TabIndex = 9;
            this.labelAlbumName.Text = "Album Name";
            // 
            // textBoxAlbumName
            // 
            this.textBoxAlbumName.Location = new System.Drawing.Point(114, 200);
            this.textBoxAlbumName.Name = "textBoxAlbumName";
            this.textBoxAlbumName.Size = new System.Drawing.Size(401, 22);
            this.textBoxAlbumName.TabIndex = 10;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(15, 236);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(45, 16);
            this.labelOutput.TabIndex = 11;
            this.labelOutput.Text = "Output";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.AcceptsReturn = true;
            this.textBoxOutput.AcceptsTab = true;
            this.textBoxOutput.Location = new System.Drawing.Point(18, 255);
            this.textBoxOutput.MaxLength = 65536;
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(497, 365);
            this.textBoxOutput.TabIndex = 12;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(15, 629);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(71, 16);
            this.labelVersion.TabIndex = 13;
            this.labelVersion.Text = "Version x.x";
            // 
            // buttonSaveInstanceSettings
            // 
            this.buttonSaveInstanceSettings.Location = new System.Drawing.Point(236, 626);
            this.buttonSaveInstanceSettings.Name = "buttonSaveInstanceSettings";
            this.buttonSaveInstanceSettings.Size = new System.Drawing.Size(198, 23);
            this.buttonSaveInstanceSettings.TabIndex = 14;
            this.buttonSaveInstanceSettings.Text = "Save Instance Settings";
            this.buttonSaveInstanceSettings.UseVisualStyleBackColor = true;
            this.buttonSaveInstanceSettings.Click += new System.EventHandler(this.buttonSaveInstanceSettings_Click);
            // 
            // buttonClearOutput
            // 
            this.buttonClearOutput.Location = new System.Drawing.Point(114, 626);
            this.buttonClearOutput.Name = "buttonClearOutput";
            this.buttonClearOutput.Size = new System.Drawing.Size(116, 23);
            this.buttonClearOutput.TabIndex = 15;
            this.buttonClearOutput.Text = "Clear Output";
            this.buttonClearOutput.UseVisualStyleBackColor = true;
            this.buttonClearOutput.Click += new System.EventHandler(this.buttonClearOutput_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 661);
            this.Controls.Add(this.buttonClearOutput);
            this.Controls.Add(this.buttonSaveInstanceSettings);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textBoxAlbumName);
            this.Controls.Add(this.labelAlbumName);
            this.Controls.Add(this.buttonUploadPathBrowse);
            this.Controls.Add(this.textBoxUploadPath);
            this.Controls.Add(this.labelUpload);
            this.Controls.Add(this.groupBoxInstance);
            this.Controls.Add(this.labelUploadType);
            this.Controls.Add(this.comboBoxUploadType);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonRun);
            this.Name = "Home";
            this.Text = "Immich Go GUI";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBoxInstance.ResumeLayout(false);
            this.groupBoxInstance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxUploadType;
        private System.Windows.Forms.Label labelUploadType;
        private System.Windows.Forms.GroupBox groupBoxInstance;
        private System.Windows.Forms.TextBox textBoxAPIKey;
        private System.Windows.Forms.Label labelAPIKey;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Label labelUpload;
        private System.Windows.Forms.TextBox textBoxUploadPath;
        private System.Windows.Forms.Button buttonUploadPathBrowse;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.TextBox textBoxAlbumName;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonSaveInstanceSettings;
        private System.Windows.Forms.Button buttonClearOutput;
    }
}

