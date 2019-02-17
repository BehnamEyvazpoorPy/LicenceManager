using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LicenceManager.Core.Licences;

namespace LicenceManager.Core.Test
{
    [TestClass]
    public class LicenceGeneratorTest
    {
        [TestMethod]
        public void GenerateLicencePackTest()
        {
            var licenceGenerator = new LicenceGenerator();
            var serialGenerator = SerialGeneratorFactory.GetSerialGenerator();
            var licenceValidator = new LicenceValidator(serialGenerator);

            LicenceType licenceType = LicenceType.Full;
            var licence = new Licence
            {
                CustomerName = "Kookdc",
                Trial = true,
                CreationDate = DateTime.Now,
                TrialDays = 50,
                Type = licenceType
            };
            var licencePackString = licenceGenerator.Generate(licence, serialGenerator.Generate());
            var returnedLicence =licenceValidator.CheckLicence(licencePackString);

            Assert.AreEqual(returnedLicence.CustomerName, licence.CustomerName);
        }
    }
}
