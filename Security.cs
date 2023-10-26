using System.Security.Cryptography;
using System.Text;

namespace SmartKeys
{
    public static class Security
    {
        public static async void EncryptFile(string inputFile, string password)
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Mode = CipherMode.CFB;
                aes.Padding = PaddingMode.PKCS7;

                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] salt = new byte[16];
                RandomNumberGenerator.Create().GetBytes(salt);

                Rfc2898DeriveBytes keyDerivationFunction = new Rfc2898DeriveBytes(passwordBytes, salt, 10000);
                aes.Key = keyDerivationFunction.GetBytes(aes.KeySize / 8);
                aes.IV = keyDerivationFunction.GetBytes(aes.BlockSize / 8);

                using (FileStream inputFileStream = new FileStream(inputFile, FileMode.Open))
                using (FileStream encryptedFileStream = new FileStream(inputFile + ".ares", FileMode.Create))
                {
                    // Write the salt to the beginning of the file
                    encryptedFileStream.Write(salt, 0, salt.Length);

                    using (CryptoStream cs = new CryptoStream(encryptedFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        inputFileStream.CopyTo(cs);
                    }
                }

                File.Delete(inputFile);
            }
        }

        public async static void DecryptFile(string encryptedFile, string password)
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Mode = CipherMode.CFB;
                aes.Padding = PaddingMode.PKCS7;

                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Read the salt from the beginning of the file
                byte[] salt = new byte[16];
                using (FileStream encryptedFileStream = new FileStream(encryptedFile, FileMode.Open))
                {
                    encryptedFileStream.Read(salt, 0, salt.Length);
                }

                Rfc2898DeriveBytes keyDerivationFunction = new Rfc2898DeriveBytes(passwordBytes, salt, 10000);
                aes.Key = keyDerivationFunction.GetBytes(aes.KeySize / 8);
                aes.IV = keyDerivationFunction.GetBytes(aes.BlockSize / 8);

                using (FileStream encryptedFileStream = new FileStream(encryptedFile, FileMode.Open))
                using (FileStream decryptedFileStream = new FileStream(encryptedFile.Replace(".ares", ""), FileMode.Create))
                {
                    // Skip the salt during decryption
                    encryptedFileStream.Seek(salt.Length, SeekOrigin.Begin);

                    using (CryptoStream cs = new CryptoStream(decryptedFileStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        encryptedFileStream.CopyTo(cs);
                    }
                }

                File.Delete(encryptedFile);
            }
        }
    }
}
