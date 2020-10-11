using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Bmail.Utils
{
    public static class JsonHelper
    {
        public static void writeJsonFile(string name, string[]json)
        {
            if(!name.EndsWith(".json"))
                name += ".json";
            File.WriteAllLines(name,json);
        }
    }
}
