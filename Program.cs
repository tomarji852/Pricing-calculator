using pricing_engine.DomainModels;
using pricing_engine.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricing_engine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputFileReader inputFileReader = new InputFileReader();
                List<TaxConfigs> taxConfigs = inputFileReader.LoadJsonConfigs();
                List<TaxItem> taxItem = inputFileReader.LoadJsonItems();

                PriceCalculator priceCalculator = new PriceCalculator();

                List<OutPutResults> outPutResults = priceCalculator.CalculatPrices(taxConfigs, taxItem);

                OutPutSaver outPutSaver = new OutPutSaver();
                outPutSaver.SaveOutput(outPutResults);



            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
            
        }
    }
}
