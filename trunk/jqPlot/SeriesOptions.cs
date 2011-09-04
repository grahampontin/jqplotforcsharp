using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jqPlot
{
    public class SeriesOptions
    {
        private bool _showMarker = true;

        public SeriesOptions()
        {
            rendererOptions = new RendererOptions();
        }

        public object renderer
        {
            get;
            set;
        }

        public RendererOptions rendererOptions
        {
            get;
            set;
        }

        public string label
        {
            get;
            set;
        }

        public bool showMarker
        {
            get {
                return _showMarker;
            }
            set {
                _showMarker = value;
            }
        }
    }
}
