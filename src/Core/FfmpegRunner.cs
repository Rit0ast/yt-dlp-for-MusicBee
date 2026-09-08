using System;

namespace YtDlpForMusicBee.Core
{
    public class FfmpegResult
    {
        public bool Success { get; set; }
        public int ExitCode { get; set; }
        public string OutputFilePath { get; set; }
        public string ErrorMessage { get; set; }
    }

    // Wrapper that runs a single ffmpeg query for cases that yt-dlp can't cover.
    public class FfmpegRunner
    {
        private readonly string _ffmpegPath;

        public FfmpegRunner(string ffmpegPath)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public FfmpegResult Convert(string inputPath, string outputPath, string extraArgs)
        {
            // TODO: implement
            throw new NotImplementedException();
        }
    }
}
