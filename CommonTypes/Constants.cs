namespace CommonTypes
{
    public static class Constants
    {
        public const string PROJECT_FILE_EXTENSION = ".mqttlabproj";
        public const string ACCEPTED_SOURCE_FILE_EXTENSION = ".cs";

        public const string PROJECT_FILE_DIALOG_FILTER = $"Mqtt Lab Project | *{Constants.PROJECT_FILE_EXTENSION}";
        public const string SOURCE_FILE_DIALOG_FILTER = $"CSharp Source File | *{Constants.ACCEPTED_SOURCE_FILE_EXTENSION}";

        public const string MODEL_FILE_NAME = "Model.dll";
        public const string SOURCE_FILE_NAME = "Source.cs";
        public const string CONFIG_FILE_NAME = "Config.json";

        public const string MQTT_BROKER_ADDRESS = "broker.hivemq.com:8000/mqtt";
    }
}
