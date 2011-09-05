using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jqPlot
{
    public class RendererOptions
    {
        private bool _showDataLabels = false;

        public bool showDataLabels
        {
            get {
                return _showDataLabels;
            }
            set {
                _showDataLabels = value;
            }
        }
    }
}
