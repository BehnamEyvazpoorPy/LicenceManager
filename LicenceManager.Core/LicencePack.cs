using LicenceManager.Core.Licences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LicenceManager.Core
{
    [XmlInclude(typeof(Licence))]
    [Serializable]
    public class LicencePack
    {
        public LicencePack()
        {
            
        }
        public Licence Licence { get; set; }
        public string Serial { get; set; }
    }
}
