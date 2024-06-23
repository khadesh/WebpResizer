using NAudio.Lame;
using NAudio.Wave;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Webp;

namespace WebpResizer
{
	public class AudioConverter
    {
        public static void ConvertWavDirectoryToMp3(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("The specified directory does not exist.");
                return;
            }

            string[] wavFiles = Directory.GetFiles(directoryPath, "*.wav");

            if (wavFiles.Length == 0)
            {
                Console.WriteLine("No WAV files found in the specified directory.");
                return;
            }

            foreach (string wavFilePath in wavFiles)
            {
                string mp3FilePath = Path.ChangeExtension(wavFilePath, ".mp3");
                ConvertWavToMp3(wavFilePath, mp3FilePath);
                Console.WriteLine($"Converted: {wavFilePath} -> {mp3FilePath}");
            }

            Console.WriteLine("Conversion complete.");
        }

        static void ConvertWavToMp3(string wavFilePath, string mp3FilePath)
        {
            using (var reader = new AudioFileReader(wavFilePath))
            using (var writer = new LameMP3FileWriter(mp3FilePath, reader.WaveFormat, LAMEPreset.VBR_90))
            {
                reader.CopyTo(writer);
            }
        }
    }
}
