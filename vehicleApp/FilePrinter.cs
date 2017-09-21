using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace vehicleApp
{
    class FilePrinter
    {
        public static void WriteToFile(String path, String fileExtension, String content)
        {
            File.WriteAllText(path+fileExtension, content, Encoding.UTF8);
        }
    }
}
