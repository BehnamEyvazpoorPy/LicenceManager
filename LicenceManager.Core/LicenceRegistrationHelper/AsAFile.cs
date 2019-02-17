using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.Core.LicenceRegistrationHelper
{
    class AsAFile : ILicenceRegistrationHelper
    {
        private Lazy<string> _registrationPath = new Lazy<string>(() =>
          {
              string registrationPath = ConfigurationManager.AppSettings["RegistrationPath"];
              switch (registrationPath.ToUpper())
              {
                  case "SYSTEM32":
                      {
                          return Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
                      }
                  case "STARTUPPATH":
                      {
                          return Environment.CurrentDirectory;
                      }
                  default:
                      {
                          return registrationPath;
                      }
              }
          }, true);


        public bool CheckForLicenceRegistration()
        {
            string licenceFileName = Path.Combine(_registrationPath.Value, "KookClinicLicence.loc");
            return File.Exists(licenceFileName);
        }

        public string GetLicence()
        {
            string licenceFileName = Path.Combine(_registrationPath.Value, "KookClinicLicence.loc");
            return File.ReadAllText(licenceFileName);
        }

        public void Register(string licencePackString)
        {
            string licenceFileName = Path.Combine(_registrationPath.Value, "KookClinicLicence.loc");
            File.WriteAllText(licenceFileName, licencePackString);
        }
    }
}
