using Newtonsoft.Json;

namespace Tolbxela.Frappe.Charts
{
    public class LineOptions
    {
        // default: 4
        [JsonProperty("dotSize")]
        public int DotSize { get; set; } = 4;

        // default: 0
        [JsonProperty("hideDots")]
        public bool? HideDots { get; set; }

        // default: 0
        [JsonProperty("hideLine")]
        public bool? HideLine { get; set; }

        // default: 0
        [JsonProperty("heatline")]
        public bool? Heatline { get; set; }

        // default: 0
        [JsonProperty("regionFill")]
        public bool? RegionFill { get; set; }
    }
}