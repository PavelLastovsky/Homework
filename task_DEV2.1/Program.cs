using System;

namespace task_DEV2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Invoker invoker = new Invoker();
                CommandExecutor commandExecutor = new CommandExecutor();
                while (true)
                {
                    commandExecutor.CommandSet(invoker.GetICommandFromConsole());
                    commandExecutor.ExecuteCommand();
                }
            }

            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
