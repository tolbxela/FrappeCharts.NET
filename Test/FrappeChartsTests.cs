using System;
using Newtonsoft.Json;
using Tolbxela.Frappe.Charts;
using Xunit;

namespace Test
{
    public class FrappeChartsTests
    {
        const string ChartName = "Chart";
        const string Selector = "#Selector";

        public FrappeChartsTests()
        {
        }

        [Fact]
        public void FrappeChartsTest_NotNull()
        {
            var chart = new FrappeChart(Selector, ChartName, formatJson: false);
            Assert.NotNull(chart);
        }

        [Fact]
        public void FrappeChartsTest_Json()
        {
            var chart = new FrappeChart(Selector, ChartName, formatJson: false);
            var json = chart.ToString();
            Assert.False(string.IsNullOrWhiteSpace(json));
        }

        [Fact]
        public void FrappeChartsTest_EmptyOptions()
        {
            var options = new ChartOptions();

            var jsonOptions = JsonConvert.SerializeObject(
                    options,
                    Formatting.None,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    }
                );

            var jsonOptionsSample = "{}";

            Assert.Equal(jsonOptionsSample, jsonOptions);
        }

        [Fact]
        public void FrappeChartsTest_EmptyChart()
        {
            var options = new ChartOptions();

            var chart = new FrappeChart(Selector, ChartName, formatJson: false) {
                Options = options
            };
            var chartJson = chart.ToString();
            var jsonOptionsSample = "{}";
            var chartSample = $"var {ChartName} = new frappe.Chart(\"{Selector}\", {jsonOptionsSample});" + Environment.NewLine;

            Assert.Equal(chartSample, chartJson);
        }
    }
}