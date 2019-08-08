using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Tolbxela.Frappe.Charts;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var curDir = Directory.GetCurrentDirectory();
            Console.WriteLine($"Current Directory: {curDir}");
            try
            {
                var months = 12;

                var FileName = "democharts.js";

                Random r = new Random();

                var Data1 = new Dataset()
                {
                    Name = "Data 1",
                    ChartType = ChartTypes.line,
                    Values = Enumerable.Range(0, months)
                              .Select(x => r.Next(1000))
                              .Select(y => (object)y)
                              .ToArray()
                };

                var Data2 = new Dataset()
                {
                    Name = "Data 2",
                    ChartType = ChartTypes.line,
                    Values = Enumerable.Range(0, months)
                             .Select(x => r.Next(1000))
                             .Select(y => (object)y)
                             .ToArray()
                };


                var labels = Enumerable.Range(0, months)
                              .Select(i => DateTime.Now.AddMonths(i - months))
                              .Select(date => date.ToString("MMM yyyy"))
                              .ToArray();


                var lineOptions = new LineOptions()
                {
                    Heatline = true,
                    RegionFill = true,
                    DotSize = 5
                };

                var axisOption = new AxisOptions()
                {
                    XAxisMode = AxisModes.tick
                };

                var FrappeChart = new FrappeChart("#FrappeChart", "FrappeChart")
                {
                    Options = new ChartOptions()
                    {
                        Title = $"Chart Title",
                        Height = 350,
                        Data = new ChartData()
                        {
                            Labels = labels,
                            Datasets = new Dataset[] {
                               Data1,
                               Data2
                            }
                        },
                        Type = ChartTypes.line,
                        ValuesOverPoints = false,
                        LineOptions = lineOptions,
                        AxisOptions = axisOption,
                        Colors = new string[] { "#5bcaff", "#ff82d0" }                        
                    }
                };

                Console.WriteLine($"Saving Chart to file '{FileName}'");
                File.WriteAllText(FileName, FrappeChart.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Starting default browser with 'index.html'");
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = "index.html";
            proc.Start();
        }
    }
}
