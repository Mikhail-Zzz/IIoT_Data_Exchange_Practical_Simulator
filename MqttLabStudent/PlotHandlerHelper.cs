using CommonTypes.ProjectModels;

namespace MqttLabStudent
{
    public static class PlotHandlerHelper
    {
        public static SensorDataHandlerBase GetSensorDataVisualizer(this SensorDataChartTypes chartType)
        {
            return chartType switch
            {
                SensorDataChartTypes.Signal => new InlineSensorDataHandler((plot, data) =>
                {
                    var minTime = data.First().Timestamp;
                    var xs = data.Select(item => (item.Timestamp - minTime).TotalSeconds).ToArray();
                    var ys = data.Select(item => Convert.ToDouble(item.Value)).ToArray();

                    plot.Clear();
                    plot.AddSignalXY(xs, ys);
                }),
            };
        }
    }
}
