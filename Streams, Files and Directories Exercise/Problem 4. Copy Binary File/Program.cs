using System;
using System.IO;

namespace Problem_4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string picturePath = "copyMe.png";
            string copypicturePath = "copyMe-copy.png";

            using (FileStream streamreader = new FileStream(picturePath,FileMode.Open))
            {
                using (FileStream streamwriter = new FileStream(copypicturePath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[4096];
                        int size = streamreader.Read(byteArray, 0, byteArray.Length);

                        if (size==0)
                        {
                            break;
                        }

                        streamwriter.Write(byteArray, 0, byteArray.Length);
                    }
               
                }
           
            }
        }
    }
}
