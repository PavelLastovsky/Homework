using System;
namespace task_DEV1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You entered argument out of range");
            }
            catch (Exception)
            {
                Console.WriteLine("You entered zero speed");
            }

        }
    }
}
