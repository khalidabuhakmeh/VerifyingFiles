using System;
using System.IO;

namespace VerifyingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var assets = new[]
            {
                "grapes.jpg",
                "music.mp3",
                "pin.png",
                "jetbrains.svg"
            };

            Console.WriteLine("\nFile Verification Results\n");
            // Identify the file by bytes
            foreach (var asset in assets)
            {
                var path = Path.Combine("./assets", asset);
                var result = FileTypeVerifier.What(path);
                Console.WriteLine($"{asset} is a {result.Name} ({result.Description}).");
            }
        }
    }
}