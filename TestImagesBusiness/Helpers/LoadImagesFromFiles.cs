using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System;
using System.Text;

namespace TestImagesBusiness.Helpers
{
    public static class LoadImagesFromFiles
    {

        private static Image ImageFromFile(string pathFile)
        {
            Image newImage = Image.FromFile(pathFile);
            return newImage;
        }
        public static byte[] ImageToByteArray(string pathFile)
        {
            Image GetImage = ImageFromFile(pathFile);

            using (MemoryStream stream = new MemoryStream())
            {
                GetImage.Save(stream, ImageFormat.Tiff);
                return stream.ToArray();
            }
        }


        public static string ImageToBase64(string pathFile)
        {
            Image GetImage = ImageFromFile(pathFile);
            StringBuilder result = new StringBuilder();

            using (MemoryStream stream = new MemoryStream())
            {
                // save image in a stream
                GetImage.Save(stream, GetImage.RawFormat);
                byte[] imageBytes = stream.ToArray();

                // Convert byte[] to Base64 String
                result.Append(Convert.ToBase64String(imageBytes));
                return result.ToString();
            }
        }






    }
}