using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.Frappe.Charts
{
    public class ChartOptions
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("data")]
        public ChartData Data { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChartTypes? Type { get; set; } = null;
        
        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("colors")]
        public IList<string> Colors { get; set; }

        [JsonProperty("axisOptions")]
        public AxisOptions AxisOptions { get; set; }

        [JsonProperty("tooltipOptions")]
        public TooltipOptions TooltipOptions { get; set; }

        [JsonProperty("barOptions")]
        public BarOptions BarOptions { get; set; }

        [JsonProperty("lineOptions")]
        public LineOptions LineOptions { get; set; }

        [JsonProperty("valuesOverPoints")]
        public bool? ValuesOverPoints { get; set; }

        [JsonProperty("isNavigable")]
        public bool? IsNavigable { get; set; }
    }
}