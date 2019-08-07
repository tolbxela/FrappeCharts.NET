using Newtonsoft.Json;
namespace Tolbxela.Frappe.Charts
{
    public class BarOptions
    {
        // Min: 0, Max: 1, Default: 0.5
        [JsonProperty("spaceRatio")]
        public double SpaceRatio { get; set; } = 0.5;

        [JsonProperty("stacked")]        
        public bool? Stacked { get; set; }
    }
}