using Newtonsoft.Json;
using Tolbxela.Json;

namespace Tolbxela.Frappe.Charts
{
    public class TooltipOptions
    {
        [JsonProperty("formatTooltipX")]
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string FormatTooltipX { get; set; }
        [JsonProperty("formatTooltipY")]
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string FormatTooltipY { get; set; }
    }
}