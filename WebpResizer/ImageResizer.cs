using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Webp;
using System.Drawing;

namespace WebpResizer
{
	/// <summary>
	/// This class was fully written using a few commands and chat GPT-4o.
	/// </summary>
	public class ImageResizer
    {
        public static void ResizeImages66Percent(string inputDir, string outputDir)
        {
            // Ensure the output directory exists
            Directory.CreateDirectory(outputDir);

            // Get all image files from the input directory
            string[] imageFiles = Directory.GetFiles(inputDir, "*.*", SearchOption.AllDirectories);

            foreach (var filePath in imageFiles)
            {
                try
                {
                    using (System.Drawing.Image originalImage = System.Drawing.Image.FromFile(filePath))
                    {
                        // Calculate the new dimensions
                        int newWidth = (int)(originalImage.Width * 0.34);
                        int newHeight = (int)(originalImage.Height * 0.34);

                        // Create a new bitmap with the new dimensions
                        using (Bitmap resizedImage = new Bitmap(originalImage, new System.Drawing.Size(newWidth, newHeight)))
                        {
                            // Create the output file path
                            string outputFilePath = Path.Combine(outputDir, Path.GetFileName(filePath));

                            // Save the resized image to the output directory
                            resizedImage.Save(outputFilePath);
                        }
                    }

                    Console.WriteLine($"Resized and saved: {Path.GetFileName(filePath)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing {filePath}: {ex.Message}");
                }
            }
        }

        public static void ResizeImagePng(string filename)
        {
            // Define the new subfolder name
            string subfolder = "resized";
            string directory = Path.GetDirectoryName(filename);
            string resizedDirectory = Path.Combine(directory, subfolder);

            // Create the subfolder if it doesn't exist
            if (!Directory.Exists(resizedDirectory))
            {
                Directory.CreateDirectory(resizedDirectory);
            }

            // Read the original image
            using (SixLabors.ImageSharp.Image image = SixLabors.ImageSharp.Image.Load(filename))
            {
                // Define the sizes and suffixes
                var sizes = new int[] { 1024, 512, 256, 128, 64, 32 };
                var suffixes = new string[] { "-1024.png", "-512.png", "-256.png", "-128.png", "-64.png", "-32.png" };

                // Process and save each resized image
                for (int i = 0; i < sizes.Length; i++)
                {
                    string newFilename = Path.Combine(resizedDirectory,
                                        Path.GetFileNameWithoutExtension(filename) + suffixes[i]);

                    // Check if the file already exists
                    if (!File.Exists(newFilename))
                    {
                        using (SixLabors.ImageSharp.Image resizedImage = image.Clone(ctx => ctx.Resize(sizes[i], sizes[i])))
                        {
                            resizedImage.Save(newFilename, new PngEncoder());
                            Console.WriteLine($"Saved: {newFilename}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"File already exists: {newFilename}, skipping resize.");
                    }
                }
            }
        }

        public static void ProcessDirectoryPng(string directoryPath)
        {
            // Get all .webp files in the directory
            var webpFiles = Directory.GetFiles(directoryPath, "*.png");

            // Call ResizeImage on each .webp file
            foreach (var file in webpFiles)
            {
                Console.WriteLine($"Processing: {file}");
                ResizeImagePng(file);
            }
        }

        public static void ResizeImageWebp(string filename)
		{
			// Define the new subfolder name
			string subfolder = "resized";
			string directory = Path.GetDirectoryName(filename);
			string resizedDirectory = Path.Combine(directory, subfolder);

			// Create the subfolder if it doesn't exist
			if (!Directory.Exists(resizedDirectory))
			{
				Directory.CreateDirectory(resizedDirectory);
			}

			// Read the original image
			using (SixLabors.ImageSharp.Image image = SixLabors.ImageSharp.Image.Load(filename))
			{
				// Define the sizes and suffixes
				var sizes = new int[] { 1024, 512, 256, 128, 64, 32 };
				var suffixes = new string[] { "-1024.webp", "-512.webp", "-256.webp", "-128.webp", "-64.webp", "-32.webp" };

				// Process and save each resized image
				for (int i = 0; i < sizes.Length; i++)
				{
					string newFilename = Path.Combine(resizedDirectory,
										Path.GetFileNameWithoutExtension(filename) + suffixes[i]);

					// Check if the file already exists
					if (!File.Exists(newFilename))
					{
						using (SixLabors.ImageSharp.Image resizedImage = image.Clone(ctx => ctx.Resize(sizes[i], sizes[i])))
						{
							resizedImage.Save(newFilename, new WebpEncoder());
							Console.WriteLine($"Saved: {newFilename}");
						}
					}
					else
					{
						Console.WriteLine($"File already exists: {newFilename}, skipping resize.");
					}
				}
			}
		}

		public static void ProcessDirectoryWebp(string directoryPath)
		{
			// Get all .webp files in the directory
			var webpFiles = Directory.GetFiles(directoryPath, "*.webp");

			// Call ResizeImage on each .webp file
			foreach (var file in webpFiles)
			{
				Console.WriteLine($"Processing: {file}");
                ResizeImageWebp(file);
			}
		}
		public static void ConvertToJpeg(string filename)
		{
			// Define the output JPEG filename
			string jpegFilename = Path.Combine(Path.GetDirectoryName(filename),
								  Path.GetFileNameWithoutExtension(filename) + ".jpg");

			// Read the original WebP image
			using (SixLabors.ImageSharp.Image image = SixLabors.ImageSharp.Image.Load(filename))
			{
				// Save the image as JPEG
				image.Save(jpegFilename, new JpegEncoder());
				Console.WriteLine($"Converted and saved: {jpegFilename}");
			}
		}

	}
}
