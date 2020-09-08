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
            String pathFile = @"C:\Users\juan.montoya\Desktop\viacheck_mobile\test-images\ImageOriginal6.tiff";
            // byte[] ImageInArrayOfBytes = LoadImagesFromFiles.ImageToByteArray(pathFile);
            var ImageBase64 = LoadImagesFromFiles.ImageToBase64(pathFile);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}


