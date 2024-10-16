﻿using System.Security.Cryptography;
using System.Text;

namespace ASDP.FinalProject.Helpers
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            string enteredPasswordHash = PasswordHasher.HashPassword(enteredPassword);
            return enteredPasswordHash == hashedPassword;
        }
    }
}
