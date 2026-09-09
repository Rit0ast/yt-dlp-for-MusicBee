using System;

namespace YtDlpForMusicBee.Core
{
    public class RunProcessResult
    {
        public bool TimedOut { get; set; }
        public int ExitCode { get; set; }
        public string StandardOutput { get; set; }
        public string StandardError { get; set; }
    }
    public class ToolResolver
    {
        private const int TimeoutMilliseconds = 100;
        public string YtDlpPath { get; private set; }
        public string FfmpegPath { get; private set; }
        public bool YtDlpAvailable { get; private set; }
        public bool FfmpegAvailable { get; private set; }

        // Resolve the path for both YtDlp and Ffmpeg, then verify that they can be run.
        public void Resolve()
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        // Resolve the path for exeName, then verify that is available to run.
        private string ResolveTool(string exeName)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        // Verify that the tool runs by calling `-h` on it.
        private bool VerifyRuns(string path)
        {
            // TODO: implement
            throw new NotImplementedException();
        }
        
        // Helper to run processes. Used by ResolveTool and VerifyRuns
        private RunProcessResult RunProcess(string fileName, string arguments, TimeSpan timeout)
        {
            // TODO: implement
            throw new NotImplementedException();
        }
    }
}