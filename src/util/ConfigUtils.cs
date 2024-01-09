using System;
using System.IO;
using System.Text.Json;

namespace ImmichGoGui.util
{
    internal class ConfigUtils
    {
        private const string CONFIG_FILE_PATH = "config.json";

        public static AppConfig GetConfig()
        {
            AppConfig config;
            try
            {
                string jsonString = File.ReadAllText(CONFIG_FILE_PATH);
                Console.WriteLine(jsonString);

                if (String.IsNullOrEmpty(jsonString))
                {
                    config = InitConfig();
                }
                else
                {
                    config = JsonSerializer.Deserialize<AppConfig>(jsonString);
                }
            }
            catch (FileNotFoundException)
            {
                config = InitConfig();
            }

            return config;
        }

        public static void SaveConfig(AppConfig config)
        {
            string jsonString = JsonSerializer.Serialize(config);

            using (TextWriter outputFile = new StreamWriter(CONFIG_FILE_PATH))
            {
                outputFile.WriteAsync(jsonString);
            }
        }

        private static AppConfig InitConfig()
        {
            Console.WriteLine("Initializing Config File");
            AppConfig config = new AppConfig();
            config.ImmichURL = "http://localhost:2283";
            config.APIKey = "";

            SaveConfig(config);

            return config;
        }

    }
}
