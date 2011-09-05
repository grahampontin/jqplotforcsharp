using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace jqPlot
{
    public class PieSeriesData : ISeriesData
    {
        private List<KeyValuePair<string, double>> _points;
        private JavaScriptSerializer _javaScriptSerializer = new JavaScriptSerializer();

        public PieSeriesData(IEnumerable<KeyValuePair<string, double>> points)
        {
            _points = points.ToList();
        }

        public object[][] Points
        {
            get { return _points.Select(a => new object[] { a.Key, a.Value }).ToArray(); }
        }

        public void AddPoint(string label, double value)
        {
            if (_points == null)
                _points = new List<KeyValuePair<string, double>>();

            _points.Add(new KeyValuePair<string, double>(label, value));
        }

        public void AddPoints(IEnumerable<KeyValuePair<string, double>> points)
        {
            if (_points == null)
                _points = new List<KeyValuePair<string, double>>();
            _points.AddRange(points);
        }

        public string GetJson()
        {
            return _javaScriptSerializer.Serialize(this.Points);
        }
    }
}