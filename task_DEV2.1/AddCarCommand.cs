namespace task_DEV2._1
{
    class AddCarCommand : ICommand
    {
        public CarPark Car { get; private set; }
        public AddCarCommand(CarPark car)
        {
            Car = car;
        }
        public void Execute()
        {
            CarParkDatabase.GetInstance().AddCar(Car);
        }
    }
}
