using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;

namespace jqPlot
{
    public class YOnlySeriesData : ISeriesData
    {
        private List<double> _points;
        private JavaScriptSerializer _javaScriptSerializer = new JavaScriptSerializer();

        public double[] Points
        {
            get { return _points.ToArray(); }
        }

        public void AddPoint(double y)
        {
            if (_points == null)
                _points = new List<double>();

            _points.Add(y);
        }

        public void AddPoints(List<double> points)
        {
            if (_points == null)
                _points = new List<double>();
            _points.AddRange(points);
        }

        public string GetJson()
        {
            return _javaScriptSerializer.Serialize(this.Points);
        }
    }
}