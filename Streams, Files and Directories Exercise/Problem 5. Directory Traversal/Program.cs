using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filesArray = Directory.GetFiles("../");

            Dictionary<string, Dictionary<string, double>> dirInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo directoryInfo =new DirectoryInfo(".");

            FileInfo [] allFiles = directoryInfo.GetFiles();

            foreach (FileInfo file in allFiles)
            {
                double size = file.Length / 1024d;
                string fileName = file.Name;
                string extention = file.Extension;

                if (!dirInfo.ContainsKey(extention))
                {
                    dirInfo.Add(extention, new Dictionary<string, double>());
                }

                if (!dirInfo[extention].ContainsKey(fileName))
                {
                    dirInfo[extention].Add(fileName, size);
                }
                
            }
            string desctopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ @"/report.txt";
            var sorted = dirInfo.OrderBy(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var (extention, value) in sorted)
            {
                File.AppendAllText(desctopPath, extention + Environment.NewLine);

                foreach (var (filename, size) in value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(desctopPath, $"--{filename} - {Math.Round(size, 3)}kb" + Environment.NewLine);
                }
            }
        }
    }
}
