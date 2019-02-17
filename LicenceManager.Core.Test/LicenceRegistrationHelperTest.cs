using System;
using LicenceManager.Core.LicenceRegistrationHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LicenceManager.Core.Test
{
    [TestClass]
    public class LicenceRegistrationHelperTest
    {
        [TestMethod]
        public void RegisterLicenceAsAFileTest()
        {
            LicenceRegistrationHelper.LicenceRegistrationHelper licenceRegistrationHelper =
                LicenceRegistrationHelper.LicenceRegistrationHelper.Factory.CreateNew(Enums.RegistrationMode.AsAFile);
            licenceRegistrationHelper.Register("test");
            Assert.IsTrue(licenceRegistrationHelper.CheckForLicenceRegistration());
        }

        [TestMethod]
        public void GetLicenceAsAFileTest()
        {
            LicenceRegistrationHelper.LicenceRegistrationHelper licenceRegistrationHelper =
                 LicenceRegistrationHelper.LicenceRegistrationHelper.Factory.CreateNew(Enums.RegistrationMode.AsAFile);
            string licencePackString = licenceRegistrationHelper.GetLicence();
            Assert.AreEqual(licencePackString, "test");
        }

        [TestMethod]
        public void RegisterLicenceInRegisteryTest()
        {
            LicenceRegistrationHelper.LicenceRegistrationHelper licenceRegistrationHelper =
                 LicenceRegistrationHelper.LicenceRegistrationHelper.Factory.CreateNew(Enums.RegistrationMode.AsARegisterySetting);
            licenceRegistrationHelper.Register("test");
            Assert.IsTrue(licenceRegistrationHelper.CheckForLicenceRegistration());
        }

        [TestMethod]
        public void GetLicenceFromRegisteryTest()
        {
            LicenceRegistrationHelper.LicenceRegistrationHelper licenceRegistrationHelper =
                 LicenceRegistrationHelper.LicenceRegistrationHelper.Factory.CreateNew(Enums.RegistrationMode.AsARegisterySetting);
            string licencePackString = licenceRegistrationHelper.GetLicence();
            Assert.AreEqual(licencePackString, "test");
        }
    }
}
