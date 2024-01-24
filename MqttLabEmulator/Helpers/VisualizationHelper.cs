using CommonTypes.ProjectModels;
using MqttLabEmulator.Models;

namespace MqttLabEmulator.Helpers
{
    public static class VisualizationHelper
    {
        public static VisualizerBase CreateVisualizer(this EmulatorVisualizerTypes visualizerType)
        {
            return visualizerType switch
            {
                EmulatorVisualizerTypes.Text => new OneLineVisualizer(new Label(), (label, value) => label.Text = value.ToString()),
            };
        }
    }
}
