using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.Core
{
    interface ILicenceRegistrationHelper
    {
        void Register(string licencePackString);
        bool CheckForLicenceRegistration();
        string GetLicence();
    }
}
