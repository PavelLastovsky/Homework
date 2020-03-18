using System;

namespace Task_DEV1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number and Scale of notation");
                string NumberString = Console.ReadLine(), ScaleOfNotationString = Console.ReadLine();
                ConvertFromDeciminalNumberSystem Convert = new ConvertFromDeciminalNumberSystem(NumberString, ScaleOfNotationString);
                string Result = Convert.ReturnNumberInAnotherScaleOfNotation();
                Console.WriteLine($"Your number: {Result}, in {ScaleOfNotationString} scale of notation");
                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You entered negative Number or Scale Of Notation not between 2 and 20");
                Console.ReadKey();
            }

            catch (NullReferenceException)
            {
                Console.WriteLine("You entered Null string");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("You entered empty string");
                Console.ReadKey();
            }
        }
    }
}
