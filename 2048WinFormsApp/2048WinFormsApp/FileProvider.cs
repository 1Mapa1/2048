using System;
using System.IO;
using System.Text;

namespace _2048ClassLibrary
{
    public class FileProvider
    {
        public static void Replace(string data, string fileName)
        {
            var writer = new StreamWriter(fileName, false, Encoding.UTF8);
            writer.WriteLine(data);
            writer.Close();
        }

        public static bool Exists(string fileName)
        {
            return File.Exists(fileName);
        }

        public static string GetData(string fileName)
        {
            var writer = new StreamWriter(fileName, true, Encoding.UTF8);
            writer.Close();
            var reader = new StreamReader(fileName, Encoding.UTF8);
            string value = reader.ReadToEnd();
            reader.Close();
            return value;
        }
    }
}
