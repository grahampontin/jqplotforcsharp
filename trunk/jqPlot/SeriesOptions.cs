using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jqPlot
{
    public class SeriesOptions
    {
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



    }
}
