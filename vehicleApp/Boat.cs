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

    }
}
