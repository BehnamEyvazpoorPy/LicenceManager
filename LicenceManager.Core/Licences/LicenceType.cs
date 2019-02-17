using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LicenceManager.Core.Licences
{
    [Serializable]
    public enum LicenceType
    {
        Full = 0,
        FinancialAudit = 1,
        Medical = 2,
        MedicalArchive = 3
    }
}
