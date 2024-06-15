using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Webp;

namespace WebpResizer
{
    public class ImageConverter
    {
        public static void ConvertWebPToPng(string webpFilePath, string pngFilePath)
        {
            // Load the WebP image
            using (Image image = Image.Load(webpFilePath))
            {
                // Save the image as PNG
                image.Save(pngFilePath, new PngEncoder());
            }
        }
        public static void ConvertPngToWebP(string webpFilePath, string pngFilePath)
        {
            // Load the Png image
            using (Image image = Image.Load(webpFilePath))
            {
                // Save the image as PNG
                image.Save(pngFilePath, new WebpEncoder());
            }
        }
    }
}
