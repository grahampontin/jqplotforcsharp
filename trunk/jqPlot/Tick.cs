using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace jqPlot
{
    public class Tick
    {
        public Tick(decimal value, string label)
        {
            Value = value;
            Label = label;
        }

        [ScriptIgnore]
        public decimal Value
        {
            get;
            set;
        }

        [ScriptIgnore]
        public string Label
        {
            get;
            set;
        }

        public string[] tick
        {
            get
            {
                return new string[] { Value.ToString(), Label };
            }
        }


    }
}
