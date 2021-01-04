using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricing_engine.DomainModels
{
    public class OutPutResults
    {
        public string Name { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal? FinalPrice { get; set; }
    }
}
