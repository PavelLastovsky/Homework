using System;

namespace task_DEV1._3
{
    public class Car : Vehicle
    {
        const string _vehicleType = "Car";
        double _length;
        public double Length
        {
            get {
                return _length; 
            }
            set
            {
                _length = value;
            }
        }
        /// <summary>
        /// Car constructor that determined car length
        /// </summary>
        /// <param name="Length"> Car length </param>
        /// <param name="engine"> engine parameters in car </param>
        /// <param name="chassis"> chassic parameters in car </param>
        /// <param name="transmission"> transmission parameters in car </param>
        public Car(double Length, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission, _vehicleType)
        {
            this.Length = Length;
        }
        new public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Car length is {_length}");

        }
    }
}
