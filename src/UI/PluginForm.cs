using System.Windows.Forms;

namespace YtDlpForMusicBee.UI
{
    /// PluginForm, only one instance of this is created
    public class PluginForm : Form
    {
        private PluginControl _pluginControl;

        public PluginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            _pluginControl = new PluginControl { Dock = DockStyle.Fill };

            Text = "yt-dlp for MusicBee";
            ClientSize = _pluginControl.Size;
            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = false;
            MinimizeBox = true;
            StartPosition = FormStartPosition.CenterParent;

            Controls.Add(_pluginControl);

            FormClosing += PluginForm_FormClosing;
        }

        private void PluginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Keep the instance alive, only hide/show
            e.Cancel = true;
            Hide();
        }
    }
}
