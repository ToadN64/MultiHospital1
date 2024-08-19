using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiHospital1
{
    public class CHash
    {
        public static string HashString(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hashBytes = sha.ComputeHash(textBytes);
                string hash = BitConverter.ToString(hashBytes);
                return hash;
            }
        }
    }
}
