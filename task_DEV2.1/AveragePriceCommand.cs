namespace task_DEV2._1
{
    class AveragePriceCommand : ICommand
    {
        public AveragePriceCommand() { }
        public void Execute()
        {
            CarParkDatabase.GetInstance().AverageCarPrice();
        }
    }
}
