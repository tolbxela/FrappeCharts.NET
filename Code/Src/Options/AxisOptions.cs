using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.Frappe.Charts
{
    public class AxisOptions
    {
        [JsonProperty("xAxisMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AxisModes XAxisMode { get; set; }

        [JsonProperty("yAxisMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AxisModes YAxisMode { get; set; }

        [JsonProperty("xIsSeries")]
        public bool? XIsSeries { get; set; }

    }
}