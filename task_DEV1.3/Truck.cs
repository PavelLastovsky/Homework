using System;

namespace task_DEV1._3
{
    public class Truck : Vehicle
    {
        const string _vehicleType = "Truck";
        string _colour;
        public string Colour
        {
            get { return _colour; }
            set
            {
                _colour = value;
            }
        }
        /// <summary>
        /// Truck constructor that determined Truck colour
        /// </summary>
        /// <param name="Colour"> Truck colour </param>
        /// <param name="engine"> engine parameters in Truck </param>
        /// <param name="chassis"> chassic parameters in Truck </param>
        /// <param name="transmission"> transmission parameters in Truck </param>
        public Truck(string Colour, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission, _vehicleType)
        {
            this.Colour = Colour;
        }
        new public void GetInfo()
        {
            Console.WriteLine($"Truck colour is {_colour}");
            base.GetInfo();
        }
    }
}
