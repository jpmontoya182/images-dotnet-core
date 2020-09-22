using System;
using System.Drawing;
using System.IO;
using TestImagesBusiness.Helpers;


namespace TestImagesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path of image to process");
            string pathFile = Console.ReadLine();
            Console.WriteLine("1. ImageToByteArray");
            Console.WriteLine("2. ImageToBase64");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    byte[] ImageInArrayOfBytes = LoadImagesFromFiles.ImageToByteArray(pathFile);
                    break;
                case "2":
                    var ImageBase64 = LoadImagesFromFiles.ImageToBase64(pathFile);
                    break;
                default:
                    break;

            }
            // @"C:\Users\juan.montoya\Desktop\viacheck_mobile\images\ImageOriginal6.tiff";
            // C:\Users\juan.montoya\Desktop\viacheck_mobile\images\agency-examples\20200622_185110_22.jpg
            Console.ReadLine();
        }
    }
}


