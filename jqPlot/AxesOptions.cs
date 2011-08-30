using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jqPlot
{
    public class AxesOptions
    {
        private const string DefaultAxisName = "New Axis";

        public AxesOptions()
        {
            _ticks = new List<string>();
        }

        //Defaults
        private bool _show = true;
        private string _label = DefaultAxisName;
        private bool _showLabel = true;

        public bool show
        {
            get { return _show; }
            set { _show = value; }
        }

        public string label
        {
            get { return _label; }
            set { _label = value; }
        }

        private string _renderer = AxisRenderers.LinearAxisRenderer;
        public string renderer
        {
            get { return _renderer; }
            set { _renderer = value; }
        }

        public bool showLabel
        {
            get { return _showLabel; }
            set { _showLabel = value; }
        }

        public void AddTick(string value)
        {
            _ticks.Add(value);
        }

        public void AddTicks(IEnumerable<string> values)
        {
            _ticks.AddRange(values);
        }

        private List<string> _ticks;

        public string[] ticks
        {
            get { return _ticks.ToArray(); }
        }
    }
}
