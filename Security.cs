using System.Security.Cryptography;
using System.Text;

namespace SmartKeys
{
    public static class Security
    {
        private static byte[] GetKeyAndIV(string password, byte[] salt)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                return deriveBytes.GetBytes(48);
            }
        }

        public static string Encrypt(string plainText, string password)
        {
            byte[] salt = new byte[16];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetBytes(salt);
            }

            byte[] keyAndIV = GetKeyAndIV(password, salt);

            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Key = keyAndIV.Take(32).ToArray();
                aes.IV = keyAndIV.Skip(32).ToArray();

                using (var encryptor = aes.CreateEncryptor())
                using (var memoryStream = new MemoryStream())
                {
                    memoryStream.Write(salt, 0, salt.Length);
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    using (var streamWriter = new StreamWriter(cryptoStream))
                    {
                        streamWriter.Write(plainText);
                    }

                    return Convert.ToBase64String(memoryStream.ToArray());
                }
            }
        }

        public static string Decrypt(string cipherText, string password)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            byte[] salt = cipherBytes.Take(16).ToArray();
            byte[] keyAndIV = GetKeyAndIV(password, salt);

            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Key = keyAndIV.Take(32).ToArray();
                aes.IV = keyAndIV.Skip(32).ToArray();

                using (var decryptor = aes.CreateDecryptor())
                using (var memoryStream = new MemoryStream(cipherBytes, 16, cipherBytes.Length - 16))
                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                using (var streamReader = new StreamReader(cryptoStream))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }
    }
}
