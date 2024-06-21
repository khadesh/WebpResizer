using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;

namespace WebpResizer
{
    public class ImageCardBuilder
    {
        public static Dictionary<string, string> creaturePoems = new Dictionary<string, string>
        {
            { "ancientdragon", "Ancient dragon, fierce and wise, with fire that lights up the skies." },
            { "angel", "Angel with wings so bright, brings peace and love, a guiding light." },
            { "barbarian", "Barbarian strong and wild, battles fierce with a savage smile." },
            { "blackwidow", "Black widow spins her deadly web, a silent dance of life and death." },
            { "cerberus", "Cerberus, guardian of gates, three heads snarl at fate's cruel stakes." },
            { "chinesedragon", "Chinese dragon, ancient and grand, protector of the sacred land." },
            { "cockatrice", "Cockatrice with a deadly gaze, turns all to stone in a fiery blaze." },
            { "djinn", "Djinn of the lamp, wish granter sly, be careful what desires you cry." },
            { "duck", "Duck on a pond, so calm and free, quacks of joy for all to see." },
            { "eagle", "Eagle soars with majesty, eyes sharp, wings spread with ecstasy." },
            { "fairy", "Fairy dances in the moonlight, sprinkling magic, a wondrous sight." },
            { "fangtooth", "Fangtooth lurks in ocean deep, jaws of terror in the shadows creep." },
            { "golddragon", "Gold dragon, gleaming bright, protector of treasures, mighty in flight." },
            { "gorilla", "Gorilla strong in the jungle's heart, a gentle giant, a work of art." },
            { "grizzly", "Grizzly bear with mighty roar, king of the forest evermore." },
            { "gryphon", "Gryphon bold with wings and claws, guardian of ancient laws." },
            { "hydra", "Hydra's heads grow back with ease, a monstrous beast, to appease." },
            { "imp", "Imp so tricky, full of glee, mischief maker, wild and free." },
            { "knight", "Knight in armor, shining bright, defender of the noble fight." },
            { "kraken", "Kraken rises from the deep, tentacles of doom, no one to keep." },
            { "leviathan", "Leviathan, sea beast grand, ruler of the ocean's expanse." },
            { "lion", "Lion with a regal mane, king of beasts on the savannah plain." },
            { "medusa", "Medusa's gaze turns flesh to stone, her beauty hides a curse unknown." },
            { "mermaid", "Mermaid swims in ocean blue, with a song that lures the crew." },
            { "minotaur", "Minotaur in labyrinth's maze, fierce guardian of hidden ways." },
            { "monkey", "Monkey swings from tree to tree, playful, wild, and full of glee." },
            { "moose", "Moose stands tall in forest shade, gentle giant, unafraid." },
            { "nightmare", "Nightmare steed with eyes of flame, haunts your dreams, all the same." },
            { "nuggetman", "Nuggetman with golden crust, a tasty hero we can trust." },
            { "orc", "Orc with tusks and battle cry, fights with honor, do or die." },
            { "panda", "Panda munches bamboo leaves, peaceful days, gentle eves." },
            { "pegasus", "Pegasus with wings of white, soars through the skies, pure delight." },
            { "phoenix", "Phoenix rises from the ash, reborn anew in a fiery flash." },
            { "pixie", "Pixie flits with mischief's charm, casting spells without alarm." },
            { "ranger", "Ranger roams the wild terrain, protector of nature's domain." },
            { "raptor", "Raptor swift with talons keen, hunter of the forest green." },
            { "reddragon", "Red dragon, fierce and bold, breathes hot fire, a sight to behold." },
            { "snowman", "Snowman built with love and cheer, melts away as spring draws near." },
            { "tiger", "Tiger stalks through jungle night, stripes of power, eyes so bright." },
            { "trex", "T-Rex roars in ancient lands, ruler of the dinosaur bands." },
            { "unicorn", "Unicorn with a horn so bright, symbol of pure, magical light." },
            { "vampire", "Vampire lurks in shadows deep, fangs of terror, prey in sleep." },
            { "werewolf", "Werewolf howls at the moon, transformation, a cursed boon." },
            { "witch", "Witch with spells and cackling laugh, brews her potions, none to pass." },
            { "wizard", "Wizard wise with staff in hand, casts great spells across the land." },
            { "wraithking", "Wraith king haunts with spectral might, ruler of the endless night." },
            { "zombie", "Zombie shambles with a groan, seeking flesh, a mindless drone." },
            { "zombiedragon", "Zombie dragon, death's dark wing, terror from the graveyard spring." },
            { "frostlord", "Frostlord rules with icy might, winter's wrath in endless night." },
            { "arachnodroid", "Alien spider from the stars, spins its web on circadian bars." }
        };

        public static Dictionary<string, string> creatureFantasyNames = new Dictionary<string, string>
        {
            { "ancientdragon", "Tharador" },
            { "angel", "Seraphiel" },
            { "barbarian", "Grimnar Bloodfury" },
            { "blackwidow", "Veloranyx" },
            { "cerberus", "Kerberathian" },
            { "chinesedragon", "Longwei" },
            { "cockatrice", "Gorgonax" },
            { "djinn", "Zafarus" },
            { "duck", "Quackthor" },
            { "eagle", "Aquilarius" },
            { "fairy", "Luminarithria" },
            { "fangtooth", "Fangriminius" },
            { "golddragon", "Aureldor" },
            { "gorilla", "Banthark" },
            { "grizzly", "Grizzclaw" },
            { "gryphon", "Ursamorphus" },
            { "hydra", "Hydrophus" },
            { "imp", "Scampwick" },
            { "knight", "Sir Gallius" },
            { "kraken", "Thalassor" },
            { "leviathan", "Oceonax" },
            { "lion", "Regalus" },
            { "medusa", "Gorgonessa" },
            { "mermaid", "Serenaria" },
            { "minotaur", "Labyrinthos" },
            { "monkey", "Chimlar" },
            { "moose", "Antloran" },
            { "nightmare", "Nychtos" },
            { "nuggetman", "Gildor" },
            { "orc", "Thrakgar" },
            { "panda", "Bamboozen" },
            { "pegasus", "Aetherion" },
            { "phoenix", "Emberis" },
            { "pixie", "Trixie" },
            { "ranger", "Aldrin" },
            { "raptor", "Velocitron" },
            { "reddragon", "Ignathar" },
            { "snowman", "Banetar" },
            { "tiger", "Tigranis" },
            { "trex", "Rexorn" },
            { "unicorn", "Celestia" },
            { "vampire", "Drakthul" },
            { "werewolf", "Lycandos" },
            { "witch", "Hexana" },
            { "wizard", "Merlinius" },
            { "wraithking", "Phantomus" },
            { "zombie", "Rotgorn" },
            { "zombiedragon", "Necronomicus" },
            { "arachnodroid", "Octavianoid" },
            { "frostlord", "Xanthornima" }
        };
        
        public static Dictionary<string, int> creatureValues = new Dictionary<string, int>
        {
            { "barbarian", 0 },
            { "duck", 0 },
            { "eagle", 0 },
            { "gorilla", 0 },
            { "grizzly", 0 },
            { "lion", 0 },
            { "mermaid", 0 },
            { "monkey", 0 },
            { "moose", 0 },
            { "orc", 0 },
            { "panda", 0 },
            { "tiger", 0 },
            { "werewolf", 1 },
            { "witch", 1 },
            { "wizard", 1 },
            { "unicorn", 1 },
            { "zombie", 1 },
            { "pixie", 1 },
            { "ranger", 1 },
            { "raptor", 1 },
            { "knight", 1 },
            { "fairy", 1 },
            { "blackwidow", 1 },
            { "djinn", 1 },
            { "cockatrice", 2 },
            { "angel", 2 },
            { "cerberus", 2 },
            { "fangtooth", 2 },
            { "gryphon", 2 },
            { "kraken", 2 },
            { "medusa", 2 },
            { "minotaur", 2 },
            { "vampire", 2 },
            { "wraithking", 2 },
            { "imp", 2 },
            { "nuggetman", 2 },
            { "trex", 3 },
            { "zombiedragon", 3 },
            { "nightmare", 3 },
            { "leviathan", 3 },
            { "reddragon", 3 },
            { "snowman", 3 },
            { "pegasus", 3 },
            { "phoenix", 3 },
            { "hydra", 3 },
            { "golddragon", 3 },
            { "chinesedragon", 3 },
            { "ancientdragon", 3 },
            { "arachnodroid", 4 },
            { "frostlord", 4 }
        };

        public static void MergeImages(string imagePath1, string imagePath2, string outputDirectory, string finalOutputDirectory, string name, string cardText, string poem, string url, string hp)
        {
            string nameKey = name.Replace(" ", "").Replace("-", "").ToLower();
            poem = "\"" + creaturePoems[nameKey] + "\"";

            int hpAsaInt = (Int32.Parse(hp) + creatureValues[nameKey]);
            if (hpAsaInt == 11)
            {
                hpAsaInt++;
            }
            hp = (hpAsaInt).ToString();

            name = creatureFantasyNames[nameKey] + " - the " + name;

            // Get the filename of the first image
            string fileName = Path.GetFileName(imagePath1);

            // Create the output path by combining the output directory with the filename
            string outputPath = Path.Combine(outputDirectory, fileName);
            string finalOutputPath = Path.Combine(finalOutputDirectory, fileName);

            // Load the images
            using (Bitmap image1 = new Bitmap(imagePath1))
            using (Bitmap image2 = new Bitmap(imagePath2))
            {
                // Resize the first image to 965x965
                Bitmap resizedImage1 = new Bitmap(image1, new System.Drawing.Size(965, 965));

                // Create a new bitmap with the dimensions of the second image
                Bitmap resultImage = new Bitmap(image2.Width, image2.Height);

                using (Graphics graphics = Graphics.FromImage(resultImage))
                {
                    // Draw the resized first image onto the result image at coordinates (14, 144)
                    graphics.DrawImage(resizedImage1, 14, 144, resizedImage1.Width, resizedImage1.Height);

                    // Draw the second image onto the result image
                    graphics.DrawImage(image2, 0, 0, image2.Width, image2.Height);

                    // Save the card with no text:
                    resultImage.Save(outputPath, System.Drawing.Imaging.ImageFormat.Png);

                    // Add the texts
                    //QILAVOEN Trial Regular
                    AddTextToImage(graphics, name, new Font("Alice in Wonderland", 40), Brushes.Black, new System.Drawing.PointF(187, 70));
                    AddTextToImage(graphics, cardText, new Font("Times New Roman", 28), Brushes.Black, new System.Drawing.RectangleF(73, 1079, 901, 170));
                    AddTextToImage(graphics, poem, new Font("Alice in Wonderland", 24), Brushes.Black, new System.Drawing.RectangleF(73, 1190, 901, 110));
                    AddTextToImage(graphics, url, new Font("Times New Roman", 30), Brushes.Black, new System.Drawing.PointF(108, 1305));
                    if (hp.Length >= 2)
                    {
                        AddTextToImage(graphics, hp, new Font("Alice in Wonderland", 55), Brushes.Black, new System.Drawing.PointF(862, 1297));
                    }
                    else
                    {
                        AddTextToImage(graphics, hp, new Font("Alice in Wonderland", 55), Brushes.Black, new System.Drawing.PointF(882, 1297));
                    }
                }

                // Save the resulting image
                resultImage.Save(finalOutputPath, System.Drawing.Imaging.ImageFormat.Png);

                Console.WriteLine("The images have been merged and saved to " + outputPath);
                Console.WriteLine("The images with texts have been saved to " + finalOutputPath);
            }
        }

        private static void AddTextToImage(Graphics graphics, string text, Font font, Brush brush, System.Drawing.PointF point)
        {
            graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            graphics.DrawString(text, font, brush, point);
        }

        private static void AddTextToImage(Graphics graphics, string text, Font font, Brush brush, System.Drawing.RectangleF layoutRectangle)
        {
            graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near,
                Trimming = StringTrimming.Word
            };
            graphics.DrawString(text, font, brush, layoutRectangle, format);
        }

        public static void AddPaddingToImages(string inputDirectory, string outputDirectory)
        {
            // Ensure output directory exists
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            // Get all PNG files in the input directory
            string[] files = Directory.GetFiles(inputDirectory, "*.png");

            foreach (var file in files)
            {
                using (Bitmap originalImage = new Bitmap(file))
                {
                    // Determine the color of the pixel at (0, 0)
                    System.Drawing.Color paddingColor = originalImage.GetPixel(0, 0);

                    // Create a new bitmap with padding
                    int padding = 35;
                    Bitmap paddedImage = new Bitmap(originalImage.Width + 2 * padding, originalImage.Height + 2 * padding);

                    using (Graphics graphics = Graphics.FromImage(paddedImage))
                    {
                        // Fill the entire padded image with the padding color
                        graphics.Clear(paddingColor);

                        // Draw the original image onto the padded image
                        graphics.DrawImage(originalImage, padding, padding, originalImage.Width, originalImage.Height);
                    }

                    // Save the padded image to the output directory
                    string outputFileName = Path.Combine(outputDirectory, Path.GetFileName(file));
                    paddedImage.Save(outputFileName, ImageFormat.Png);

                    Console.WriteLine("Added padding to " + file + " and saved to " + outputFileName);
                }
            }
        }

        public static void CreatePdfsForEachImagePair(string inputDirectory, string additionalImagePath, string outputDirectory)
        {
            // Ensure the output directory exists
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            // Load the additional image
            XImage additionalImage = XImage.FromFile(additionalImagePath);

            // Get all PNG files in the input directory
            string[] files = Directory.GetFiles(inputDirectory, "*.png");

            foreach (var file in files)
            {
                // Create a new PDF document
                PdfDocument pdfDocument = new PdfDocument();

                // Add the first page with the current image
                PdfPage pdfPage1 = pdfDocument.AddPage();
                using (XGraphics gfx = XGraphics.FromPdfPage(pdfPage1))
                {
                    // Load the current image
                    XImage currentImage = XImage.FromFile(file);

                    // Set page size to fit the current image
                    pdfPage1.Width = currentImage.PixelWidth;
                    pdfPage1.Height = currentImage.PixelHeight;

                    // Draw the current image on the PDF page
                    gfx.DrawImage(currentImage, 0, 0, currentImage.PixelWidth, currentImage.PixelHeight);
                }

                // Add the second page with the additional image
                PdfPage pdfPage2 = pdfDocument.AddPage();
                using (XGraphics gfx = XGraphics.FromPdfPage(pdfPage2))
                {
                    // Set page size to fit the additional image
                    pdfPage2.Width = additionalImage.PixelWidth;
                    pdfPage2.Height = additionalImage.PixelHeight;

                    // Draw the additional image on the PDF page
                    gfx.DrawImage(additionalImage, 0, 0, additionalImage.PixelWidth, additionalImage.PixelHeight);
                }

                // Save the PDF document
                string outputFileName = Path.Combine(outputDirectory, Path.GetFileNameWithoutExtension(file) + ".pdf");
                pdfDocument.Save(outputFileName);

                Console.WriteLine("PDF created for " + file + " at " + outputFileName);
            }
        }
    }
}
