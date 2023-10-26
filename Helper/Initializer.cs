using Newtonsoft.Json;
using SmartKeys.Models;
using System.Xml;

namespace SmartKeys.Helper
{
    public static class Initializer
    {
        private static bool IsInitialized = false;

        public static void Initialize()
        {
            if (IsInitialized == false)
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                string smartKeysFolderPath = Path.Combine(appDataPath, "SmartKeys");

                if (!Directory.Exists(smartKeysFolderPath))
                {
                    Directory.CreateDirectory(smartKeysFolderPath);
                    Console.WriteLine("Der SmartKeys-Ordner wurde erfolgreich erstellt.");
                }
                else
                {
                    Console.WriteLine("Der SmartKeys-Ordner existiert bereits.");
                }

                string configFilePath = Path.Combine(smartKeysFolderPath, "config.json");

                if (!File.Exists(configFilePath))
                {
                    ConfigData configData = new ConfigData
                    {
                        Masterpassword = "Masterpassword"
                    };

                    string jsonData = JsonConvert.SerializeObject(configData, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(configFilePath, jsonData);

                    Console.WriteLine("Die JSON-Konfigurationsdatei wurde erfolgreich erstellt.");
                }
                else
                {
                    Console.WriteLine("Die JSON-Konfigurationsdatei existiert bereits.");
                }

                IsInitialized = true;
            }
        }
    }
}
