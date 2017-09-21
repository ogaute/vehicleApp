using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace vehicleApp
{
    public class Car : LandVehicle
    {

        public string color { get; set; }
        public string carType { get; set; }

        public Car(string registrationNumber, int enginePower, string enginePowerUnit, int maxSpeed, string maxSpeedUnit, string color, string carType) : base(registrationNumber, enginePower, enginePowerUnit, maxSpeed, maxSpeedUnit)
        {
            this.color = color;
            this.carType = carType;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Car car = (Car)obj;
            return (base.registrationNumber == car.registrationNumber);
        }

        public string drive()
        {
            return "Car with license plate " + this.registrationNumber + " is driving";
        }
    }
}
