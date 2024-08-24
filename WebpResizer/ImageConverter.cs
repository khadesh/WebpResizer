using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
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
                // Save the original image as PNG
                image.Save(pngFilePath, new PngEncoder());

                // Create the second image with a size of 256x256 pixels
                using (Image resizedImage = image.Clone(x => x.Resize(256, 256)))
                {
                    // Modify the file name to add "-256" before the extension
                    string directory = Path.GetDirectoryName(pngFilePath);
                    string filenameWithoutExtension = Path.GetFileNameWithoutExtension(pngFilePath);
                    string extension = Path.GetExtension(pngFilePath);
                    string newFileName = Path.Combine(directory, filenameWithoutExtension + "-256" + extension);

                    // Save the resized image as PNG
                    resizedImage.Save(newFileName, new PngEncoder());
                }
            }
        }

        public static void ConvertWebPToJpg(string webpFilePath, string pngFilePath)
        {
            // Load the WebP image
            using (Image image = Image.Load(webpFilePath))
            {
                // Save the image as JPG
                image.Save(pngFilePath, new JpegEncoder());
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

        public static void ProcessDirectoryToPng(string directoryPath, string toDirPath)
        {
            // Get all .webp files in the directory
            var webpFiles = Directory.GetFiles(directoryPath, "*.webp");

            // Call ResizeImage on each .webp file
            foreach (var file in webpFiles)
            {
                Console.WriteLine($"Processing: {file}");
                ConvertWebPToPng(file, file.Replace(directoryPath, toDirPath).Replace(".webp", ".png"));
            }
        }

        public static void ProcessDirectoryToWebp(string directoryPath, string toDirPath)
        {
            // Get all .webp files in the directory
            var webpFiles = Directory.GetFiles(directoryPath, "*.png");

            // Call ResizeImage on each .webp file
            foreach (var file in webpFiles)
            {
                Console.WriteLine($"Processing: {file}");
                ConvertPngToWebP(file, file.Replace(directoryPath, toDirPath).Replace(".png", ".webp"));
            }
        }

        public static void ProcessDirectoryToJpg(string directoryPath, string toDirPath)
        {
            // Get all .webp files in the directory
            var webpFiles = Directory.GetFiles(directoryPath, "*.webp");

            // Call ResizeImage on each .webp file
            foreach (var file in webpFiles)
            {
                Console.WriteLine($"Processing: {file}");
                ConvertWebPToJpg(file, file.Replace(directoryPath, toDirPath).Replace(".webp", ".jpg"));
            }
        }
    }
}
