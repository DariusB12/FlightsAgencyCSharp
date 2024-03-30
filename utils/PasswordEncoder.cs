using System;
using System.Security.Cryptography;
using System.Text;

namespace ProjectCS.utils
{
    public class PasswordEncoder
    {
        public static string encodePassword(string password)
        {
            var inputBytes = Encoding.UTF8.GetBytes(password);
            var sha256 = SHA256.Create();
            var inputHash = sha256.ComputeHash(inputBytes);
            return Encoding.ASCII.GetString(inputHash);
        }
    }
}