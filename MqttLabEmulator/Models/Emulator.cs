using CommonTypes;
using CommonTypes.Interfaces;
using CommonTypes.Models;
using CommonTypes.ProjectModels;
using MqttLabEmulator.Helpers;
using MQTTnet;
using MQTTnet.Client;
using Newtonsoft.Json;
using System.Reflection;

namespace MqttLabEmulator.Models
{
    public class Emulator : IDisposable
    {
        private readonly Guid _id;
        private readonly LabProject _config;
        private readonly IModel _model;
        private readonly MqttFactory _factory;
        private readonly IMqttClient _client;

        private List<(VisualizerBase visualizer, MethodInfo dataProvider)> _visualizationItemsMap = new();
        private List<(SensorDataProviderInfo sensorInfo, MethodInfo dataProvider)> _sensorItemsMap = new();
        private Dictionary<string, MethodInfo> _controlTopicHandlerMap = new();

        public Emulator(LabProject config, IModel model)
        {
            _id = Guid.NewGuid();
            _config = config;
            _model = model;

            _factory = new MqttFactory();
            _client = _factory.CreateMqttClient();
        }

        public ICollection<HelpInfo> GetControlHelpers()
        {
            return _config?.ControlItemInfos.Select(control => new HelpInfo()
            {
                Topic = GetGlobalTopic(control.Topic),
                Description = control.Description,
            }).ToArray() ?? Array.Empty<HelpInfo>();
        }

        public ICollection<HelpInfo> GetSensorHelpers()
        {
            return _config?.SensorDataProviderInfos.Select(sensor => new HelpInfo()
            {
                Topic = GetGlobalTopic(sensor.Topic),
                Description = sensor.Description,
            }).ToArray() ?? Array.Empty<HelpInfo>();
        }

        public async Task Init(TableLayoutPanel uiWrapper)
        {
            var mqttClientOptions = new MqttClientOptionsBuilder()
                .WithWebSocketServer(o => o.WithUri(Constants.MQTT_BROKER_ADDRESS))
                .WithKeepAlivePeriod(TimeSpan.FromMinutes(45))
                .Build();
            await _client.ConnectAsync(mqttClientOptions, CancellationToken.None);

            _client.ApplicationMessageReceivedAsync += MessageReceivedAsync;
            uiWrapper.RowCount = _config.EmulatorVisualizationItemInfos.Count;

            var modelMethodsMap = _model.GetType().GetMethods().ToDictionary(method => method.Name, method => method);
            foreach (var visualizationItem in _config.EmulatorVisualizationItemInfos)
            {
                var visualizer = visualizationItem.VisualizerType.CreateVisualizer();
                var info = new Label() { Text = visualizationItem.Description, AutoSize = true };

                uiWrapper.Controls.Add(info);
                uiWrapper.Controls.Add(visualizer.Control);

                _visualizationItemsMap.Add((visualizer, modelMethodsMap[visualizationItem.DataProvider]));
            }

            foreach (var sensorInfo in _config.SensorDataProviderInfos)
            {
                _sensorItemsMap.Add((sensorInfo, modelMethodsMap[sensorInfo.Provider]));
            }

            foreach(var controlInfo in _config.ControlItemInfos)
            {
                var globalTopic = GetGlobalTopic(controlInfo.Topic);

                _controlTopicHandlerMap.Add(globalTopic, modelMethodsMap[controlInfo.Handler]);

                var mqttSubscribeOptions = _factory.CreateSubscribeOptionsBuilder()
                    .WithTopicFilter(f => f.WithTopic(globalTopic))
                    .Build();
                await _client.SubscribeAsync(mqttSubscribeOptions);
            }
        }

        public void Run()
        {
            UpdateModelLoop();
            SendSensorsDataLoop();
            VisualizationLoop();
        }

        private async void VisualizationLoop()
        {
            while (true)
            {
                foreach (var visualizationItem in _visualizationItemsMap)
                {
                    var value = visualizationItem.dataProvider.Invoke(_model, new object[] { });
                    visualizationItem.visualizer.SetValue(value);
                }

                await Task.Delay(100);
            }
        }

        private async void UpdateModelLoop()
        {
            var previousUpdateTime = DateTime.Now;

            while (true)
            {
                var lastUpdateTime = DateTime.Now;
                var delta = (lastUpdateTime - previousUpdateTime).TotalMilliseconds;

                _model.Update(delta);
                await Task.Delay(100);

                previousUpdateTime = lastUpdateTime;
            }
        }

        private async void SendSensorsDataLoop()
        {
            while (true)
            {
                foreach(var sensorItem in _sensorItemsMap)
                {
                    var sensorData = sensorItem.dataProvider.Invoke(_model, new object[] { });
                    var topic = GetGlobalTopic(sensorItem.sensorInfo.Topic);

                    var message = new SensorDataMessageModel()
                    {
                        Timestamp = DateTime.Now,
                        Value = sensorData,
                        ChartType = sensorItem.sensorInfo.ChartType
                    };
                    var messageJson = JsonConvert.SerializeObject(message);

                    await _client.PublishStringAsync(topic, messageJson);
                }
                await Task.Delay(100);
            }
        }

        private async Task MessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
        {
            if(_controlTopicHandlerMap.TryGetValue(arg.ApplicationMessage.Topic, out var handler))
            {
                var message = arg.ApplicationMessage.ConvertPayloadToString();
                var args = GetControlHandlerArgs(message, handler);

                handler.Invoke(_model, args);
            }
        }

        private object[] GetControlHandlerArgs(string message, MethodInfo handler)
        {
            if(string.IsNullOrWhiteSpace(message))
            {
                return new object[] { };
            }

            var neededValueType = handler.GetParameters()[0].ParameterType;
            var value = Convert.ChangeType(message, neededValueType);

            return new object[] { value };
        }

        private string GetGlobalTopic(string localTopic)
        {
            return $"{_id}/{localTopic}";
        }

        public void Dispose()
        {
            _client.ApplicationMessageReceivedAsync -= MessageReceivedAsync;
            _client.Dispose();
        }
    }
}
