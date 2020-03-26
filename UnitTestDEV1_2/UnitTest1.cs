using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_DEV1_2;

namespace UnitTestDEV1_2
{
    [TestClass]
    public class ConvertFromDeciminalNumberSystemTest
    {
        [TestMethod]
        [DataRow("11101100", "236", "2")] // Check For Current Work Return Number for 2 Check scale of notations
        [DataRow("1DB", "475", "16")] // Check For Current Work Return Number for 16 Check scale of notations
        [DataRow("31", "25", "8")] // Check For Current Work Return Number for 8 Check scale of notations
        [DataRow("100", "9", "3")] // Check For Current Work Return Number for 3 Check scale of notations
        [DataRow("22", "22", "10")] // Check For Current Work Return Number for 10 Check scale of notations
        public void CheckForCurrentWorkReturnNumberInAnotherScaleOfNotation(string ExampleStringInAnotherScaleOfNotation, string CheckNumber, string CheckScaleOfNotationString)
        {
            ConvertFromDeciminalNumberSystem Check = new ConvertFromDeciminalNumberSystem(CheckNumber, CheckScaleOfNotationString);
            string CheckMethodForCurrentWork = Check.NumberInAnotherScaleOfNotation();
            Assert.AreEqual(CheckMethodForCurrentWork, ExampleStringInAnotherScaleOfNotation);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Scale Of Notation not between 2 and 20")]
        [DataRow("85", "-2")]
        [DataRow("25", "25")]
        public void CheckForArgumentOutOfRangeExceptionReturnNumberInAnotherScaleOfNotation(string CheckNumber, string CheckScaleOfNotationString)
        {
            ConvertFromDeciminalNumberSystem Check = new ConvertFromDeciminalNumberSystem(CheckNumber, CheckScaleOfNotationString);
            Check.NumberInAnotherScaleOfNotation();
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Null string is entered")]
        public void CheckForNullReferenceExceptionReturnNumberInAnotherScaleOfNotation()        
        {
            ConvertFromDeciminalNumberSystem Check = null;
            Check.NumberInAnotherScaleOfNotation();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException), "Empty string is entered")]
        public void CheckForFormatExceptiongReturnNumberInAnotherScaleOfNotation()
        {
            string ExampleEmptyString = string.Empty;
            ConvertFromDeciminalNumberSystem Check = new ConvertFromDeciminalNumberSystem(ExampleEmptyString, ExampleEmptyString);
            Check.NumberInAnotherScaleOfNotation();
        }

    }
}
