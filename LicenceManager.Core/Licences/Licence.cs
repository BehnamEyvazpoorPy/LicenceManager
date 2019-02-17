using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LicenceManager.Core.Licences
{
    [Serializable]
    public class Licence
    {
        public string CustomerName { get; set; }
        public LicenceType Type { get; set; }
        public bool Trial { get; set; }
        public int TrialDays { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
