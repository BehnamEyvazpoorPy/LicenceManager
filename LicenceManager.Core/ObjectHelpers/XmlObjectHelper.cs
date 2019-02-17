using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LicenceManager.Core.ObjectHelpers
{
    class XmlObjectHelper : IObjectHelper
    {
        internal XmlObjectHelper()
        {

        }
        public TObject Deserialize<TObject>(string toDeserialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TObject));
            StringReader textReader = new StringReader(toDeserialize);
            return (TObject)xmlSerializer.Deserialize(textReader);
        }

        public string Serialize<TObject>(TObject toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TObject));
            StringWriter textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, toSerialize);
            return textWriter.ToString();
        }
    }
}
