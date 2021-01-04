using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricing_engine.DomainModels
{
    public class InputModel
    {
        public List<TaxConfigs> InputConfigs { get; set; }
        public List<TaxItem> InputItems { get; set; }
    }
}
