using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintName01;

namespace _01.TestPrintName
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestJohn()
        {
            string testMessage = "John";
            PrintYourName.PrintName(testMessage);
            
        }
    }
}
