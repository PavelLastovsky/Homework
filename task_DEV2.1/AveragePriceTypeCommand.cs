namespace task_DEV2._1
{
    class AveragePriceTypeCommand : ICommand
    {
        string _brand;
        public string Brand
        {
            get => _brand;
            private set
            {
                _brand = value;
            }
        }
        public AveragePriceTypeCommand(string brand)
        {
            Brand = brand;
        }
        public void Execute()
        {
            CarParkDatabase.GetInstance().AverageCarPriceType(Brand);
        }
    }
}
