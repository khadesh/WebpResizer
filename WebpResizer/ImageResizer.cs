using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Webp;

namespace WebpResizer
{
	/// <summary>
	/// This class was fully written using a few commands and chat GPT-4o.
	/// </summary>
	public class ImageResizer
	{
		public static void ResizeImage(string filename)
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
			using (Image image = Image.Load(filename))
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
						using (Image resizedImage = image.Clone(ctx => ctx.Resize(sizes[i], sizes[i])))
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

		public static void ProcessDirectory(string directoryPath)
		{
			// Get all .webp files in the directory
			var webpFiles = Directory.GetFiles(directoryPath, "*.webp");

			// Call ResizeImage on each .webp file
			foreach (var file in webpFiles)
			{
				Console.WriteLine($"Processing: {file}");
				ResizeImage(file);
			}
		}
		public static void ConvertToJpeg(string filename)
		{
			// Define the output JPEG filename
			string jpegFilename = Path.Combine(Path.GetDirectoryName(filename),
								  Path.GetFileNameWithoutExtension(filename) + ".jpg");

			// Read the original WebP image
			using (Image image = Image.Load(filename))
			{
				// Save the image as JPEG
				image.Save(jpegFilename, new JpegEncoder());
				Console.WriteLine($"Converted and saved: {jpegFilename}");
			}
		}

	}
}
