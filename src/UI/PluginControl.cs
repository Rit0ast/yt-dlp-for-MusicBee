using System.Drawing;
using System.Windows.Forms;

namespace YtDlpForMusicBee.UI
{
    /// Control for plugin's UI
    public class PluginControl : UserControl
    {
        private Label _placeholderLabel;

        public PluginControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            _placeholderLabel = new Label
            {
                Text = "WIP",
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
            };

            Size = new Size(400, 200);
            Controls.Add(_placeholderLabel);
        }
    }
}
