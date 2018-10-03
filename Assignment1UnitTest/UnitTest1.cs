using Assignment1DLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment1UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Togram1()
        {
            Assert.AreEqual(28.34952, Convertion.ConvertToGram(1), 0.1);
        }

        [TestMethod]
        public void Togram2()
        {
            Assert.AreEqual(283.4952, Convertion.ConvertToGram(10), 0.1);
        }

        [TestMethod]
        public void Togram3()
        {
            Assert.AreEqual(28321.17048, Convertion.ConvertToGram(999), 0.1);
        }

        [TestMethod]
        public void Togram4()
        {
            Assert.AreEqual(0, Convertion.ConvertToGram(0), 0.1);
        }

        [TestMethod]
        public void Togram5()
        {
            Assert.AreEqual(-28321.17048, Convertion.ConvertToGram(-999), 0.1);
        }

        [TestMethod]
        public void ToOunce1()
        {
            Assert.AreEqual(0.03527396195, Convertion.ConvertToOunces(1), 0.1);
        }

        [TestMethod]
        public void ToOunce2()
        {
            Assert.AreEqual(0.3527396195, Convertion.ConvertToOunces(10), 0.1);
        }

        [TestMethod]
        public void ToOunce3()
        {
            Assert.AreEqual(35.238687988, Convertion.ConvertToOunces(999), 0.1);
        }

        [TestMethod]
        public void ToOunce4()
        {
            Assert.AreEqual(0, Convertion.ConvertToOunces(0), 0.1);
        }

        [TestMethod]
        public void ToOunce5()
        {
            Assert.AreEqual(-35.238687988, Convertion.ConvertToOunces(-999), 0.1);
        }
    }
}
