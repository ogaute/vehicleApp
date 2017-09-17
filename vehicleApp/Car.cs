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
                    { "LicencePlate", base.registrationNumber },
                    { "EnginePower", base.enginePower },
                    { "EnginePowerUnit", base.enginePowerUnit },
                    { "MaxSpeed", base.maxSpeed },
                    { "MaxSpeedUnit", base.maxSpeedUnit },
                    { "Color", this.color },
                    { "CarType", this.carType }

               };
        }

        public void drive()
        {
            Console.WriteLine("Car with license plate " + this.registrationNumber + " is driving");
        }
    }
}
