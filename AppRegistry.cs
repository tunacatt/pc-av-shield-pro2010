using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace PC_Anti_Virus_Shield_Pro_2010
{
    public static class AppRegistry
    {
        private const string RegistryPath = @"Software\PC_Anti_Virus_Shield_Pro_2010";
        private const string ProEnabledKey = "ProEnabled";
        private const string WasScannedBeforeKey = "WasScannedBefore";
        private const string ThreatsRemovedKey = "ThreatsRemoved";
        private const string NotificationsEnabledKey = "NotificationsEnabled";
        private const string LicenseKey = "GH8JK-LZX2V-NM6QE-RTY0U-YU60P";
        private const string DebugPass = "Ir061b#;";

        public static bool IsActivated()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                return key?.GetValue(ProEnabledKey)?.ToString() == "1";
            }
        }

        public static bool WasScannedBefore()
        { 
            using (var key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                return key?.GetValue(WasScannedBeforeKey)?.ToString() == "1";
            }
        }

        public static bool ThreatsRemoved()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                return key?.GetValue(ThreatsRemovedKey)?.ToString() == "1";
            }
        }

        public static bool NotificationsEnabled()
        {
            using (var key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                return key?.GetValue(NotificationsEnabledKey)?.ToString() == "1";
            }
        }

        public static void SetActivated(bool activated)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(RegistryPath))
            {
                key.SetValue(ProEnabledKey, activated ? "1" : "0");
            }
        }

        public static void SetWasScannedBefore(bool scanned)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(RegistryPath))
            {
                key.SetValue(WasScannedBeforeKey, scanned ? "1" : "0");
            }
        }

        public static void RemoveThreats(bool removed)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(RegistryPath))
            {
                key.SetValue(ThreatsRemovedKey, removed ? "1" : "0");
            }
        }

        public static void SwitchNotifications(bool enabled)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(RegistryPath))
            {
                key.SetValue(NotificationsEnabledKey, enabled ? "1" : "0");
            }
        }

        public static bool TryActivate(string inputKey)
        { 
            if (inputKey.Trim().Equals(LicenseKey, StringComparison.OrdinalIgnoreCase))
            {
                SetActivated(true);
                return true;
            }
            return false;
        }

        public static bool TryEnableDebug(string inputKey)
        {
            if (inputKey.Trim().Equals(DebugPass, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
