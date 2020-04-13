namespace task_DEV2._1
{
    class CountTypesCommand : ICommand
    {
        public CountTypesCommand() { }
        public void Execute()
        {
            CarParkDatabase.GetInstance().CountTypes();
        }
    }
}
