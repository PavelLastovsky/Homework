using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_DEV1;

namespace UnitTestDEV1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckForCurrentWorkMaxDifferentElements()
        {
            int CheckValueForCurrentWork = 8;
            string exampleString = "aabcdefghh";
            Assert.AreEqual(SequenceOfElements.MaxDifferentElements(exampleString), CheckValueForCurrentWork);
        }
        [TestMethod]
        public void CheckForEmptyStringMaxDifferentElements()
        {
            int CheckValueForEmptyString = 0;
            string ExampleEmptyString = "";
            Assert.AreEqual(SequenceOfElements.MaxDifferentElements(ExampleEmptyString), CheckValueForEmptyString);
        }
        [TestMethod]
        public void CheckForOneElementStringMaxDifferentElements()
        {
            int CheckValueForOneElementString = 1;
            string ExampleOneElementString = "A";
            Assert.AreEqual(SequenceOfElements.MaxDifferentElements(ExampleOneElementString), CheckValueForOneElementString);

        }
        [TestMethod]
        public void CheckForNullStringMaxDifferentElements()
        {
            int CheckValueForNullString = 0;
            string ExampleNullString = null;
            Assert.AreEqual(SequenceOfElements.MaxDifferentElements(ExampleNullString), CheckValueForNullString);

        }
    }
}
