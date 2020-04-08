using System;

namespace task_DEV1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Engine engine = new Engine(600, 6, "Diesel", "00X975");
                Chassis chassis = new Chassis(4, "GHU7256", 2000);
                Transmission transmission = new Transmission("Hydropneumatic", 6, "Volvo");
                Car car = new Car(3, engine, chassis, transmission);
                car.GetInfo();
                Truck truck = new Truck("green", engine, chassis, transmission);
                truck.GetInfo();
                Bus bus = new Bus(150, engine, chassis, transmission);
                bus.GetInfo();
                Scooter scooter = new Scooter("Yamaha", engine, chassis, transmission);
                car.GetInfo();
                Console.ReadKey();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You entered null value");
            }
            catch (FormatException)
            {
                Console.WriteLine("You entered empty string");
            }

        }
    }
}
