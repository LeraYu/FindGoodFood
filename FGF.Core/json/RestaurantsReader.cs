using FGF.Core.food;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGF.Core.json
{
    class RestaurantsReader : Reader 
    {
        public static List<Restaurant> Read()
        {
            string json = ReadFromFile("../../../rest.json");

            return JsonConvert.DeserializeObject<List<Restaurant>>(json);
        }
    }
}
