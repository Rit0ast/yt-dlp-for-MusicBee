using System;

namespace YtDlpForMusicBee.Core
{
    [Serializable]
    public class PluginSettings
    {
        public string YtDlpPath { get; set; }
        public string FfmpegPath { get; set; }

        public bool AudioOnly { get; set; }
        public string Format { get; set; }
        public string OutputLocation { get; set; }
        public string OutputTemplate { get; set; }

        // Load PluginSettings from disk. If no settings file exists, return PluginSettings
        // with default values.
        public static PluginSettings Load(string storageFolder)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        // Save the current instance's settings to disk.
        public void Save(string storageFolder)
        {
            // TODO: implement
            throw new NotImplementedException();
        }
    }
}
