using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsqLibrary
{
    public static class FileIO
    {
        private static string configFilePath = "config.txt";

        public static void WriteFilePathToConfigFile(string filePathToSave)
        {
            File.WriteAllText(configFilePath, filePathToSave);
        }

        public static string ReadFilePathFromConfigFile()
        {
            string output = string.Empty;

            if (File.Exists(configFilePath))
            {
                output = File.ReadAllText(configFilePath);
            }

            return output;
        }
    }
}
