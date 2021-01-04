using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricing_engine.DomainModels
{
    public class TaxConfigs
    {
        public string Name { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public decimal? Tax { get; set; }
        
        public RateType Type { get; set; }
    }

    public enum RateType
    {
        percentage=1,
        @fixed=2
    }
}
