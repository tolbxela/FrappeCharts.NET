using System;
using Newtonsoft.Json;

namespace Tolbxela.Frappe.Charts
{
    public class FrappeChart
    {
        public string ChartNameJS { get; set; } = "chart";
        public string HtmlSelector { get; set; }
        public ChartOptions Options { get; set; }

        public bool FormatJson { get; set; } = false;

        public FrappeChart(string htmlSelector, string ChartName = "chart", bool formatJson = false)
        {
            ChartNameJS = ChartName.Replace(" ", "_");
            HtmlSelector = htmlSelector;
        }

        public override string ToString()
        {
            var jsonChart = "";
            try
            {
                var jsonOptions = JsonConvert.SerializeObject(
                    Options,
                     (FormatJson) ? Formatting.Indented : Formatting.None,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    }
                );

                jsonChart = $"var {ChartNameJS} = new frappe.Chart(\"{HtmlSelector}\", {jsonOptions});" + Environment.NewLine;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return jsonChart;
        }
    }
}