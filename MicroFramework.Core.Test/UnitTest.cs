using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MicroFramework.Core.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
        }
        public static void Test()
        {
            var number = 10; 
            number = 1;
            number += 1;
            Console.WriteLine(number);

        }
    }
}
