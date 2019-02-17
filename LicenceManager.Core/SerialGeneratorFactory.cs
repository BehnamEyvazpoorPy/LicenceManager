using LicenceManager.Core.SerialGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.Core
{
    public static class SerialGeneratorFactory
    {
        public static ISerialGenerator GetSerialGenerator()
        {
            return CpuAndMotherboardSerialGenerator.SingleInstance;
        }
    }
}
