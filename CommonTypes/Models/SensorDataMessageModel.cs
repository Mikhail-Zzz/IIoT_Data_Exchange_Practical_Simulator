using CommonTypes.ProjectModels;

namespace CommonTypes.Models
{
    public class SensorDataMessageModel
    {
        public DateTime Timestamp { get; set; }
        public object Value { get; set; }
        public SensorDataChartTypes ChartType { get; set; }
    }
}
