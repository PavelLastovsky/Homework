using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_DEV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string YourString = Console.ReadLine();
            Console.WriteLine($"Maximum number of unmatches per line: {SequenceOfElements.MaxDifferentElements(YourString)}") ;
            Console.ReadKey();
        }
    }
}
