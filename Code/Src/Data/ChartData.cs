using System.Collections.Generic;
using Newtonsoft.Json;

namespace Tolbxela.Frappe.Charts
{
    public class ChartData
    {
        [JsonProperty("labels")]
        public IList<string> Labels { get; set; }

        [JsonProperty("datasets")]
        public IList<Dataset> Datasets { get; set; }

        [JsonProperty("yMarkers")]
        public IList<YMarker> YMarkers { get; set; }

        [JsonProperty("yRegions")]
        public IList<YRegion> YRegions { get; set; }

    }
}