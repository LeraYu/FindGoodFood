using FGF.Core.user;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGF.Core.json
{
    class UserWriter : Writer
    {
        public static void Write(List<User> users)
        {
            var json = JsonConvert.SerializeObject(users);

            WriteToFile("users.json", json);
        }
    }
    
}
