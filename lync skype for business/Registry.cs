using Microsoft.Win32;
using System;

namespace lync_skype_for_business
{
    public class registry
    {
        #region Write
        public static bool Write(string KeyName, byte[] Value, string openSubKey = Program.subKey)
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey(Program.regBase, true);
                RegistryKey sk1 = rk.CreateSubKey(openSubKey);
                // Save the value
                sk1.SetValue(KeyName, Value, RegistryValueKind.Binary);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
