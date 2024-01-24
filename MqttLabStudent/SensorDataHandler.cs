using CommonTypes.Models;
using ScottPlot;

namespace MqttLabStudent
{
    public abstract class SensorDataHandlerBase
    {
        protected readonly List<SensorDataMessageModel> _data = new();

        public void AddObservation(SensorDataMessageModel model)
        {
            _data.Add(model);
        }

        public abstract void Plot(Plot plot);
    }

    public class InlineSensorDataHandler : SensorDataHandlerBase
    {
        public readonly Action<Plot, IEnumerable<SensorDataMessageModel>> _plotDataHandler;

        public InlineSensorDataHandler(Action<Plot, IEnumerable<SensorDataMessageModel>> plotDataHandler)
        {
            _plotDataHandler = plotDataHandler;
        }

        public override void Plot(Plot plot)
        {
            _plotDataHandler(plot, _data);
        }
    }
}
