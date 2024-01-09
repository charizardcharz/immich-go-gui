using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ImmichGoGui
{
    internal class ConfigUtils
    {
        private const string CONFIG_FILE_PATH = "config.json";

        public static AppConfig getConfig()
        {
            AppConfig config = null;
            try
            {
                string jsonString = File.ReadAllText(CONFIG_FILE_PATH);
                Console.WriteLine(jsonString);

                if (String.IsNullOrEmpty(jsonString))
                {
                    config = initConfig();
                }
                else
                {
                    config = JsonSerializer.Deserialize<AppConfig>(jsonString);
                }
            }
            catch (FileNotFoundException ex)
            {
                config = initConfig();
            }

            return config;
        }

        static AppConfig initConfig()
        {
            Console.WriteLine("Initializing Config File");
            AppConfig config = new AppConfig();
            config.immichURL = "http://localhost:2283";
            config.APIKey = "";

            saveConfig(config);

            return config;
        }

        public static void saveConfig(AppConfig config)
        {
            string jsonString = JsonSerializer.Serialize(config);

            using (TextWriter outputFile = new StreamWriter(CONFIG_FILE_PATH))
            {
                outputFile.WriteAsync(jsonString);
            }
           
        }
    }
}
