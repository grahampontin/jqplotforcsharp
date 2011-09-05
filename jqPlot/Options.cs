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
            //grid = new GridOptions(); Fucks up Pies
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

        private IAxesDefinition _axes;
        /// <summary>
        /// Allows you specify the behaviour of the axes. Defaults to X and Y definition. In order to specify
        /// only one you should set this be a new OnlyXAxisDefinition() or OnlyYAxisDefintion()
        /// </summary>
        public IAxesDefinition axes
        {
            get
            {
                if (_axes is NoAxesOptions)
                    _axes = new XAndYAxesDefinition();
                return _axes;
            }
            set { _axes = value; }
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

        /// <summary>
        /// CReate some default settings based on your series type
        /// </summary>
        /// <param name="ofType"></param>
        public SeriesOptions AddSeriesOptions(SeriesTypes ofType)
        {
            SeriesOptions options = new SeriesOptions();
            switch (ofType)
            {
                case SeriesTypes.Bar:
                    options.renderer = DataRenderers.BarRenderer;
                    break;
                case SeriesTypes.Line:
                    options.renderer = DataRenderers.LineRenderer;
                    break;
                case SeriesTypes.Pie:
                    options.renderer = DataRenderers.PieRenderer;
                    options.rendererOptions.showDataLabels = true;
                    break;
                default:
                    throw new NotImplementedException("Don't know how to make a chart of type " +  ofType);
            }
            AddSeriesOptions(options);
            return options;
        }

        public SeriesOptions AddSeriesOptions(SeriesTypes ofType, string withLabel)
        {
            SeriesOptions options = AddSeriesOptions(ofType);
            options.label = withLabel;
            return options;
        }
    }
}
