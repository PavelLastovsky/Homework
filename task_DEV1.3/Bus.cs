using System;

namespace task_DEV1._3
{
    public class Bus : Vehicle
    {
        const string _vehicleType = "Bus";
        public int _passengersQuantity;

        public int PassengersQuantity
        {
            get 
            { 
                return _passengersQuantity; 
            }
            set
            {
                _passengersQuantity = value;
            }
        }
        /// <summary>
        /// Bus constructor that determined Passengers quantity
        /// </summary>
        /// <param name="PassengersQuantity"> Passengers quantity in Bus</param>
        /// <param name="engine"> engine parameters in Bus</param>
        /// <param name="chassis"> chassic parameters in Bus </param>
        /// <param name="transmission"> transmission parameters in Bus </param>
        public Bus(int PassengersQuantity, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission, _vehicleType)
        {
            this.PassengersQuantity = PassengersQuantity;
        }
        new public void GetInfo()
        {
            Console.WriteLine($"Passengers quantity in bus is {_passengersQuantity}");
            base.GetInfo();
        }
    }
}
