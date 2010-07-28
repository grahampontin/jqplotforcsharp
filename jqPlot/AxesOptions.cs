using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jqPlot
{
    public class AxesOptions
    {
        public AxesOptions()
        {
            ticks = new List<string[]>();
        }
        public bool show
        {
            get;
            set;
        }

        public string label
        {
            get;
            set;
        }

        public bool showLabel
        {
            get;
            set;
        }

        public void AddTick(string value, string label)
        {
            ticks.Add(new string[] { value.ToString(), label });
        }

        public List<string[]> ticks
        {
            get;
            private set;
        }
    }
}
