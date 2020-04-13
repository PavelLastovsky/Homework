using System;

namespace task_DEV2._1
{
    class Invoker
    {
        const string EnterBrandStringText = "Enter car brand",
                     EnterModelStringText = "Enter car model",
                     EnterCarPriceText = "Enter car price",
                     EnterCarAmmountText = "Enter car amount";

        public Invoker()
        {
            CarParkDatabase.GetInstance().TaskDone += CarDatabaseTaskDone;
        }

        public ICommand GetICommandFromConsole()
        {
            Console.WriteLine("\nEnter command:\n" +
                                "add new car\n" +
                                "count all\n" +
                                "count types\n" +
                                "average price\n" +
                                "average price type\n" +
                                "exit\n");

            string EnterString = Console.ReadLine();

            switch (EnterString)
            {
                case CommandsList.CountAllCommand:
                    {
                        return new CountAllCommand();
                    }
                case CommandsList.AveragePriceCommand:
                    {
                        return new AveragePriceCommand();
                    }
                case CommandsList.CountTypesCommand:
                    {
                        return new CountTypesCommand();
                    }
                case CommandsList.AveragePriceTypeCommand:
                    {
                        Console.WriteLine(EnterBrandStringText);
                        return new AveragePriceTypeCommand(Console.ReadLine());
                    }
                case CommandsList.AddCarCommand:
                    {
                        return new AddCarCommand(GetCarFromConsole());
                    }
                case CommandsList.ExitCommand:
                    {
                        return new ExitCommand();
                    }

                default:
                    {
                        throw new ArgumentNullException();
                    }
            }


        }

        public CarPark GetCarFromConsole()
        {
            Console.WriteLine(EnterBrandStringText);
            
            string brand = Console.ReadLine();
            
            Console.WriteLine(EnterModelStringText);
            
            string model = Console.ReadLine();
            
            Console.WriteLine(EnterCarPriceText);

            int price = int.Parse(Console.ReadLine());
            
            Console.WriteLine(EnterCarAmmountText);
            
            int amount = int.Parse(Console.ReadLine());
            
            return new CarPark(brand, model, amount, price);
        }
        private void CarDatabaseTaskDone(object sender, TaskDoneEventArgs a)
        {
            Console.WriteLine(string.Format("{0} - {1}", a.Text, a.Data));
        }

    }
}
