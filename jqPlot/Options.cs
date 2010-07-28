using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jqPlot
{
    public class Options
    {
        public Options()
        {
            legend = new Legend();
            series = new List<SeriesOptions>();
            axes = new List<AxesOptions>();
            grid = new GridOptions();
            seriesColors = new List<string>();
        }

        public bool stackSeries
        {
            get;
            set;
        }

        public Legend legend
        {
            get;
            set;
        }

        public Title title
        {
            get;
            set;
        }

        public List<SeriesOptions> series
        {
            get;
            set;
        }

        public List<AxesOptions> axes
        {
            get;
            set;
        }

        public GridOptions grid
        {
            get;
            set;
        }

        public List<string> seriesColors
        {
            get;
            set;
        }

        public bool drawIfHidden
        {
            get;
            set;
        }
    }
}
