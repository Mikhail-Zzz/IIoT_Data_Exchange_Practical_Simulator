namespace MqttLabEmulator.Models
{
    public abstract class VisualizerBase
    {
        public Control Control { get; }

        public VisualizerBase(Control control)
        {
            Control = control;
        }

        public abstract void SetValue(object value);
    }

    public class OneLineVisualizer : VisualizerBase
    {
        private Action<Control, object> _valueSetter;

        public OneLineVisualizer(Control control, Action<Control, object> valueSetter) : base(control)
        {
            _valueSetter = valueSetter;
        }

        public override void SetValue(object value)
        {
            _valueSetter(Control, value);
        }
    }
}
