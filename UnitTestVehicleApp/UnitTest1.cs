using Microsoft.VisualStudio.TestTools.UnitTesting;
using vehicleApp;

namespace UnitTestVehicleApp
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Car car = new Car("NF123456", 147, "kW", 200, "km/h", "green", "personal vehicle");
            Assert.AreEqual("NF123456", car.registrationNumber);
            Assert.AreEqual(147, car.enginePower);
        }
    }
}
