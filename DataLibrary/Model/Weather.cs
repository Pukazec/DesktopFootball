using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DataLibrary.Model
{
    public class Weather
    {
        public enum DescriptionE
        {
            [EnumMember(Value = "Clear Night")]
            ClearNight,
            Cloudy,
            [EnumMember(Value = "Partly Cloudy")]
            PartlyCloudy,
            [EnumMember(Value = "Partly Cloudy Night")]
            PartlyCloudyNight,
            Sunny
        };


        [JsonProperty("humidity")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Humidity { get; set; }

        [JsonProperty("temp_celsius")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long TempCelsius { get; set; }

        [JsonProperty("temp_farenheit")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long TempFarenheit { get; set; }

        [JsonProperty("wind_speed")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long WindSpeed { get; set; }

        [JsonProperty("description")]
        [JsonConverter(typeof(StringEnumConverter))]
        public DescriptionE Description { get; set; }
    }
}
