using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using caculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation cal;
        [TestInitialize]
        public void Setup()
        {
            cal = new Calculation(10, 5);
        }
        [TestMethod]
        public void Test_Cong()
        {
            Assert.AreEqual(cal.Execute("+"), 15);
        }
        [TestMethod]
        public void Test_Tru()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [TestMethod]
        public void Test_Nhan()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_Chia()
        {
            Calculation c = new Calculation(10, 0);
        }
        [TestMethod]
        public void Text_LamTron()
        {
            
            Assert.AreEqual(c.Execute("/"), 2);
        }
    }
}
