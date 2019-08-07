using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Tolbxela.Frappe.Charts
{
    public class Dataset
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public IList<object> Values { get; set; }

        [JsonProperty("chartType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChartTypes? ChartType { get; set; } = null;
    }
}