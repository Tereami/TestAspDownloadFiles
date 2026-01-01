using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAspDownloadFiles.Client
{
    public partial class Form1 : Form
    {
        private HttpClient _client;
        private string targetFolder = string.Empty;
        private string lastDownloadedFile = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonGetFiles_Click(object sender, System.EventArgs e)
        {

            comboBoxFiles.Items.Clear();

            string url = $"files/list";
            HttpResponseMessage response = await _client.GetAsync(url);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                labelDownloadProgress.Text = $"{response.StatusCode}: {ex.Message}";
                return;
            }

            string[]? files = await response.Content.ReadFromJsonAsync<string[]>();
            if (files == null || files.Length == 0)
            {
                labelDownloadProgress.Text = "Не удалось загрузить список файлов";
                return;
            }

            comboBoxFiles.Items.AddRange(files);
            comboBoxFiles.SelectedIndex = 0;
            labelSavedFilePath.Text = "";

            comboBoxFiles.Enabled = true;
            buttonDownload.Enabled = true;
        }

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            if (comboBoxFiles.SelectedItem == null)
                return;

            string filename = comboBoxFiles.SelectedItem.ToString()!;
            string url = $"files/download/{filename}";

            targetFolder = AppContext.BaseDirectory;
            lastDownloadedFile = Path.Combine(targetFolder, filename);

            await DownloadFileAsync(url, lastDownloadedFile);
        }

        private async Task DownloadFileAsync(string url, string targetPath)
        {
            progressBar1.Value = 0;
            labelDownloadProgress.Text = "Начинаю загрузку...";

            using HttpResponseMessage response = await _client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception ex)
            {
                labelDownloadProgress.Text = $"{response.StatusCode}: {ex.Message}";
                return;
            }

            long totalBytes = response.Content.Headers.ContentLength ?? -1;

            using Stream contentStream = await response.Content.ReadAsStreamAsync();
            using FileStream fileStream = new FileStream(
                targetPath, FileMode.Create, FileAccess.Write, FileShare.None);

            byte[] buffer = new byte[4096];
            long totalRead = 0;
            int read;

            var stopWatch = Stopwatch.StartNew();

            while ((read = await contentStream.ReadAsync(buffer)) > 0)
            {
                await fileStream.WriteAsync(buffer.AsMemory(0, read));
                totalRead += read;

                int progress = totalBytes > 0
                    ? (int)(totalRead * 100 / totalBytes) : 0;
                progressBar1.Value = progress;

                int speedKb = (int)(totalRead / 1024d / stopWatch.Elapsed.TotalSeconds);

                labelDownloadProgress.Text = $"Скачано {(int)(totalRead / 1024)} Кб из {(int)(totalBytes / 1024)} Кб\n{speedKb} Кб/сек";
                Application.DoEvents();
            }

            stopWatch.Stop();
            labelDownloadProgress.Text += "... Завершено!";
            labelSavedFilePath.Text = lastDownloadedFile;
            buttonOpenFolder.Enabled = true;
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            string argument = "/select, \"" + lastDownloadedFile + "\"";

            System.Diagnostics.Process.Start("explorer.exe", argument);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string url = textBoxUrl.Text;
            if (!url.EndsWith("/"))
                url += "/";
            _client = new HttpClient() { BaseAddress = new Uri(url) };
            buttonGetFiles.Enabled = true;
        }
    }
}
