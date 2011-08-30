using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jqPlot
{
    public class Options
    {
        private List<SeriesOptions> _seriesOptions;

        public Options()
        {
            legend = new Legend();
            //series = new List<SeriesOptions>();
            axes = new NoAxesOptions();
            grid = new GridOptions();
            _seriesOptions = new List<SeriesOptions>();
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

//        public List<SeriesOptions> series
//        {
//            get;
//            set;
//        }

        public IAxesDefinition axes
        {
            get;
            set;
        }

        public GridOptions grid
        {
            get;
            set;
        }

        
        public bool drawIfHidden
        {
            get;
            set;
        }

        public SeriesOptions[] series
        {
            get
            {
                if (_seriesOptions == null)
                {
                    return null;
                }
                return _seriesOptions.ToArray();
            }
        }

        public void AddSeriesOptions(SeriesOptions seriesOptions)
        {
            if (_seriesOptions == null)
                _seriesOptions = new List<SeriesOptions>();

            _seriesOptions.Add(seriesOptions);
        }
    }
}
