using CommonTypes;
using CommonTypes.Interfaces;
using CommonTypes.ProjectModels;
using MqttLabEmulator.Models;
using Newtonsoft.Json;
using System.IO.Compression;
using System.Reflection;

namespace MqttLabEmulator
{
    public partial class EmulatorForm : Form
    {
        private Emulator _emulator;

        public EmulatorForm()
        {
            InitializeComponent();
        }

        private async void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.DefaultExt = Constants.PROJECT_FILE_EXTENSION;
                dialog.Filter = Constants.PROJECT_FILE_DIALOG_FILTER;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (_emulator != null)
                    {
                        _emulator.Dispose();
                        EmulatorPanel.Controls.Clear();
                    }

                    var tempFilesPath = Path.Combine(Environment.CurrentDirectory, "Temp", Guid.NewGuid().ToString());

                    Directory.CreateDirectory(tempFilesPath);
                    ZipFile.ExtractToDirectory(dialog.FileName, tempFilesPath);

                    var configFilePath = Path.Combine(tempFilesPath, Constants.CONFIG_FILE_NAME);
                    var projectConfigJson = File.ReadAllText(configFilePath);
                    var emulatorConfig = JsonConvert.DeserializeObject<LabProject>(projectConfigJson);

                    var modelFilePath = Path.Combine(tempFilesPath, Constants.MODEL_FILE_NAME);
                    var modelAssembly = Assembly.LoadFile(modelFilePath);
                    var modelType = modelAssembly.GetTypes().FirstOrDefault(type => typeof(IModel).IsAssignableFrom(type));

                    if (modelType == null)
                    {
                        MessageBox.Show("Project file contains no appropriate model.");
                        return;
                    }

                    var emulatorModel = Activator.CreateInstance(modelType) as IModel;

                    _emulator = new Emulator(emulatorConfig, emulatorModel);
                    await _emulator.Init(EmulatorPanel);

                    MessageBox.Show("Project loaded.");
                }
            }
        }

        private void RunModelMenuItem_Click(object sender, EventArgs e)
        {
            _emulator.Run();
        }

        private void ControlItemsHelpMenuItem_Click(object sender, EventArgs e)
        {
            var controlHelpers = _emulator.GetControlHelpers();
            new HelpForm(controlHelpers, "Control items helper").Show();
        }

        private void SensorItemsHelpMenuItem_Click(object sender, EventArgs e)
        {
            var sensorHelpers = _emulator.GetSensorHelpers();
            new HelpForm(sensorHelpers, "Sensor items helper").Show();
        }
    }
}