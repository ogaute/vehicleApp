using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace vehicleApp
{
    public class Boat : LandVehicle
    {

        public int grossTonnage { get; set; }
        public string weightUnit { get; set; }


        public Boat(string registrationNumber, int enginePower, string enginePowerUnit, int maxSpeed, string maxSpeedUnit, int grossTonnage, string weightUnit) : base(registrationNumber, enginePower, enginePowerUnit, maxSpeed, maxSpeedUnit)
        {
            this.grossTonnage = grossTonnage;
            this.weightUnit = weightUnit;
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
                    { "MaxSpeed", base.maxSpeed },
                    { "MaxSpeedUnit", base.maxSpeedUnit },
                    { "GrossTonnage", this.grossTonnage },
                    { "GrossTonnageUnit", this.weightUnit }

               };
        }
    }
}
