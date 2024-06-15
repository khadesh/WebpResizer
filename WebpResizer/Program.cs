// See https://aka.ms/new-console-template for more information
using WebpResizer;
//ImageResizer.ProcessDirectory(@"C:\Users\pigsc\OneDrive\デスクトップ\eggs\");
//ImageSplitter.SplitImageIntoQuadrants(@"C:\Users\pigsc\OneDrive\デスクトップ\img\coins.webp");

// Example usage
string webpFilePath = @"C:\Users\pigsc\OneDrive\デスクトップ\img fix\ancient-dragon.webp";
string pngFilePath = @"C:\Users\pigsc\OneDrive\デスクトップ\img fix\ancient-dragon.png";
//ImageConverter.ConvertWebPToPng(webpFilePath, pngFilePath);
ImageConverter.ConvertPngToWebP(pngFilePath, webpFilePath);