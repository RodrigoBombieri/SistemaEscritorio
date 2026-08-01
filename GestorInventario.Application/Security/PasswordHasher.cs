using System;
using System.Security.Cryptography;

namespace GestorInventario.Application.Security
{
    /// <summary>
    /// Hashing de contraseñas con PBKDF2 (SHA256). El resultado de Hash() se guarda
    /// tal cual en Usuario.PasswordHash: "{iteraciones}.{salt en base64}.{hash en base64}".
    /// </summary>
    public static class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int KeySize = 32;
        private const int Iterations = 100_000;

        public static string Hash(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(SaltSize);
            var key = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, KeySize);

            return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(key)}";
        }

        public static bool Verify(string password, string passwordHash)
        {
            if (string.IsNullOrWhiteSpace(passwordHash))
                return false;

            var partes = passwordHash.Split('.');
            if (partes.Length != 3)
                return false;

            if (!int.TryParse(partes[0], out var iterations))
                return false;

            byte[] salt;
            byte[] key;
            try
            {
                salt = Convert.FromBase64String(partes[1]);
                key = Convert.FromBase64String(partes[2]);
            }
            catch (FormatException)
            {
                return false;
            }

            var keyIntentado = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, HashAlgorithmName.SHA256, key.Length);

            return CryptographicOperations.FixedTimeEquals(key, keyIntentado);
        }
    }
}
