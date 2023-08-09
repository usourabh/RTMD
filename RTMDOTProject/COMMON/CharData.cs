using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTMDOTProject.COMMON
{
    public class CharData
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public bool ShowInLegend { get; set; }
        public string YValueFormatString { get; set; }
        public string MarkerBorderColor { get; set; }
        public int MarkerBorderThickness { get; set; }
        public List<dap> DataPoints { get; set; }
    }

    public class dap
    {
        public string X { get; set; }
        public float y { get; set; }
    }

    public class DataSample
    {
        public decimal TMin { get; set; }
        public decimal Tmax { get; set; }
        public decimal Tavg { get; set; }
        public DateTime Tdate { get; set; }

        public int yy { get; set; }
        public int mm { get; set; }
        public int dd { get; set; }

    }
}
