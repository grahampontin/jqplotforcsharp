using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using jqPlot;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            Chart c = new Chart();
            c.options.legend.show = true;
            c.options.legend.location = "se";
            c.options.stackSeries = true;
            c.options.series.Add(new SeriesOptions());
            c.options.series[0].renderer = Renders.BarRenderer;

            c.options.axes.Add(new AxesOptions());
            c.options.axes[0].AddTick("1.1","Test");

            var test = c.GetOptionsJSON();
        }
    }
}
