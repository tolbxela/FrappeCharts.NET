using Newtonsoft.Json;

namespace Tolbxela.Frappe.Charts
{
    public class YMarker
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("options")]
        public YOptions Options { get; set; }
    }
}