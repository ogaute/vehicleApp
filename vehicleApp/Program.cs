using System;

namespace vehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("NF123456", 147, "kW", 200, "km/h", "green","personal vehicle");
            DisplayWriter.WriteJsonToScreen(car1);

            Car car2 = new Car("NF654321", 150, "kW", 195, "km/h", "blue", "personal vehicle");
            DisplayWriter.WriteJsonToScreen(car2);

            if (car1.Equals(car2)) Console.WriteLine("Is same car!!");

            Plane plane = new Plane("LN1234", 1000, "kW", 30, 2, 10, "t", "jet plane");
            DisplayWriter.WriteJsonToScreen(plane);
            FilePrinter.WriteJsonFile(plane, plane.registrationNumber);

            DisplayWriter.WriteTextToScreen(car1.drive());
            DisplayWriter.WriteTextToScreen(plane.fly());
            
            Boat boat = new Boat("ABC123", 100, "kW", 30, "knots/h", 500, "kg");
            DisplayWriter.WriteJsonToScreen(boat);

            Console.ReadLine();

        }
    }
}
