using System;
namespace Task_DEV1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter string");
                string YourString = Console.ReadLine();
                int LengthOfMaxDifferentSymbols = FindMaxDifferentSymbolsInSequence.ReturnLengthOfMaxDifferentSymbols(YourString);
                Console.WriteLine($"Maximum length of sequence with different elements: {LengthOfMaxDifferentSymbols}");
                Console.ReadKey();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("You entered null string");
            }

        }
    }
}
