// See https://aka.ms/new-console-template for more information
using WebpResizer;


//ImageResizer.ProcessDirectoryPng(@"C:\Users\pigsc\OneDrive\デスクトップ\avatars\");

//ImageSplitter.SplitImageIntoQuadrants(@"C:\Users\pigsc\OneDrive\デスクトップ\img\coins.webp");

//AudioConverter.ConvertWavDirectoryToMp3(@"C:\Users\pigsc\OneDrive\デスクトップ\songs\");

//// Example usage
//string webpFilePath = @"C:\Users\pigsc\OneDrive\デスクトップ\img fix\zombiedragon5-512.webp";
//string pngFilePath = @"C:\Users\pigsc\OneDrive\デスクトップ\img fix\zombiedragon5-512.png";
//ImageConverter.ConvertWebPToPng(webpFilePath, pngFilePath);
//ImageConverter.ConvertPngToWebP(pngFilePath, webpFilePath);

//ImageConverter.ProcessDirectoryToPng(@"C:\Users\pigsc\OneDrive\デスクトップ\cards\", @"C:\Users\pigsc\OneDrive\デスクトップ\cards\png\");

//ImageConverter.ProcessDirectoryToPng(@"C:\Users\pigsc\OneDrive\デスクトップ\media\bossbattlechess\", @"C:\Users\pigsc\OneDrive\デスクトップ\media\bossbattlechess\pngs\");

ImageResizer.ResizeImages66Percent(@"C:\Users\pigsc\OneDrive\デスクトップ\media\bossbattlechess\cards\", @"C:\Users\pigsc\OneDrive\デスクトップ\media\bossbattlechess\cards\compressed\");

//int i = 0;
//List<string> CardRules = new List<string>() {
//    "If a player writes their move down for the next 6 turns, they gain pawn warp!",
//    "Both players write down their opponent's next 4 moves. If they guess correctly they gain pawn warp!",
//    "If a player hits their clock for the next 6 turns, they gain pawn warp!",
//    "If a player says their blunder check out loud for the next 6 moves they gain pawn warp!",
//    "If a player uses their full delay on the clock for the next 6 moves they gain pawn warp!",
//    "For the next 6 turns if a player touches a piece they don't immediately move, their opponent gains pawn warp!",
//    "After this card is played, if any player checks the enemy king 5 times in a row they gain pawn warp!",

//    "Both players write down their opponent's next 6 moves. If they guess correctly they gain double pawn warp!",
//    "Both players write down their opponent's next 5 moves. If they guess correctly they gain pawn warp!",
//    "Both players write down their opponent's next 3 moves. If they guess correctly they gain pawn warp!",
//    "Both players write down their opponent's next 2 moves. If they guess correctly they gain pawn warp!",
//    "Both players write down their opponent's next 7 moves. If they guess correctly they gain triple pawn warp!",
//};
//List<int> CardRulesHp = new List<int>() {
//    10,
//    9,
//    8,
//    12,
//    6,
//    11,
//    4,
//    13,
//    11,
//    9,
//    7,
//    15,
//};

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\ancientdragon5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Ancient Dragon",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves... It creeps in the night, passing through the waves... It creeps in the night.\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

////"\"It creeps in the night, passing through the waves...\"",
//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\zombiedragon5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Zombie Dragon",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\leviathan5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Leviathan",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\snowman5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Snowman",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\trex5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "T-Rex",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\hydra5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Hydra",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\chinesedragon5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Chinese Dragon",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\pegasus5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Pegasus",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\nightmare5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Nightmare",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\golddragon5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Gold Dragon",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\phoenix5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Phoenix",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\reddragon5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Red Dragon",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\angel5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame3.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Angel",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\cerberus5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame3.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Cerberus",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\cockatrice5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame3.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Cockatrice",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\gryphon5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame3.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Gryphon",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\imp5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame3.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Imp",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\kraken5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame3.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Kraken",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\medusa5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame3.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Medusa",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\minotaur5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame3.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Minotaur",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\nuggetman5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame3.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Nugget Man",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\vampire5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame3.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Vampire",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\wraithking5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame3.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Wraith King",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\fangtooth5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame3.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Fang Tooth",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\blackwidow5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame2.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Black Widow",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\djinn5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame2.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Djinn",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\fairy5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame2.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Fairy",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\knight5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame2.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Knight",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\pixie5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame2.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Pixie",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\ranger5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame2.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Ranger",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\raptor5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame2.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Raptor",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\unicorn5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame2.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Unicorn",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\werewolf5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame2.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Werewolf",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\witch5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame2.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Witch",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\wizard5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame2.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Wizard",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\zombie5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame2.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Zombie",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\orc5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame1.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Orc",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\panda5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame1.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Panda",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\tiger5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame1.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Tiger",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\mermaid5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame1.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Mermaid",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\monkey5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame1.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Monkey",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\moose5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame1.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Moose",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\gorilla5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame1.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Gorilla",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\grizzly5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame1.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Grizzly",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\lion5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame1.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Lion",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\barbarian5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame1.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Barbarian",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\duck5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame1.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Duck",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\eagle5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame1.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Eagle",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\frostlord5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Frost Lord",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//ImageCardBuilder.MergeImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\0image\alienspider5.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardfront-frame4.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\1carded\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    "Arachnodroid",
//    CardRules[i],
//    "\"It creeps in the night, passing through the waves...\"",
//    "https://www.chesstrainer.club/tcg",
//    CardRulesHp[i].ToString()
//);
//i++;
//if (i > 11)
//    i = 0;

//// Example call for adding padding to images
//ImageCardBuilder.AddPaddingToImages(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\2nameandhp\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\3bleed\"
//);


//ImageCardBuilder.CreatePdfsForEachImagePair(
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\3bleed\",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\cardback1bleed.png",
//    @"C:\Users\pigsc\OneDrive\デスクトップ\winners\4pdf\result.pdf"
//);

