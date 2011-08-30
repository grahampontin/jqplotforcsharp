using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace jqPlot
{
    public class XYSeriesData : ISeriesData
    {
        private List<KeyValuePair<double, double>> _points;
        private JavaScriptSerializer _javaScriptSerializer = new JavaScriptSerializer();

        public double[][] Points
        {
            get { return _points.Select(a=>new[]{a.Key,a.Value}).ToArray(); }
        }

        public void AddPoint(double x, double y)
        {
            if (_points == null) 
                _points = new List<KeyValuePair<double, double>>();

            _points.Add(new KeyValuePair<double, double>(x,y));
        }

        public void AddPoints(List<KeyValuePair<double , double>> points)
        {
            _points.AddRange(points);
        }

        public string GetJson()
        {
            return _javaScriptSerializer.Serialize(this.Points);
        }
    }
}
