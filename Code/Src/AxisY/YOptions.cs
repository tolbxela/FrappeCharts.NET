using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.Frappe.Charts
{
    public class YOptions
    {
        // default: 'right'
        [JsonProperty("labelPos")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LabelPositions LabelPos { get; set; } = LabelPositions.Right;
    }
}