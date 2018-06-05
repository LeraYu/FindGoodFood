using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGF.Core.json
{
    class Reader
    {
        protected static string ReadFromFile(string fileName)
        {
            var reader = new StreamReader(fileName);
            var json = reader.ReadLine();
            return json;
        }
    }
}
