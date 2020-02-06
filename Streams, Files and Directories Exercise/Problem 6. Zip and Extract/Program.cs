using System;
using System.IO.Compression;

namespace Problem_6._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = "copyMe.png";
            string targetPath = "../../../rezult.zip";
            string desctopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            ZipFile.Open(folderPath, ZipArchiveMode.Read);

            ZipFile.ExtractToDirectory(targetPath, desctopPath);
        }
    }
}
