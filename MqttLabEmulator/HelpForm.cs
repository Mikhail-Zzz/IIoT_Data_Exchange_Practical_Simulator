using MqttLabEmulator.Models;

namespace MqttLabEmulator
{
    public partial class HelpForm : Form
    {
        public HelpForm(ICollection<HelpInfo> helpers, string formTitle)
        {
            InitializeComponent();

            Text = formTitle;
            HelpersDataGridView.DataSource = helpers;
        }
    }
}
