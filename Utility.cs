using Microsoft.Win32;
using System;

namespace FuryKMS
{
    public class Utility
    {
        private static string RegistryWinPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion";
        // MainForm
        private static string os_mainForm;
        public static string MainForm_OSLabel
        {
            get { return os_mainForm; }
        }
        private static string net_mainForm;
        public static string MainForm_NETLabel
        {
            get { return net_mainForm; }
        }

        public static void WindowsInformation()
        {
            string osName = Registry.GetValue(RegistryWinPath, "productName", "").ToString();
            string osDisplayVer = Registry.GetValue(RegistryWinPath, "displayVersion", "").ToString();
            string osBuild = Registry.GetValue(RegistryWinPath, "currentBuildNumber", "").ToString();
            string osType = Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit";
            os_mainForm = osName + " " + osDisplayVer + " (" + osBuild + ") " + osType;
        }
        public static void NETFramework()
        {
            const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
            using (var ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                if (ndpKey != null && ndpKey.GetValue("Release") != null)
                {
                    net_mainForm = ($".NET Framework {CheckFor45PlusVersion((int)ndpKey.GetValue("Release"))}");
                }
            }
            string CheckFor45PlusVersion(int releaseKey)
            {
                if (releaseKey >= 528040)
                    return "4.8";
                if (releaseKey >= 461808)
                    return "4.7.2";
                if (releaseKey >= 461308)
                    return "4.7.1";
                if (releaseKey >= 460798)
                    return "4.7";
                if (releaseKey >= 394802)
                    return "4.6.2";
                if (releaseKey >= 394254)
                    return "4.6.1";
                if (releaseKey >= 393295)
                    return "4.6";
                if (releaseKey >= 379893)
                    return "4.5.2";
                if (releaseKey >= 378675)
                    return "4.5.1";
                if (releaseKey >= 378389)
                    return "4.5";
                return "¯\\_(ツ)_/¯";
            }
        }
    }
}