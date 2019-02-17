using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.Core
{
    public interface IObjectHelper
    {
        string Serialize<TObject>(TObject toSerialize);
        TObject Deserialize<TObject>(string toDeserialize);
    }
}
