
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;

namespace ConsoleApp3
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public static void TestAdd()
        {
            Calculator C = new Calculator();
            int result = C.Add(10,20);
            Assert.AreEqual(30, result);
        }
    }
}