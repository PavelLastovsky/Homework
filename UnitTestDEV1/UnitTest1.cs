using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_DEV1;
using System;

namespace UnitTestDEV1
{
    [TestClass]
    public class FindMaxDifferentSymbolsInSequenceTest
    {
        [TestMethod]
        [DataRow("aabcdefghh", 8)] // Check For Current Work Return Length Of Max Different Symbols
        [DataRow("A", 1)] // Check For One Element String Return Length Of Max Different Symbols
        public void CheckForCurrentWorkReturnLengthOfMaxDifferentSymbols(string exampleString, int CheckValueForCurrentWork)
        {
            int CheckMethodForCurrentWork = FindMaxDifferentSymbolsInSequence.ReturnLengthOfMaxDifferentSymbols(exampleString);
            Assert.AreEqual(CheckMethodForCurrentWork, CheckValueForCurrentWork);
        }

        [TestMethod]
        [DataRow(0)]
        public void CheckForEmptyStringReturnLengthOfMaxDifferentSymbols(int CheckValueForEmptyString)
        {
            string ExampleEmptyString = string.Empty;
            int CheckMethodForEmptyString = FindMaxDifferentSymbolsInSequence.ReturnLengthOfMaxDifferentSymbols(ExampleEmptyString);
            Assert.AreEqual(CheckMethodForEmptyString, CheckValueForEmptyString);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Null string is entered")]
        public void CheckForNullStringReturnLengthOfMaxDifferentSymbols()
        {
            string ExampleNullString = null;
            FindMaxDifferentSymbolsInSequence.ReturnLengthOfMaxDifferentSymbols(ExampleNullString);

        }
    }
}
