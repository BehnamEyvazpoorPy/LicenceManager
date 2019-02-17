using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LicenceManager.Core.Test
{
    [TestClass]
    public class SerialGeneratorTest
    {
        [TestMethod]
        public void SerialGeneratingTest()
        {
            ISerialGenerator serialGenerator = SerialGeneratorFactory.GetSerialGenerator();
            string serial = serialGenerator.Generate();
            Assert.AreNotEqual(serial, "");
        }
    }
}
