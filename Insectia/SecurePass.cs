using System.Security.Cryptography;
using System.Text;

namespace Insectia
{
    static class SecurePass
    {
        public static byte[] GetProtectedPassword(string password)
        {
            byte[] plain = Encoding.UTF8.GetBytes(password);
            byte[] cipher = ProtectedData.Protect(plain, null, DataProtectionScope.CurrentUser);
            return cipher;
        }

        public static string GetUnprotectedPassword(byte[] protectedPassword)
        {
            if (protectedPassword != null)
            {
                byte[] cipher = protectedPassword;
                byte[] plain = ProtectedData.Unprotect(cipher, null, DataProtectionScope.CurrentUser);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in plain)
                {
                    sb.Append((char)b);
                }
                string result = sb.ToString();
                sb.Clear();
                return result;
            }
            return null;
        }
    }
}
