using System;

namespace YtDlpForMusicBee.Core
{
    public class ToolResolver
    {
        public string YtDlpPath { get; private set; }
        public string FfmpegPath { get; private set; }

        public bool YtDlpAvailable;
        public bool FfmpegAvailable;

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
    }
}
