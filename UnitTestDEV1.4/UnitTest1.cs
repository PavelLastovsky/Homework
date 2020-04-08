using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV1._4;

namespace UnitTestDEV1._4
{
    [TestClass]
    public class CoordinateTest
    {
        Coordinate CurrentPoint = new Coordinate(20, 20, 20);
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(-8, 2, 4)]
        [DataRow(8, -2, 4)]
        [DataRow(8, 2, -4)]
        public void CoordinateConstructorArgumentOutOfRangeExceptionCheck(float a, float b, float c)
        {
            Coordinate NewPoint = new Coordinate(a, b, c);
        }

        [TestMethod]
        [DataRow(0)]
        public void CoordinateConstructorArgumentCorrectWorkCheck(float a)
        {
            Coordinate FirstPoint = new Coordinate(1, 1, 1);
            Coordinate SecondPoint = new Coordinate(1, 1, 1);
            float CheckMetod = FirstPoint.GetDistance(SecondPoint);
            Assert.AreEqual(CheckMetod, a);
        }
    }
    [TestClass]
    public class BirdTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(-8)]
        [DataRow(24)]
        public void BirdConstructorArgumentOutOfRangeExceptionCheck(float a)
        {
            Coordinate CurrentPoint = new Coordinate(15, 15, 15);
            Bird NewPoint = new Bird(CurrentPoint);
            NewPoint.Speed = a;
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        [DataRow(0)]
        public void BirdConstructorNotZeroCheck(float a)
        {
            Coordinate CurrentPoint = new Coordinate(15, 15, 15);
            Bird NewPoint = new Bird(CurrentPoint);
            NewPoint.Speed = a;
        }
    }
    [TestClass]
    public class PlaneTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(150)]
        [DataRow(6500)]
        public void PlaneConstructorSpeedArgumentOutOfRangeExceptionCheck(float a)
        {
            Coordinate CurrentPoint = new Coordinate(15, 15, 15);
            Plane NewPoint = new Plane(CurrentPoint, a);
            float CheckMetod = NewPoint.Speed;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(0, 0, 0)]
        [DataRow(100, 100, 100)]
        public void PlaneConstructorDistanceArgumentOutOfRangeExceptionCheck(float a, float b, float c)
        {
            Coordinate CurrentPoint = new Coordinate(a, b, c);
            Plane NewPoint = new Plane(CurrentPoint, 12);
            float CheckMetod = NewPoint.GetFlyTime(CurrentPoint);
        }
    }
    [TestClass]
    public class DroneTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(-50)]
        [DataRow(41)]
        public void DroneConstructorSpeedArgumentOutOfRangeExceptionCheck(float a)
        {
            Coordinate CurrentPoint = new Coordinate(15, 15, 15);
            Drone NewPoint = new Drone(CurrentPoint, a);
            float CheckMetod = NewPoint.Speed;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [DataRow(0, 0, 0)]
        [DataRow(150, 120, 110)]
        public void DroneConstructorDistanceArgumentOutOfRangeExceptionCheck(float a, float b, float c)
        {
            Coordinate CurrentPoint = new Coordinate(a, b, c);
            Drone NewPoint = new Drone(CurrentPoint, 12);
            float CheckMetod = NewPoint.GetFlyTime(CurrentPoint);
        }
    }

}
