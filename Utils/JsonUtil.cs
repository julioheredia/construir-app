using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConstruirApp.Models;
using Newtonsoft.Json;
using System.IO;

namespace ConstruirApp.Utils
{
    public class JsonUtil
    {
        
        private static string jsonPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string jsonFile = "obras_app.json";
       
        public static string WriteFromObra(List<Obra> obras)
        {
            var json = JsonConvert.SerializeObject(obras, Formatting.Indented);
            File.WriteAllText((Path.Combine(jsonPath, jsonFile)), json);

            Console.WriteLine(Path.Combine(jsonPath, jsonFile));
            return json;
        }


        public static List<Obra> ReadToObra()
        {
            using (StreamReader r = new StreamReader(Path.Combine(jsonPath, jsonFile)))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Obra>>(json);
            }
            
        }

    }
}
