using Newtonsoft.Json;

namespace Tolbxela.Frappe.Charts
{
    public class YRegion
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("options")]
        public YOptions Options { get; set; }
    }
}