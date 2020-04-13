using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace task_DEV2._1
{
    class CarParkDatabase
    {
        const string FileNameStringDatabase = "cars.xml",
             BrandStringDatabase = "brand",
             ModelStringDatabase = "model",
             PriceStringDatabase = "price",
             AmmountStringDatabase = "ammount",
             CarStringDatabase = "car",
             CarParkStringDatabase = "cars",
             CountTypesStringText = "Total amount of brands",
             CountAllStringText = "Total amount of cars",
             AveragePriceStringText = "Average car price",
             AveragePriceTypeStringText = "Average car price for selected brand",
             EmptyDatabaseStringText = "Database is empty";

        static XDocument _xCarDatabase;
        static CarParkDatabase _instance;
        public event EventHandler<TaskDoneEventArgs> TaskDone;
        private CarParkDatabase()
        {
            _xCarDatabase = new XDocument();
        }
        public static CarParkDatabase GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CarParkDatabase();
            }
            return _instance;
        }

        public void AddCar(CarPark car)
        {
            XElement xCars = new XElement(CarParkStringDatabase);
            XElement xCar = new XElement(CarStringDatabase);
            XAttribute xBrand = new XAttribute(BrandStringDatabase, car.Brand);
            XAttribute xModel = new XAttribute(ModelStringDatabase, car.Model);
            XAttribute xPrice = new XAttribute(PriceStringDatabase, car.Price);
            XAttribute xAmount = new XAttribute(AmmountStringDatabase, car.Amount);

            if (_xCarDatabase.Root != null)
            {
                foreach (XElement c in _xCarDatabase.Root.Elements())
                {
                    xCars.Add(c);
                }
            }
            xCar.Add(xBrand, xModel, xPrice, xAmount);
            xCars.Add(xCar);
            _xCarDatabase = new XDocument();
            _xCarDatabase.Add(xCars);
            _xCarDatabase.Save(FileNameStringDatabase);
        }
        public void DatabaseLoader()
        {
            _xCarDatabase = XDocument.Load(FileNameStringDatabase);
        }

        public void CreateNewDatabase()
        {
            _xCarDatabase = new XDocument();
        }
        public void CountTypes()
        {
            XMLNullCheck();
            List<string> Brand = new List<string>();
            foreach (XElement car in _xCarDatabase.Root.Elements())
            {
                Brand.Add(car.Attribute(BrandStringDatabase).Value);
            }
            TaskDone?.Invoke(this, new TaskDoneEventArgs(CountTypesStringText, Brand.Distinct().Count().ToString()));
        }
        public void CountAll()
        {
            XMLNullCheck();
            int Amount = 0;
            foreach (XElement car in _xCarDatabase.Root.Elements())
            {
                Amount += Convert.ToInt32(car.Attribute(AmmountStringDatabase).Value);
            }
            TaskDone?.Invoke(this, new TaskDoneEventArgs(CountAllStringText, Amount.ToString()));
        }
        public void AverageCarPrice( )
        {
            XMLNullCheck();
            double Price = 0, Amount = 0, AverageCarPrice, CurrentAmount;
            foreach (XElement car in _xCarDatabase.Root.Elements())
            {
                    CurrentAmount = Convert.ToInt32(car.Attribute(AmmountStringDatabase).Value);
                    Amount += CurrentAmount;
                    Price += Convert.ToInt32(car.Attribute(PriceStringDatabase).Value) * CurrentAmount;
            }
            AverageCarPrice = Price / Amount;
            TaskDone?.Invoke(this, new TaskDoneEventArgs(AveragePriceStringText, AverageCarPrice.ToString()));
        }

        public void AverageCarPriceType(string brand)
        {
            XMLNullCheck();
            double Price = 0, Amount = 0, AverageCarPrice, CurrentAmount;
            foreach (XElement car in _xCarDatabase.Root.Elements())
            {
                if (car.Attribute("brand").Value == brand)
                {
                    CurrentAmount = Convert.ToInt32(car.Attribute(AmmountStringDatabase).Value);
                    Amount += CurrentAmount;
                    Price += Convert.ToInt32(car.Attribute(PriceStringDatabase).Value) * CurrentAmount;
                }
            }
            AverageCarPrice = Price / Amount;
            TaskDone?.Invoke(this, new TaskDoneEventArgs(AveragePriceTypeStringText, AverageCarPrice.ToString(), brand.ToLower().ToString()));
        }
        private void XMLNullCheck()
        {
            if (_xCarDatabase.Root == null )
            {
                throw new ArgumentNullException(EmptyDatabaseStringText);
            }
        }
    }
}
