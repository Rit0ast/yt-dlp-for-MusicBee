using System;
using System.IO;
using System.Xml.Serialization;

namespace YtDlpForMusicBee.Core
{
    [Serializable]
    public class PluginSettings
    {
        private const string SettingsFileName = "mb_YtDlpForMusicBee_settings.xml";
        public string YtDlpPath { get; set; }
        public string FfmpegPath { get; set; }
        public bool AudioOnly { get; set; }
        public string Format { get; set; }
        public string OutputLocation { get; set; }
        public string OutputTemplate { get; set; }
        public bool OptionsPanelExpanded { get; set; }

        public PluginSettings()
        {
            // First run defaults, also used as fallback if settings file can't be found/read
            Format = "mp3";
            OutputTemplate = "%(title)s.%(ext)s";
            OptionsPanelExpanded = true;
        }

        // Load PluginSettings from disk. If no settings file exists, return PluginSettings
        // with default values.
        public static PluginSettings Load(string storageFolder)
        {
            string path = Path.Combine(storageFolder, SettingsFileName);

            if (!File.Exists(path))
            {
                return new PluginSettings();
            }
            try
            {
                var serializer = new XmlSerializer(typeof(PluginSettings));
                using (var reader = new StreamReader(path))
                {
                    return (PluginSettings)serializer.Deserialize(reader);
                }
            }
            catch (Exception)
            {
                // File is corrupt/unreadable
                return new PluginSettings();
            }
        }

        // Save the current instance's settings to disk.
        public void Save(string storageFolder)
        {
            Directory.CreateDirectory(storageFolder);
            string path = Path.Combine(storageFolder, SettingsFileName);

            var serializer = new XmlSerializer(typeof(PluginSettings));
            using (var writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, this);
            }
        }
    }
}
