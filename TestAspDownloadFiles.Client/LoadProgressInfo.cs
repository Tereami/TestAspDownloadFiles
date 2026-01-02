using System;

namespace TestAspDownloadFiles.Client
{
    public class LoadProgressInfo
    {
        //public int TotalKBytes { get; set; }

        public int LoadedKBytes { get; set; }

        public int Percent { get; set; }

        public double SpeedKbs { get; set; }

        public TimeSpan Remaining { get; set; }
    }
}
