using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Converting the password string into a byte array
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Compute the hash of the byte array
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Convert the byte array into a hexadecimal string
                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2"));
                }

                // Return the hexadecimal string representation of the hash 
                return hashString.ToString();
            }
        }
    }
}
