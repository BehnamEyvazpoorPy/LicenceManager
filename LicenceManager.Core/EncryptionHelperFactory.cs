using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.Core
{
    static class EncryptionHelperFactory
    {
        public static IEncryptionHelper GetEncryptionHelper()
        {
            return new EncryptionHelper();
        }
    }
}
