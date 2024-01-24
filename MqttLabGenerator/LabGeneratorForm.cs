using CommonTypes;
using CommonTypes.Interfaces;
using CommonTypes.ProjectModels;
using MqttLabGenerator.Services;
using Newtonsoft.Json;
using System.ComponentModel;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.Loader;

namespace MqttLabGenerator
{
    public partial class LabGeneratorForm : Form
    {
        private readonly ModelCompiler _compiler = new ModelCompiler();
        private readonly LabProject _project = new LabProject();

        public LabGeneratorForm()
        {
            InitializeComponent();

            ControlItemsDataGridView.DataSource = _project.ControlItemInfos;
            SensorDataProvidersDataGridView.DataSource = _project.SensorDataProviderInfos;
            VisualizationItemsDataGridView.DataSource = _project.EmulatorVisualizationItemInfos;

            SensorDataChartTypeComboBox.DataSource = Enum.GetValues(typeof(SensorDataChartTypes));
            VisualizationItemTypeComboBox.DataSource = Enum.GetValues(typeof(EmulatorVisualizerTypes));
        }

        private void LoadModelFileButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.DefaultExt = Constants.ACCEPTED_SOURCE_FILE_EXTENSION;
                dialog.Filter = Constants.SOURCE_FILE_DIALOG_FILTER;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var success = _compiler.Compile(dialog.FileName, _project, out var errors);
                    CompilationErrorsTextBox.Text = success ? "Compilation successful" : string.Join("\n", errors);

                    if (!success)
                    {
                        MessageBox.Show("Compilation failed.");
                        return;
                    }

                    var modelAssembly = Assembly.LoadFile(_project.ModelFilePath);
                    var modelType = modelAssembly.GetTypes().FirstOrDefault(type => typeof(IModel).IsAssignableFrom(type));

                    if (modelType == null)
                    {
                        MessageBox.Show("Model file must follow the template.");
                        return;
                    }

                    LoadModelFileButton.Enabled = false;

                    ParseModel(modelType);

                    AddProjectItemsTabControl.Enabled = true;
                    SaveProjectButton.Enabled = true;
                }
            }
        }

        private void ParseModel(Type type)
        {
            var interfaceType = typeof(IModel);
            var appropriateMethods = type.GetMethods()
                .Where(method => method.DeclaringType == type && !method.ReflectedType.GetInterfaceMap(interfaceType).TargetMethods.Contains(method))
                .ToArray();

            var possibleControlMethods = appropriateMethods
                .Where(method => method.ReturnType == typeof(void))
                .ToArray();
            var possibleSensorDataProviders = appropriateMethods
                .Where(method => method.ReturnType != typeof(void) && method.GetParameters().Length == 0)
                .ToArray();

            ControlMethodsComboBox.Items.AddRange(possibleControlMethods);
            SensorDataProvidersComboBox.Items.AddRange(possibleSensorDataProviders);
            VisualizationItemDataProviderComboBox.Items.AddRange(possibleSensorDataProviders);

            ControlMethodsComboBox.SelectedIndex = 0;
            SensorDataProvidersComboBox.SelectedIndex = 0;
            VisualizationItemDataProviderComboBox.SelectedIndex = 0;
        }

        private void SaveProjectButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.DefaultExt = Constants.PROJECT_FILE_EXTENSION;
                dialog.FileName = _project.ProjectName;
                dialog.Filter = Constants.PROJECT_FILE_DIALOG_FILTER;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    File.Delete(dialog.FileName);

                    _project.ConfigFilePath = Path.Combine(_project.ProjectPath, Constants.CONFIG_FILE_NAME);
                    var json = JsonConvert.SerializeObject(_project);
                    File.WriteAllText(_project.ConfigFilePath, json);

                    ZipFile.CreateFromDirectory(_project.ProjectPath, dialog.FileName);
                    MessageBox.Show("Saved");
                }
            }
        }

        private void AddControlItemButton_Click(object sender, EventArgs e)
        {
            var controlItemInfo = new ControlItemInfo()
            {
                Handler = (ControlMethodsComboBox.SelectedItem as MethodInfo).Name,
                Topic = ControlTopicTextBox.Text,
                Description = ControlDescriptionTextBox.Text,
            };
            _project.ControlItemInfos.Add(controlItemInfo);
        }

        private void AddSensorDataProviderButton_Click(object sender, EventArgs e)
        {
            var sensorDataProviderInfo = new SensorDataProviderInfo()
            {
                Provider = (SensorDataProvidersComboBox.SelectedItem as MethodInfo).Name,
                ChartType = (SensorDataChartTypes)SensorDataChartTypeComboBox.SelectedItem,
                Topic = SensorDataTopicTextBox.Text,
                Description = SensorDataDescriptionTextBox.Text,
            };
            _project.SensorDataProviderInfos.Add(sensorDataProviderInfo);
        }

        private void AddVisualizationItemButton_Click(object sender, EventArgs e)
        {
            var visualizationItemInfo = new EmulatorVisualizationItemInfo()
            {
                DataProvider = (VisualizationItemDataProviderComboBox.SelectedItem as MethodInfo).Name,
                VisualizerType = (EmulatorVisualizerTypes)VisualizationItemTypeComboBox.SelectedItem,
                Description = VisualizationItemDescriptionTextBox.Text,
            };
            _project.EmulatorVisualizationItemInfos.Add(visualizationItemInfo);
        }

        private void ControlItemsDataGridViewContextMenuStripDeleteItemMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedItemsFromCollection<ControlItemInfo>(ControlItemsDataGridView);
        }

        private void SensorDataProvidersDataGridViewContextMenuStripDeleteItemMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedItemsFromCollection<SensorDataProviderInfo>(SensorDataProvidersDataGridView);
        }

        private void VisualizationItemsDataGridViewDeleteMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSelectedItemsFromCollection<EmulatorVisualizationItemInfo>(VisualizationItemsDataGridView);
        }

        private void DeleteSelectedItemsFromCollection<T>(DataGridView dataGridView)
        {
            var dataItems = dataGridView.SelectedCells.OfType<DataGridViewCell>()
                .Select(cell => cell.OwningRow)
                .Distinct()
                .Select(row => row.DataBoundItem)
                .OfType<T>()
                .ToArray();

            foreach (var item in dataItems)
            {
                (dataGridView.DataSource as BindingList<T>).Remove(item);
            }

            dataGridView.ClearSelection();
        }
    }
}