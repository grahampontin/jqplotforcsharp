using System.Web.Script.Serialization;

namespace jqPlot
{
    public class OnlyXAxisDefinition : XAndYAxesDefinition
    {
        [ScriptIgnore]
        public override AxesOptions yaxis
        {
            get
            {
                return null;    
            }
                
        }
    }
}