namespace task_DEV2._1
{
    class CountAllCommand : ICommand
    {
        public CountAllCommand() { }
        public void Execute()
        {
            CarParkDatabase.GetInstance().CountAll();
        }
    }
}
