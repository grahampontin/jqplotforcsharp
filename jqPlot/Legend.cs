using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jqPlot
{
    public class Legend
    {
        private string _placement;

        public bool show
        {
            get;
            set;
        }

        public string location
        {
            get;
            set;
        }

        public string placement
        {
            get {
                return _placement;
            }
            set {
                _placement = value;
            }
        }
    }
}
