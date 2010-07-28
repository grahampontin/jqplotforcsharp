using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace jqPlot
{
    public class Chart
    {

        public Chart()
        {
            options = new Options();
        }

        public string DataJSON
        {
            get;
            set;
        }

        public string GetOptionsJSON()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            return ser.Serialize(options);
        }

        public void AddSeries()
        {

        }

        public Options options
        {
            get;
            set;
        }
    }
}
