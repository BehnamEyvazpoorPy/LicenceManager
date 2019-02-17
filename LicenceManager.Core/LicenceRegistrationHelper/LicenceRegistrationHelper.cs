using LicenceManager.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LicenceManager.Core.LicenceRegistrationHelper
{
    public class LicenceRegistrationHelper : ILicenceRegistrationHelper
    {
        private ILicenceRegistrationHelper _licenceRegistrationHelper;
        private LicenceRegistrationHelper(ILicenceRegistrationHelper licenceRegistrationHelper)
        {
            _licenceRegistrationHelper = licenceRegistrationHelper;
        }
        public bool CheckForLicenceRegistration()
        {
            return _licenceRegistrationHelper.CheckForLicenceRegistration();
        }
        public string GetLicence()
        {
            return _licenceRegistrationHelper.GetLicence();
        }
        public void Register(string licencePackString)
        {
            _licenceRegistrationHelper.Register(licencePackString);
        }

        private static LicenceRegistrationHelperFactory factory = LicenceRegistrationHelperFactory.SingleInstance;
        public static LicenceRegistrationHelperFactory Factory => factory;

        public class LicenceRegistrationHelperFactory
        {
            private Dictionary<string, Type> _registrationHelpers =
                new Dictionary<string, Type>();
            private static readonly LicenceRegistrationHelperFactory _singleInstance = new LicenceRegistrationHelperFactory();
            private LicenceRegistrationHelperFactory()
            {
                var licenceRegistrationHelperTypes = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => t.Namespace == "LicenceManager.Core.LicenceRegistrationHelper"
                    && typeof(ILicenceRegistrationHelper).IsAssignableFrom(t));
                foreach (var type in licenceRegistrationHelperTypes)
                {
                    _registrationHelpers.Add(type.Name, type);
                }

            }
            public static LicenceRegistrationHelperFactory SingleInstance => _singleInstance;
            public LicenceRegistrationHelper CreateNew(RegistrationMode registrationMode)
            {
                string typeName = Enum.GetName(typeof(RegistrationMode), registrationMode);
                if (!_registrationHelpers.Keys.Contains(typeName))
                {
                    throw new NotImplementedException($"{typeName} is not implemented.");
                }
                return new LicenceRegistrationHelper((ILicenceRegistrationHelper)Activator
                    .CreateInstance(_registrationHelpers[typeName]));

            }
        }
    }
}
