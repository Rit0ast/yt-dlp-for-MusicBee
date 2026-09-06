using System;
using System.Reflection;
using static MusicBeePlugin.Plugin;

namespace YtDlpForMusicBee
{
    public partial class Plugin
    {
        private MusicBeeApiInterface mbApiInterface;
        private PluginInfo about = new PluginInfo();
        public PluginInfo Initialise(IntPtr apiInterfacePtr)
        {
            Assembly thisAssembly = typeof(Plugin).Assembly;

            mbApiInterface = new MusicBeeApiInterface();
            mbApiInterface.Initialise(apiInterfacePtr);

            // PluginInfo
            about.PluginInfoVersion = PluginInfoVersion;
            about.Type = PluginType.General;
            about.Name = thisAssembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;
            about.Description = thisAssembly.GetCustomAttribute<AssemblyDescriptionAttribute>().Description;
            about.Author = thisAssembly.GetCustomAttribute<AssemblyCompanyAttribute>().Company;
            about.TargetApplication = "";
            about.VersionMajor = (short) thisAssembly.GetName().Version.Major;
            about.VersionMinor = (short) thisAssembly.GetName().Version.Minor;
            about.Revision = (short) thisAssembly.GetName().Version.Revision;
            about.MinInterfaceVersion = MinInterfaceVersion;
            about.MinApiRevision = MinApiRevision;
            about.ReceiveNotifications = ReceiveNotificationFlags.PlayerEvents;
            about.ConfigurationPanelHeight = 0;
            return about;
        }

        public bool Configure(IntPtr panelHandle)
        {
            return false;
        }
       
        public void SaveSettings()
        {
        }

        public void Close(PluginCloseReason reason)
        {
        }
    }

    
}