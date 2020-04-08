using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV1._3;

namespace UnitTestDEv1._3
{
    [TestClass()]
    public class EngineTests
    {
        [ExpectedException(typeof(ArgumentNullException))]
        [DataRow(600, 6, null, "00X975")]
        [DataRow(600, 6, "Diesel", null)]
        [TestMethod()]
        public void EngineArgumentNullExceptionTest(double Power, double Volume, string Type, string SerialNumber)
        {
            Engine engine = new Engine(Power, Volume, Type, SerialNumber);
        }

        [ExpectedException(typeof(FormatException))]
        [DataRow(600, 6, "", "00X975")]
        [DataRow(600, 6, "Diesel", "")]
        [TestMethod()]
        public void EngineFormatExceptionTest(double Power, double Volume, string Type, string SerialNumber)
        {
            Engine engine = new Engine(Power, Volume, Type, SerialNumber);
        }
    }
    [TestClass()]
    public class ChassisTests
    {
        [ExpectedException(typeof(ArgumentNullException))]
        [DataRow(4, null, 2000)]
        [TestMethod()]
        public void ChassisArgumentNullExceptionTest(int WheelsQuantity, string ChassisNumber, double PermissibleLoad)
        {
            Chassis chassis = new Chassis(WheelsQuantity, ChassisNumber, PermissibleLoad);
        }

        [ExpectedException(typeof(FormatException))]
        [DataRow(4, "", 2000)]
        [TestMethod()]
        public void ChassisFormatExceptionTest(int WheelsQuantity, string ChassisNumber, double PermissibleLoad)
        {
            Chassis chassis = new Chassis(WheelsQuantity, ChassisNumber, PermissibleLoad);
        }
    }
    [TestClass()]
    public class TransmissionTests
    {
        [ExpectedException(typeof(ArgumentNullException))]
        [DataRow(null, 6, "Volvo")]
        [DataRow("Hydropneumatic", 6, null)]
        [TestMethod()]
        public void TransmissionArgumentNullExceptionTest(string TransmissionType, int GearsNumber, string Producer)
        {
            Transmission transmission = new Transmission(TransmissionType, GearsNumber, Producer);
        }

        [ExpectedException(typeof(FormatException))]
        [DataRow("", 6, "Volvo")]
        [DataRow("Hydropneumatic", 6, "")]
        [TestMethod()]
        public void TransmissionFormatExceptionTest(string TransmissionType, int GearsNumber, string Producer)
        {
            Transmission transmission = new Transmission(TransmissionType, GearsNumber, Producer);
        }

    }
    [TestClass()]
    public class VehicleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void VehicleArgumentNullExceptionTest()
        {
            Vehicle vehicle = new Vehicle(null, null, null, null);
        }
    }

} 
