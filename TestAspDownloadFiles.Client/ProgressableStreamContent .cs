using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestAspDownloadFiles.Client
{
    public class ProgressableStreamContent : HttpContent
    {
        private readonly Stream _content;
        private readonly int _bufferSize;
        private readonly Action<LoadProgressInfo> _progress;
        private readonly long _totalBytes;

        public ProgressableStreamContent(
            Stream content,
            long totalBytes,
            int bufferSize,
            Action<LoadProgressInfo> progress)
        {
            _content = content;
            _bufferSize = bufferSize;
            _progress = progress;
            _totalBytes = totalBytes;
        }


        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext? context)
        {
            var buffer = new byte[_bufferSize];
            long uploaded = 0;
            long lastReportedBytes = 0;
            int read;
            var stopwatch = Stopwatch.StartNew();

            while ((read = await _content.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                await stream.WriteAsync(buffer, 0, read);
                uploaded += read;

                long delta = uploaded - lastReportedBytes;
                lastReportedBytes = uploaded;

                double speedKb =
                    uploaded / 1024d / stopwatch.Elapsed.TotalSeconds;

                int progress =
                    (int)(uploaded * 100 / _totalBytes);
                progress = Math.Min(100, progress);
                LoadProgressInfo info = new LoadProgressInfo
                {
                    LoadedKBytes = (int)uploaded / 1024,
                    Percent = progress,
                    SpeedKbs = speedKb
                };

                await Task.Delay(1);
                _progress?.Invoke(info);
            }
        }

        protected override bool TryComputeLength(out long length)
        {
            length = _totalBytes;
            return true;
        }
    }
}
