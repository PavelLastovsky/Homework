using System;
namespace task_DEV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int finalcount = 0;
            Console.WriteLine("Enter string");
            string yourstring = Console.ReadLine();
            int length = yourstring.Length;

            for (int i = 0; i < length; i++)

            {

                if ( i < length - 1 && yourstring[i] == yourstring[i + 1])
                    count++;

                else
                {

                    if (count > finalcount)
                    {
                        finalcount = count;
                    }

                    count = 1;
                }
            }

            Console.WriteLine($"maximum number of matches per line: {finalcount}");
            Console.ReadKey();
        }
    }
    }