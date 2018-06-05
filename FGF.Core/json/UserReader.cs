using FGF.Core.user;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGF.Core.json
{
    class UserReader : Reader
    {
        public static List<User> Read()
        {
            var json = ReadFromFile("../../../users.json");

            return JsonConvert.DeserializeObject<List<User>>(json);
        }
    }
}
