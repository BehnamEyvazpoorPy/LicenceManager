using LicenceManager.Core.ObjectHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.Core
{
    static class ObjectHelperFactory
    {
        public static IObjectHelper GetObjectHelperFactory()
        {
            return new XmlObjectHelper();
        }
    }
}
