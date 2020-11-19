using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System.Management;
using System;
using System.Collections;

namespace XylosAntivir_Example
{
   

    public class SystemInformation
    {
        public static string GetAntiVirus()
        {
            string str = null;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"\\" + Environment.MachineName + @"\root\SecurityCenter2", "SELECT * FROM AntivirusProduct");
            ManagementObjectCollection instances = searcher.Get();
            foreach (ManagementObject queryObj in instances)
                str = queryObj["displayName"].ToString();
            return str;
        }

        public static string GetFirewall()
        {
            string str = null;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"\\" + Environment.MachineName + @"\root\SecurityCenter2", "SELECT * FROM FirewallProduct");
            ManagementObjectCollection instances = searcher.Get();
            foreach (ManagementObject queryObj in instances)
                str = queryObj["displayName"].ToString();
            return str;
        }

        public static string GetComputerInformation()
        {
            return getOS() + Constants.vbNewLine + getProcessor() + Constants.vbNewLine + osb() + " , " + ram();
        }


        private static string getOS()
        {
            var cInfo = new Microsoft.VisualBasic.Devices.ComputerInfo().OSFullName;
            return cInfo + GetServicePack().ToString();
        }
      
        private static string getProcessor()
        {
            string SoftwareKey = @"HARDWARE\DESCRIPTION\System\CentralProcessor\0";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(SoftwareKey))
            {
                RegistryKey propertiesKey = Registry.LocalMachine.OpenSubKey(SoftwareKey, false);

                var name = propertiesKey.GetValue("ProcessorNameString");
                return System.Convert.ToString(name);
                propertiesKey.Close();
            }
        }

        private static string osb()
        {
            if ((Environment.Is64BitOperatingSystem) == true)
                return "OS 64 bits ";
            else
                return "OS 32 bits ";
        }

        private static string ram()
        {
            var cPhysical = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
            return "RAM " + System.Math.Round((cPhysical) / (double)1073741824).ToString() + " Go";
        }

        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern short GetVersionExA(ref OSVERSIONINFO lpVersionInformation);

        public static string GetServicePack()
        {
            OSVERSIONINFO osinfoA= new OSVERSIONINFO();

            short retvalue;
            osinfoA.dwOSVersionInfoSize = 148;
            retvalue = GetVersionExA(ref osinfoA);
            if (Strings.Len(osinfoA.szCSDVersion) == 0)
                return ("");
            else
                return " - " + (System.Convert.ToString(osinfoA.szCSDVersion));
        }

       
        private struct OSVERSIONINFO
        {
            public int dwOSVersionInfoSize;
            public int dwMajorVersion;
            public int dwMinorVersion;
            public int dwBuildNumber;
            public int dwPlatformId;
            [VBFixedString(128)]
            [System.Runtime.InteropServices.MarshalAs
                   (System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szCSDVersion;
        }
    }

}
