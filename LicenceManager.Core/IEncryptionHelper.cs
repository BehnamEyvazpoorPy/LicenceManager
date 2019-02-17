using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.Core
{
    interface IEncryptionHelper
    {
        string Encrypt(string clearText);
        string Decrypt(string cipherText);
    }
}
