using System.Web.Script.Serialization;

namespace jqPlot
{
    public class NoAxesOptions : IAxesDefinition
    {
        [ScriptIgnore]
        public AxesOptions xaxis
        {
            get { return null; }
        }

        [ScriptIgnore]
        public AxesOptions yaxis
        {
            get { return null; }
        }
    }
}