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
    public class OutPutSaver
    {
        public void SaveOutput(List<OutPutResults> outPutResults)
        {

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data\outPut.json");
            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, outPutResults);
            }
        }
    }
}
