using CommonTypes.Models;
using MQTTnet;
using MQTTnet.Client;
using Newtonsoft.Json;
using ScottPlot;

namespace MqttLabStudent
{
    public partial class LabForm : Form
    {
        private readonly MqttFactory _factory;
        private readonly IMqttClient _client;
        private readonly Dictionary<string, (FormsPlot plot, SensorDataHandlerBase dataHandler)> _sensorDataHandlersByTopic = new();

        public LabForm()
        {
            InitializeComponent();

            _factory = new MqttFactory();
            _client = _factory.CreateMqttClient();
            _client.ApplicationMessageReceivedAsync += MessageReceivedAsync;
        }

        private async void ConnectToBrokerButton_Click(object sender, EventArgs e)
        {
            var mqttClientOptions = new MqttClientOptionsBuilder()
                .WithWebSocketServer(o => o.WithUri(BrokerAddressTextBox.Text))
                .WithKeepAlivePeriod(TimeSpan.FromMinutes(45))
                .Build();
            await _client.ConnectAsync(mqttClientOptions, CancellationToken.None);
            MessageBox.Show("Connected to broker.");
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            await _client.PublishStringAsync(SendTopicTextBox.Text, SendMessageTextBox.Text);
            MessageBox.Show("Message sent.");
        }

        private async void SubscribeButton_Click(object sender, EventArgs e)
        {
            var mqttSubscribeOptions = _factory.CreateSubscribeOptionsBuilder()
                .WithTopicFilter(f => f.WithTopic(SubscribeTopicTextBox.Text))
                .Build();
            await _client.SubscribeAsync(mqttSubscribeOptions);
            MessageBox.Show("Subscribed to the topic.");
        }

        private async Task MessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
        {
            var topic = arg.ApplicationMessage.Topic;
            var message = arg.ApplicationMessage.ConvertPayloadToString();
            var messageModel = JsonConvert.DeserializeObject<SensorDataMessageModel>(message);

            if (!_sensorDataHandlersByTopic.ContainsKey(topic))
            {
                var newDataHandler = messageModel.ChartType.GetSensorDataVisualizer();
                var newPlot = new FormsPlot();

                Invoke(() =>
                {
                    MonitorPlotsTablePanel.Controls.Add(new Label() { Text = topic, AutoSize = true });
                    MonitorPlotsTablePanel.Controls.Add(newPlot);
                    MonitorPlotsTablePanel.ColumnCount++;
                });

                _sensorDataHandlersByTopic.Add(topic, (newPlot, newDataHandler));
            }

            (var plot, var dataHandler) = _sensorDataHandlersByTopic[topic];

            dataHandler.AddObservation(messageModel);
            dataHandler.Plot(plot.Plot);
            Invoke(() => plot.Render());
        }
    }
}