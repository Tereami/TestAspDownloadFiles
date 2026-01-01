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
            progressBar1 = new ProgressBar();
            labelDownloadProgress = new Label();
            labelSavedFilePath = new Label();
            textBoxUrl = new TextBox();
            label2 = new Label();
            buttonConnect = new Button();
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
            buttonOpenFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonOpenFolder.Enabled = false;
            buttonOpenFolder.Location = new Point(12, 376);
            buttonOpenFolder.Name = "buttonOpenFolder";
            buttonOpenFolder.Size = new Size(260, 23);
            buttonOpenFolder.TabIndex = 4;
            buttonOpenFolder.Text = "Открыть папку с файлом";
            buttonOpenFolder.UseVisualStyleBackColor = true;
            buttonOpenFolder.Click += buttonOpenFolder_Click;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(12, 226);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(260, 23);
            progressBar1.TabIndex = 5;
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
            labelSavedFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelSavedFilePath.Location = new Point(12, 306);
            labelSavedFilePath.Name = "labelSavedFilePath";
            labelSavedFilePath.Size = new Size(260, 67);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 411);
            Controls.Add(buttonConnect);
            Controls.Add(label2);
            Controls.Add(textBoxUrl);
            Controls.Add(labelSavedFilePath);
            Controls.Add(labelDownloadProgress);
            Controls.Add(progressBar1);
            Controls.Add(buttonOpenFolder);
            Controls.Add(label1);
            Controls.Add(comboBoxFiles);
            Controls.Add(buttonDownload);
            Controls.Add(buttonGetFiles);
            MaximumSize = new Size(540, 450);
            MinimumSize = new Size(300, 350);
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
        private ProgressBar progressBar1;
        private Label labelDownloadProgress;
        private Label labelSavedFilePath;
        private TextBox textBoxUrl;
        private Label label2;
        private Button buttonConnect;
    }
}
