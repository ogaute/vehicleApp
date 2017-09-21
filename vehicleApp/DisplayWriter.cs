using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace vehicleApp
{
    class DisplayWriter
    {
        public static void WriteJsonToScreen(Object dataObject)
        {
            Console.WriteLine(JsonConvert.SerializeObject(dataObject));
        }

        public static void WriteTextToScreen(String text)
        {
            Console.WriteLine(text);
        }
    }
}
