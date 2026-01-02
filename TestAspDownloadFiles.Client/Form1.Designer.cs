using System.Drawing;
using System.Windows.Forms;

namespace TestAspDownloadFiles.Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGetFiles = new Button();
            buttonDownload = new Button();
            comboBoxFiles = new ComboBox();
            label1 = new Label();
            buttonOpenFolder = new Button();
            progressBarDownload = new ProgressBar();
            labelDownloadProgress = new Label();
            labelSavedFilePath = new Label();
            textBoxUrl = new TextBox();
            label2 = new Label();
            buttonConnect = new Button();
            buttonUpload = new Button();
            progressBarUpload = new ProgressBar();
            buttonUpload2 = new Button();
            labelUploadProgress = new Label();
            SuspendLayout();
            // 
            // buttonGetFiles
            // 
            buttonGetFiles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonGetFiles.Enabled = false;
            buttonGetFiles.Location = new Point(12, 99);
            buttonGetFiles.Name = "buttonGetFiles";
            buttonGetFiles.Size = new Size(260, 23);
            buttonGetFiles.TabIndex = 0;
            buttonGetFiles.Text = "Загрузить список файлов";
            buttonGetFiles.UseVisualStyleBackColor = true;
            buttonGetFiles.Click += buttonGetFiles_Click;
            // 
            // buttonDownload
            // 
            buttonDownload.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonDownload.Enabled = false;
            buttonDownload.Location = new Point(12, 197);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(260, 23);
            buttonDownload.TabIndex = 1;
            buttonDownload.Text = "Скачать файл";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // comboBoxFiles
            // 
            comboBoxFiles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxFiles.Enabled = false;
            comboBoxFiles.FormattingEnabled = true;
            comboBoxFiles.Location = new Point(12, 149);
            comboBoxFiles.Name = "comboBoxFiles";
            comboBoxFiles.Size = new Size(260, 23);
            comboBoxFiles.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(12, 128);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 3;
            label1.Text = "Доступные файлы:";
            // 
            // buttonOpenFolder
            // 
            buttonOpenFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonOpenFolder.Enabled = false;
            buttonOpenFolder.Location = new Point(12, 393);
            buttonOpenFolder.Name = "buttonOpenFolder";
            buttonOpenFolder.Size = new Size(260, 23);
            buttonOpenFolder.TabIndex = 4;
            buttonOpenFolder.Text = "Открыть папку с файлом";
            buttonOpenFolder.UseVisualStyleBackColor = true;
            buttonOpenFolder.Click += buttonOpenFolder_Click;
            // 
            // progressBarDownload
            // 
            progressBarDownload.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarDownload.Location = new Point(12, 226);
            progressBarDownload.Name = "progressBarDownload";
            progressBarDownload.Size = new Size(260, 23);
            progressBarDownload.TabIndex = 5;
            // 
            // labelDownloadProgress
            // 
            labelDownloadProgress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelDownloadProgress.Location = new Point(12, 252);
            labelDownloadProgress.Name = "labelDownloadProgress";
            labelDownloadProgress.Size = new Size(260, 54);
            labelDownloadProgress.TabIndex = 6;
            labelDownloadProgress.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelSavedFilePath
            // 
            labelSavedFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSavedFilePath.Location = new Point(12, 306);
            labelSavedFilePath.Name = "labelSavedFilePath";
            labelSavedFilePath.Size = new Size(260, 84);
            labelSavedFilePath.TabIndex = 6;
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(12, 27);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(260, 23);
            textBoxUrl.TabIndex = 7;
            textBoxUrl.Text = "http://localhost:5090/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 8;
            label2.Text = "Адрес сервера:";
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(12, 56);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(260, 23);
            buttonConnect.TabIndex = 9;
            buttonConnect.Text = "Подключиться";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonUpload
            // 
            buttonUpload.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonUpload.Enabled = false;
            buttonUpload.Location = new Point(12, 435);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(260, 23);
            buttonUpload.TabIndex = 4;
            buttonUpload.Text = "Загрузить файл на сервер";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // progressBarUpload
            // 
            progressBarUpload.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBarUpload.Location = new Point(12, 493);
            progressBarUpload.Name = "progressBarUpload";
            progressBarUpload.Size = new Size(260, 23);
            progressBarUpload.TabIndex = 5;
            // 
            // buttonUpload2
            // 
            buttonUpload2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonUpload2.Enabled = false;
            buttonUpload2.Location = new Point(12, 464);
            buttonUpload2.Name = "buttonUpload2";
            buttonUpload2.Size = new Size(260, 23);
            buttonUpload2.TabIndex = 4;
            buttonUpload2.Text = "Загрузить c отображением прогресса";
            buttonUpload2.UseVisualStyleBackColor = true;
            buttonUpload2.Click += buttonUpload2_Click;
            // 
            // labelUploadProgress
            // 
            labelUploadProgress.Location = new Point(12, 519);
            labelUploadProgress.Name = "labelUploadProgress";
            labelUploadProgress.Size = new Size(260, 46);
            labelUploadProgress.TabIndex = 10;
            labelUploadProgress.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 581);
            Controls.Add(labelUploadProgress);
            Controls.Add(buttonConnect);
            Controls.Add(label2);
            Controls.Add(textBoxUrl);
            Controls.Add(labelSavedFilePath);
            Controls.Add(labelDownloadProgress);
            Controls.Add(progressBarUpload);
            Controls.Add(progressBarDownload);
            Controls.Add(buttonUpload2);
            Controls.Add(buttonUpload);
            Controls.Add(buttonOpenFolder);
            Controls.Add(label1);
            Controls.Add(comboBoxFiles);
            Controls.Add(buttonDownload);
            Controls.Add(buttonGetFiles);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(300, 620);
            MinimumSize = new Size(300, 600);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Скачивание файлов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGetFiles;
        private Button buttonDownload;
        private ComboBox comboBoxFiles;
        private Label label1;
        private Button buttonOpenFolder;
        private ProgressBar progressBarDownload;
        private Label labelDownloadProgress;
        private Label labelSavedFilePath;
        private TextBox textBoxUrl;
        private Label label2;
        private Button buttonConnect;
        private Button buttonUpload;
        private ProgressBar progressBarUpload;
        private Button buttonUpload2;
        private Label labelUploadProgress;
    }
}
