using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using jqPlot;

namespace TestWebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Chart lineChart = new Chart("chartdiv");
            lineChart.options.legend.show = true;
            lineChart.options.legend.location = "se";
            lineChart.options.stackSeries = true;
            //c.options.series.Add(new SeriesOptions());
            //c.options.series[0].renderer = Renders.LineRenderer;

            var axes = new XAndYAxesDefinition();
            axes.yaxis = new AxesOptions();
            axes.yaxis.AddTick("0");
            axes.yaxis.AddTick("100");
            axes.yaxis.label = "I'm very exciting";

            axes.xaxis = new AxesOptions();
            axes.xaxis.AddTick("0");
            axes.xaxis.AddTick("5");
            axes.xaxis.AddTick("10");
            axes.xaxis.AddTick("15");
            axes.xaxis.label = "The mighty x-axis";



            lineChart.options.axes = axes;
            
            XYSeriesData data = new XYSeriesData();
            data.AddPoint(1, 1);
            data.AddPoint(2, 34);
            data.AddPoint(3, 67);
            lineChart.AddSeries(data);

            XYSeriesData data2 = new XYSeriesData();
            data2.AddPoint(1, 21);
            data2.AddPoint(2, 22);
            data2.AddPoint(3, 45);
            lineChart.AddSeries(data2);

            SeriesOptions seriesOptions = new SeriesOptions();
            seriesOptions.label = "The first ever series there was";
            seriesOptions.renderer = DataRenderers.LineRenderer;
            seriesOptions.rendererOptions = new RendererOptions();
            lineChart.options.AddSeriesOptions(seriesOptions);

            Chart1.Text = lineChart.Render(900,300);



            Chart bar = new Chart("myBarChart");
            YOnlySeriesData ydata = new YOnlySeriesData();
            ydata.AddPoint(10);
            ydata.AddPoint(3);
            ydata.AddPoint(18);
            ydata.AddPoint(33);
            bar.AddSeries(ydata);

            OnlyXAxisDefinition axisDefinition = new OnlyXAxisDefinition();
            axisDefinition.xaxis = new AxesOptions();
            axisDefinition.xaxis.label = "Scores";
            axisDefinition.xaxis.renderer = AxisRenderers.CategoryAxisRenderer;
            axisDefinition.xaxis.AddTick("0-10");
            axisDefinition.xaxis.AddTick("11-20");
            axisDefinition.xaxis.AddTick("21-30");
            axisDefinition.xaxis.AddTick("31-40");
            bar.options.axes = axisDefinition;


            SeriesOptions options = new SeriesOptions();
            options.renderer = DataRenderers.BarRenderer;
            bar.options.AddSeriesOptions(options);

            Chart2.Text = bar.Render(900, 300);


        }
    }
}
