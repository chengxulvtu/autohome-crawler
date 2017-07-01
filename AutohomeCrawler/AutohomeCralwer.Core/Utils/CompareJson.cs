using System;
using System.Security.Cryptography;
using System.Text;

namespace AutohomeCralwer.Core
{
    public class CompareJson
    {
        public static bool Compare(string json1, string json2)
        {
            var sha1 = SHA1.Create();

            var hash1 = sha1.ComputeHash(Encoding.UTF8.GetBytes(json1));
            var hash2 = sha1.ComputeHash(Encoding.UTF8.GetBytes(json2));

            return Encoding.UTF8.GetString(hash1) == Encoding.UTF8.GetString(hash2);
        }
    }
}
