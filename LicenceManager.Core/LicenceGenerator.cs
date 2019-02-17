using LicenceManager.Core.Licences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.Core
{
    public class LicenceGenerator
    {
        private IObjectHelper _objectHelper;
        private IEncryptionHelper _encryptionHelper;

        public LicenceGenerator()
        {
            _objectHelper = ObjectHelperFactory.GetObjectHelperFactory();
            _encryptionHelper = EncryptionHelperFactory.GetEncryptionHelper();
        }

        public string Generate(Licence licence, string serial)
        {
            var licencePack = new LicencePack
            {
                Licence = licence,
                Serial = serial
            };

            string licencePackString = _objectHelper.Serialize<LicencePack>(licencePack);
            return _encryptionHelper.Encrypt(licencePackString);

        }
    }
}
