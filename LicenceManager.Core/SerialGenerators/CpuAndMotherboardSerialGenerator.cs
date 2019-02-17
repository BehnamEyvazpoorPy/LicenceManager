using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.Core.SerialGenerators
{
    public class CpuAndMotherboardSerialGenerator : ISerialGenerator
    {
        private static Lazy<CpuAndMotherboardSerialGenerator> _singleInstance =
            new Lazy<CpuAndMotherboardSerialGenerator>(() => new CpuAndMotherboardSerialGenerator(), true);
        public static CpuAndMotherboardSerialGenerator SingleInstance => _singleInstance.Value;

        private CpuAndMotherboardSerialGenerator()
        {

        }

        public string Generate()
        {
            ManagementObjectCollection moc = null;
            ManagementObjectSearcher mos;
            string cpuID = string.Empty, baseBoardID = string.Empty;
            mos = new ManagementObjectSearcher("Select * From Win32_processor");
            moc = mos.Get();
            foreach (ManagementObject mo in moc)
            {
                cpuID = mo["ProcessorID"].ToString();
            }
            mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            moc = mos.Get();
            foreach (ManagementObject mo in moc)
            {
                baseBoardID = mo["SerialNumber"].ToString();
            }
            return cpuID + baseBoardID;
        }
    }
}
