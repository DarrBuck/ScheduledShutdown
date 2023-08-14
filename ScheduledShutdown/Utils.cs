using Microsoft.Win32;

namespace ScheduledShutdown
{
    internal class Utils
    {
        const string registryKey = "SOFTWARE\\ScheduledShutdown";

        public static void SaveSettingToRegistry(string settingName, string value)
        {
            try
            {
                // Open or create the application's registry key
                using RegistryKey key = Registry.CurrentUser.CreateSubKey(registryKey);
                // Save the setting name and value to the registry
                key.SetValue(settingName, value);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("An error occurred while saving the setting to the registry: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string GetSettingFromRegistry(string settingName = "")
        {
            string? value = "";

            try
            {
                // Open the application's registry key
                using RegistryKey? key = Registry.CurrentUser?.OpenSubKey(registryKey);
                // Retrieve the specified setting from the registry
                value = key?.GetValue(settingName)?.ToString();
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("An error occurred while retrieving the setting from the registry: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return value ?? "";
        }

        public static bool CheckMachineStartup(string appName, string appPath)
        {
            using RegistryKey? key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string? currentValue = key?.GetValue(appName)?.ToString();
            if (currentValue != null && currentValue.Equals(appPath, StringComparison.OrdinalIgnoreCase))
            {
                return true; // Startup entry for the application already exists
            }
            return false;
        }

        public static void AddToMachineStartup(string appName, string appPath)
        {
            using RegistryKey? key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string? currentValue = key?.GetValue(appName)?.ToString();
            if (currentValue != null && currentValue.Equals(appPath, StringComparison.OrdinalIgnoreCase))
            {
                return;     // Startup entry for the application already exists
            }

            key?.SetValue(appName, appPath);
        }

        public static void RemoveFromMachineStartup(string appName)
        {
            using (RegistryKey? key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key?.DeleteValue(appName, false);
            }

            using (RegistryKey? key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                string? currentValue = key?.GetValue(appName)?.ToString();
                if (currentValue != null)
                {
                    key?.DeleteValue(appName, false);
                }
            }
        }

    }

}
