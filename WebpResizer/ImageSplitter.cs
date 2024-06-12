using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.PixelFormats;

namespace WebpResizer
{
    public class ImageSplitter
    {
        public static void SplitImageIntoQuadrants(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
            {
                throw new ArgumentException("The provided file path is invalid.");
            }

            using (Image<Rgba32> image = Image.Load<Rgba32>(imagePath))
            {
                if (image.Width != 1024 || image.Height != 1024)
                {
                    throw new ArgumentException("The image must be 1024x1024 pixels.");
                }

                string directory = Path.GetDirectoryName(imagePath);
                string filenameWithoutExtension = Path.GetFileNameWithoutExtension(imagePath);
                string extension = Path.GetExtension(imagePath);

                // Define the quadrants
                var quadrants = new (int X, int Y, string Name)[]
                {
                (0, 0, "TopLeft"),
                (512, 0, "TopRight"),
                (0, 512, "BottomLeft"),
                (512, 512, "BottomRight")
                };

                foreach (var (x, y, name) in quadrants)
                {
                    string newFileName = Path.Combine(directory, $"{filenameWithoutExtension}_{name}{extension}");
                    using (var quadrant = image.Clone(ctx => ctx.Crop(new Rectangle(x, y, 512, 512))))
                    {
                        quadrant.Save(newFileName, new WebpEncoder());
                    }
                }
            }
        }
    }
}

