using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jqPlot
{
    public class GridOptions
    {
        private bool _drawGridlines = true;

        public bool drawGridlines
        {
            get {
                return _drawGridlines;
            }
            set {
                _drawGridlines = value;
            }
        }
    }
}
