using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGF.Core.json
{
    class Writer
    {
        protected static void WriteToFile(string fileName, string json)
        {
            var file = new FileStream(fileName, FileMode.Create);
            var writer = new StreamWriter(file);
            writer.Write(json);
            writer.Close();
        }
    }
}
