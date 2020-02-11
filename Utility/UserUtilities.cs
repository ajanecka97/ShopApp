using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace ShopCore.Utility
{
    public class UserUtilities
    {

        private const int SaltSize = 16;
        private const int HashSize = 20;

        /// <summary>
        /// Method hashes password with HMACSHA1 algorithm.
        /// </summary>
        /// <param name="password">Not hashed password</param>
        /// <returns>Hashed password</returns>
        public static string HashPassword(string password)
        {

            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
            var hash = pbkdf2.GetBytes(HashSize);

            var hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            var base64Hash = Convert.ToBase64String(hashBytes);

            return base64Hash.ToString();
        }

        /// <summary>
        /// Method checks if asked password is the same as hashed password
        /// </summary>
        /// <param name="password">Not hashed password</param>
        /// <param name="hashedPassword">Hashed password</param>
        /// <returns>True if passwords are the same, false otherwise</returns>
        public static bool Verify(string password, string hashedPassword)
        { 
            var iterations = 10000;

            // Get hash bytes
            var hashBytes = Convert.FromBase64String(hashedPassword);

            // Get salt
            var salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            // Create hash with given salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            var base64Hash = Convert.ToBase64String(hash);
            var salt64 = Convert.ToBase64String(salt);

            // Get result
            for (var i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool VerifyEmail(string email)
        {
            Regex regex = new Regex(@"@[a-z0-9]+\.[a-z]+");
            Match match = regex.Match(email);
            if (!match.Success) return false;

            return true;
        }


    }
}
