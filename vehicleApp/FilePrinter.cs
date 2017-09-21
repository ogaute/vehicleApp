using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace vehicleApp
{
    class FilePrinter
    {
        public static void WriteJsonFile(Object dataObject, String path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(dataObject), Encoding.UTF8);
        }
    }
}
