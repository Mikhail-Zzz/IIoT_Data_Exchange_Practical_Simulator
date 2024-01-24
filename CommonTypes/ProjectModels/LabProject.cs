using Newtonsoft.Json;
using System.ComponentModel;

namespace CommonTypes.ProjectModels
{
    public class LabProject
    {
        public string ProjectName { get; set; }
        [JsonIgnore]
        public string ProjectPath { get; set; }
        [JsonIgnore]
        public string SourceFilePath { get; set; }
        [JsonIgnore]
        public string ModelFilePath { get; set; }
        [JsonIgnore]
        public string ConfigFilePath { get; set; }
        public BindingList<ControlItemInfo> ControlItemInfos { get; private set; } = new();
        public BindingList<SensorDataProviderInfo> SensorDataProviderInfos { get; private set; } = new();
        public BindingList<EmulatorVisualizationItemInfo> EmulatorVisualizationItemInfos { get; private set; } = new();
    }
}
