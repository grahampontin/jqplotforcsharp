Create a chart object, and some series data to it, set some settings, render it as JSON.

Simple.
```
Chart chart = new Chart("testChart1");
chart.AddSeries(new XYSeriesData(myData));
chart.options.AddSeriesOptions(ForType.Bar);
aspLiteral1.Text = chart.Render(200,600);
```