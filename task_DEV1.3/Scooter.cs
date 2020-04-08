using System;

namespace task_DEV1._3
{
    public class Scooter : Vehicle
    {
        const string _vehicleType = "Scooter";
        string _brand;
        public string Brand
        {
            get { return _brand; }
            set
            {
                _brand = value;
            }
        }
        /// <summary>
        /// Scooter constructor that determined Scooter brand
        /// </summary>
        /// <param name="Brand"> scooter brand </param>
        /// <param name="engine"> engine parameters in Scooter </param>
        /// <param name="chassis"> chassic parameters in scooter </param>
        /// <param name="transmission"> transmission parameters in scooter </param>
        public Scooter(string Brand, Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission, _vehicleType)
        {
            this.Brand = Brand;
        }
        new public void GetInfo()
        {
            Console.WriteLine($"Scooter brand is: {_brand} ");
            base.GetInfo();
        }
    }
}
