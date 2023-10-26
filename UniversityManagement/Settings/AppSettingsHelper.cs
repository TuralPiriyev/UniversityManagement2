using System;
using System.IO;
using System.Text.Json;

namespace UniversityManagement.Settings
{
    public class AppSettingsHelper
    {
        private readonly string _configurationPath;

        private AppSettingsHelper(string configurationPath)
        {
            _configurationPath = configurationPath;
        }

        public AppSettings ReadFromFile()
        {
            string filename = Path.Combine(_configurationPath, "UniversityManagement.settings.json");

            if (File.Exists(filename) == false)
            {
                return null;
            }

            string settingsRaw = File.ReadAllText(filename);

            // JSON dizesini AppSettings sınıfına dönüştürmek için Deserialize kullanılır.
            AppSettings settings = JsonSerializer.Deserialize<AppSettings>(settingsRaw);

            return settings;
        }

        public void SaveSettings(AppSettings settings)
        {
            string filename = Path.Combine(_configurationPath, "UniversityManagement.settings.json");

            // AppSettings nesnesini JSON dizesine dönüştürmek için Serialize kullanılır.
            string settingsRaw = JsonSerializer.Serialize(settings, new JsonSerializerOptions
            {
                WriteIndented = true // İsteğe bağlı: JSON'in okunaklı olması için girinti ekleyin
            });

            File.WriteAllText(filename, settingsRaw);
        }

        internal AppSettings GetSettings()
        {
            throw new NotImplementedException();
        }
    }
}
