using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountNumberInArray;

namespace _04.TestCountNumber
{
    [TestClass]
    public class UnitTestCountNumber
    {
        [TestMethod]
        public void TestEmpty()
        {
            int[] testArray = { };
            int number = 0;

            int result = CountNumberInArray.CountNumberInArray.CountNumber(number, testArray);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestNone()
        {
            int[] testArray = { 8, 5, 7, 2, 1, 5, 8, 2, 7, 1, 3, 5, 4, 9, 8, 9, 0, 1, 7 };
            int number = 11;

            int result = CountNumberInArray.CountNumberInArray.CountNumber(number, testArray);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test3()
        {
            int[] testArray = { 8, 5, 7, 2, 1, 5, 8, 2, 7, 1, 3, 5, 4, 9, 8, 9, 0, 1, 7 };
            int number = 3;

            int result = CountNumberInArray.CountNumberInArray.CountNumber(number, testArray);
            Assert.AreEqual(1, result);
        }

    
    }
}
