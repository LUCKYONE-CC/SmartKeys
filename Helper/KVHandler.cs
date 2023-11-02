using Newtonsoft.Json;
using SmartKeys.Exceptions;
using SmartKeys.Models;
using System.Windows.Forms;

namespace SmartKeys.Helper
{
    public static class KVHandler
    {
        public static void GenerateKV(string name, string password, string path)
        {
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(name);
            KeyVault vault = new KeyVault
            {
                VaultName = fileNameWithoutExtension
            };

            string filePath = Path.Combine(path, name);

            WriteVaultToFile(vault, password, filePath);

            Console.WriteLine("Die Datei wurde erstellt: " + filePath);
        }

        public static KeyVault ReadKV(string filePath, string password)
        {
            if (!VerifyPassword(filePath, password))
            {
                throw new InvalidPasswordException();
            }

            string content = File.ReadAllText(filePath);

            string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            string encryptedContent = string.Join(Environment.NewLine, lines, 1, lines.Length - 1);

            string decryptedContent = Security.Decrypt(encryptedContent, password);

            return JsonConvert.DeserializeObject<KeyVault>(decryptedContent);
        }

        public static DefaultEntry AddEntry(string filePath, DefaultEntry entry, string password)
        {
            KeyVault vault = ReadKV(filePath, password);

            if (vault == null)
            {
                throw new Exception("Die Datei konnte nicht gelesen werden.");
            }

            // Überprüfe, ob der Eintrag bereits vorhanden ist
            if (vault.Entrys.Find(e => e.Title == entry.Title) != null)
            {
                throw new Exception($"Eintrag mit dem Titel '{entry.Title}' existiert bereits.");
            }

            entry.Id = Guid.NewGuid();
            vault.Entrys.Add(entry);

            WriteVaultToFile(vault, password, filePath);

            MessageBox.Show($"Der Eintrag '{entry.Title}' wurde hinzugefügt.");

            return entry;
        }

        public static void RemoveEntry(string filePath, Guid id, string password)
        {
            KeyVault vault = ReadKV(filePath, password);

            if (vault == null)
            {
                throw new Exception("Die Datei konnte nicht gelesen werden.");
            }

            if (vault.Entrys == null || vault.Entrys.Count == 0)
            {
                throw new Exception("Es wurden keine Einträge gefunden.");
            }

            DefaultEntry entryToRemove = vault.Entrys.Find(e => e.Id == id);

            if (entryToRemove == null)
            {
                throw new Exception("Der Eintrag konnte nicht gefunden werden.");
            }

            vault.Entrys.Remove(entryToRemove);

            WriteVaultToFile(vault, password, filePath);

            Console.WriteLine($"Der Eintrag '{id}' wurde entfernt.");
        }

        private static void WriteVaultToFile(KeyVault vault, string password, string filePath)
        {
            string jsonContent = JsonConvert.SerializeObject(vault, Formatting.Indented);

            string encryptedContent = Security.Encrypt(jsonContent, password);
            
            File.WriteAllText(filePath, BCrypt.Net.BCrypt.HashPassword(password) + Environment.NewLine + encryptedContent);
        }

        private static bool VerifyPassword(string filePath, string inputPassword)
        {
            string content = File.ReadAllText(filePath);

            string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            if (lines.Length > 0)
            {
                string storedPasswordHash = lines[0];

                return BCrypt.Net.BCrypt.Verify(inputPassword, storedPasswordHash);
            }

            return false;
        }
    }
}
