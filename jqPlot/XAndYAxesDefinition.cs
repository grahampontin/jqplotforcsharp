namespace jqPlot
{
    public class XAndYAxesDefinition : IAxesDefinition
    {
        private AxesOptions _xaxis;
        public virtual AxesOptions xaxis
        {
            get
            {
                if (_xaxis == null)
                    _xaxis = new AxesOptions();
                return _xaxis;
            }
            set { _xaxis = value; }
        }

        private AxesOptions _yaxis;
        public virtual AxesOptions yaxis
        {
            get
            {
                if (_yaxis == null)
                    _yaxis= new AxesOptions();
                return _yaxis;
            }
            set { _yaxis = value; }
        }
    }
}