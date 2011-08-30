using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

namespace jqPlot
{
    public class Chart
    {
        private  List<ISeriesData> _seriesData;
        
        

        private string _targetDivId;
        private static JavaScriptSerializer _javaScriptSerializer;

        public string TargetDivId
        {
            get { return _targetDivId; }
            set { _targetDivId = value; }
        }

        public Chart(string targetDivId)
        {
            _targetDivId = targetDivId;
            options = new Options();
            _javaScriptSerializer = new JavaScriptSerializer();
            
        }

        public string Render(int width, int height)
        {
            string html = "<div id=\""+TargetDivId+"\" style=\"height:"+height+"px;width:"+width+"px;\"></div><script language='javascript'>$.jqplot ('"+TargetDivId+"', ["+GetDataJson()+"], " + GetOptionsJSON() + ");</script>";
            //HACK HACK HACK!!!
            string pattern = "\"(\\$.+?)\"";
            while (Regex.IsMatch(html, pattern))
            {
                html = Regex.Replace(html, pattern, "${1}");
            }
            return html;
        }

        private string GetDataJson()
        {
            return string.Join(",", _seriesData.Select(a=>a.GetJson()).ToArray());
        }

        private string GetOptionsJSON()
        {
            return _javaScriptSerializer.Serialize(options);
        }

        public void AddSeries(ISeriesData seriesData)
        {
            if (_seriesData == null) 
                _seriesData = new List<ISeriesData>();
                
            _seriesData.Add(seriesData);
        }

        public Options options
        {
            get;
            set;
        }

        public ISeriesData[] Series { get { return _seriesData.ToArray(); } }
    }
}
