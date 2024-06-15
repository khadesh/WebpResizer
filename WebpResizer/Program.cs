// See https://aka.ms/new-console-template for more information
using WebpResizer;
//ImageResizer.ProcessDirectory(@"C:\Users\pigsc\OneDrive\デスクトップ\avatars\");
//ImageSplitter.SplitImageIntoQuadrants(@"C:\Users\pigsc\OneDrive\デスクトップ\img\coins.webp");

// Example usage
//string webpFilePath = @"C:\Users\pigsc\OneDrive\デスクトップ\img fix\zombiedragon5-512.webp";
//string pngFilePath = @"C:\Users\pigsc\OneDrive\デスクトップ\img fix\zombiedragon5-512.png";
//ImageConverter.ConvertWebPToPng(webpFilePath, pngFilePath);
//ImageConverter.ConvertPngToWebP(pngFilePath, webpFilePath);


ImageConverter.ProcessDirectoryToPng(@"C:\Users\pigsc\OneDrive\デスクトップ\cards\", @"C:\Users\pigsc\OneDrive\デスクトップ\cards\png\");