using LicenceManager.Core.Exceptions;
using LicenceManager.Core.Licences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.Core
{
    public class LicenceValidator
    {
        private ISerialGenerator _serialGenerator;
        private IEncryptionHelper _encryptionHelper;
        private IObjectHelper _objectHelper;

        public LicenceValidator(ISerialGenerator serialGenerator)
        {
            _serialGenerator = serialGenerator;
            _encryptionHelper = EncryptionHelperFactory.GetEncryptionHelper();
            _objectHelper = ObjectHelperFactory.GetObjectHelperFactory();
        }

        public Licence CheckLicence(string licencePackCipher)
        {
            string licencePackString = "";
            string licenceSerial = "";
            LicencePack licencePack = null;
            try
            {
                licencePackString = _encryptionHelper.Decrypt(licencePackCipher);
                licencePack = _objectHelper.Deserialize<LicencePack>(licencePackString);
                licenceSerial = _serialGenerator.Generate();
            }
            catch (Exception ex)
            {
                throw new InvalidLicenceException("Licence is not valid", ex);
            }
            if (licencePack.Serial != licenceSerial)
            {
                throw new InvalidLicenceException("Licence is not valid");
            }
            return licencePack.Licence;
        }
    }
}
