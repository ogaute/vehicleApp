using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace vehicleApp
{
    public class Plane : Vehicle
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


        public string fly()
        {
            return "Plane with registration number " + this.registrationNumber + " is flying";
        }
    }
}
