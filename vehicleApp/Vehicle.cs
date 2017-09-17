using System;
using System.Collections.Generic;
using System.Text;

namespace vehicleApp
{
    class Vehicle
    {
        public string registrationNumber { get; set; }
        public int enginePower { get; set; }
        public string enginePowerUnit { get; set; }
   


        public Vehicle(string registrationNumber, int enginePower, string enginePowerUnit)
        {
            this.registrationNumber = registrationNumber;
            this.enginePower = enginePower;
            this.enginePowerUnit = enginePowerUnit;
        }

    }
}
