using pricing_engine.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricing_engine.Services
{
    public class PriceCalculator
    {
        public List<OutPutResults> CalculatPrices(List<TaxConfigs> taxConfigs , List<TaxItem> taxItems)
        {
            List<OutPutResults> outPutResults = new List<OutPutResults>();

            foreach(TaxItem item in taxItems)
            {
                OutPutResults _outPutResults = new OutPutResults()
                {
                    Name = item.name,
                    BasePrice = item.BasePrice,
                    FinalPrice =(item.Discount !=null)? item.BasePrice - (item.Discount) * (item.BasePrice)/100: item.BasePrice
                };        
                
                foreach(TaxConfigs config in taxConfigs)
                {
                    if(config.MinPrice !=null && config.MaxPrice !=null && item.BasePrice > config.MinPrice && item.BasePrice <= config.MaxPrice)
                    {
                        if(config.Type == RateType.@fixed)
                        {
                            _outPutResults.FinalPrice += config.Tax;
                        }
                        else
                        {
                            _outPutResults.FinalPrice += (config.Tax) *item.BasePrice/100;
                        }
                    }

                    if (config.MaxPrice == null && item.BasePrice > config.MinPrice)
                    {
                        if (config.Type == RateType.@fixed)
                        {
                            _outPutResults.FinalPrice += config.Tax;
                        }
                        else
                        {
                            _outPutResults.FinalPrice += (config.Tax) * item.BasePrice / 100;
                        }
                    }
                }
                outPutResults.Add(_outPutResults);
            }

            return outPutResults;
        }
    }
}
