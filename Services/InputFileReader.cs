using Newtonsoft.Json;
using pricing_engine.DomainModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace pricing_engine.Services
{
    public class InputFileReader
    {
        public List<TaxConfigs> LoadJsonConfigs()
        {
            List<TaxConfigs> inputModel = null;
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\inputConfigs.json");
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                inputModel = JsonConvert.DeserializeObject<List<TaxConfigs>>(json);
            }

            return inputModel;
        }

        public List<TaxItem> LoadJsonItems()
        {
            List<TaxItem> inputModel = null;
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\inputItems.json");
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                inputModel = JsonConvert.DeserializeObject<List<TaxItem>>(json);
            }

            return inputModel;
        }

    }
}
