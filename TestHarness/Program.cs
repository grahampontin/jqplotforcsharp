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
            Chart c = new Chart("My Chart");
            c.options.legend.show = true;
            c.options.legend.location = "se";
            c.options.stackSeries = true;
            //c.options.series.Add(new SeriesOptions());
            //c.options.series[0].renderer = Renders.BarRenderer;

            //c.options.axes.Add(new AxesOptions());
            //c//.options.axes[0].AddTick("Tick1");
            //c.options.axes[0].AddTick("Tick2");

            XYSeriesData data = new XYSeriesData();
            data.AddPoint(1,1);
            data.AddPoint(2,34);
            data.AddPoint(3,67);
            c.AddSeries(data);
            
            XYSeriesData data2 = new XYSeriesData();
            data2.AddPoint(1,21);
            data2.AddPoint(2,22);
            data2.AddPoint(3,45);
            c.AddSeries(data2);


            SeriesOptions seriesOptions = new SeriesOptions();
            seriesOptions.label = "label1";
            seriesOptions.renderer = DataRenderers.BarRenderer;
            seriesOptions.rendererOptions = new RendererOptions();
            //c.options.AddSeriesOptions(seriesOptions);

            
            //var test = c.Render();
            //Console.Out.WriteLine(test);
        }
    }
}
