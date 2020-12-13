using System;
using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;

namespace Shop
{
    public static class Config
    {
        private static String m_Path = Directory.GetCurrentDirectory() + @"\Config\config.config";

        public static Dictionary<String, String> GetConfig()
        {
            Dictionary<String, String> config = new Dictionary<String, String>();
            /*

            var conf = System.IO.File.ReadAllText(m_Path);

            var deserializer = new Deserializer();

            Console.WriteLine(deserializer.Deserialize(conf));
            */
            return null;
        }

    }
}
