using System;

namespace Task_DEV1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string NumberString = args[0], ScaleOfNotationString = args[1];
                ConvertFromDeciminalNumberSystem Convert = new ConvertFromDeciminalNumberSystem(NumberString, ScaleOfNotationString);
                string Result = Convert.NumberInAnotherScaleOfNotation();
                Console.WriteLine($"Your number: {Result}, in {ScaleOfNotationString} scale of notation");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You entered negative Number or Scale Of Notation not between 2 and 20");
            }

            catch (NullReferenceException)
            {
                Console.WriteLine("You entered Null string");
            }
            catch (FormatException)
            {
                Console.WriteLine("You entered empty string");
            }
        }
    }
}
