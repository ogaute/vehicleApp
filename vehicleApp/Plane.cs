using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace vehicleApp
{
    class Plane : Vehicle
    {

        public int wingSpan { get; set; }
        public int loadCapacity { get; set; }
        public int netWeight { get; set; }
        public string weightUnit { get; set; }
        public string flyingClass { get; set; }


        public Plane(string registrationNumber, int enginePower, string enginePowerUnit, int wingSpan, int loadCapacity, int netWeight, string weightUnit, string flyingClass) : base(registrationNumber, enginePower, enginePowerUnit)
        {
            this.wingSpan = wingSpan;
            this.loadCapacity = loadCapacity;
            this.netWeight = netWeight;
            this.weightUnit = weightUnit;
            this.flyingClass = flyingClass;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(buildObject());
        }

        public void ToJsonFile()
        {
            string path = base.registrationNumber + ".txt";
            File.WriteAllText(path, JsonConvert.SerializeObject(buildObject()), Encoding.UTF8);
        }

        private Dictionary<string, Object> buildObject()
        {
            return new Dictionary<string, Object>
               {
                    { "Registration", base.registrationNumber },
                    { "EnginePower", base.enginePower },
                    { "EnginePowerUnit", base.enginePowerUnit },
                    { "WingSpan", this.wingSpan },
                    { "NetWeight", this.netWeight },
                    { "WeightUnit", this.weightUnit }


               };
        }

        public void fly()
        {
            Console.WriteLine("Plane with registration number " + this.registrationNumber + " is flying");
        }
    }
}
