using System;

namespace YtDlpForMusicBee.Core
{
    // Per download parameters, prefilled from last request.
    public class DownloadRequest
    {
        public string URL { get; set; }
        public bool AudioOnly { get; set; }
        public string OutputFormat { get; set; }
        public string OutputLocation { get; set; }
        public string OutputTemplate { get; set; }
    }

    public class YtDlpResult
    {
        public bool Success { get; set; }
        public int ExitCode { get; set; }
        public string OutputFilePath { get; set; }
        public string ErrorMessage { get; set; }
    }

    // Wrapper that runs a single yt-dlp query.
    public class YtDlpRunner
    {
        private readonly string _ytDlpPath;
        private readonly string _ffmpegPath;

        public YtDlpRunner(string ytDlpPath, string ffmpegPath)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        // Build a yt-dlp argument string using BuildArguments, then execute the request.
        public YtDlpResult Run(DownloadRequest request)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        // Build a yt-dlp argument string using a DownloadRequest
        private string BuildArguments(DownloadRequest request)
        {
            // TODO: implement
            throw new NotImplementedException();
        }
    }
}
