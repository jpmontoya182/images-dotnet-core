using System;
using System.IO;
using System.Drawing;

namespace TestImagesBusiness.Helpers
{
    public class SaveImages
    {
        public void SaveImageFromBase64(string ImageBase64, string PathTosave, System.Drawing.Imaging.ImageFormat ImageFormat)
        {
            byte[] imageBytes = Convert.FromBase64String(ImageBase64);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                image.Save(PathTosave, ImageFormat);

            }
        }
    }
}