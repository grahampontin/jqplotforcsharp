using System.Web.Script.Serialization;

namespace jqPlot
{
    public class OnlyYAxisDefinition : XAndYAxesDefinition
    {
        [ScriptIgnore]
        public override AxesOptions xaxis
        {
            get
            {
                return null;
            }

        }
    }
}