using System;
using System.Collections.Generic;
using System.Text;

namespace vehicleApp
{
    class LandVehicle : Vehicle
    {

        public int maxSpeed { get; set; }
        public string maxSpeedUnit { get; set; }

        public LandVehicle(string licensePlate, int enginePower, string enginePowerUnit, int maxSpeed, string maxSpeedUnit) : base(licensePlate, enginePower, enginePowerUnit)
        {
            this.maxSpeed = maxSpeed;
            this.maxSpeedUnit = maxSpeedUnit;
        }
    }
}
