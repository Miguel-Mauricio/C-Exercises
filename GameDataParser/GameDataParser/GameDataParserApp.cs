using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameDataParser
{
    public class GameDataParserApp
    {

        public void Run()
        {
            bool isFileRead = false;
            string fileContents = default;
            var fileName = default(string);
            do
            {

                try
                {

                    Console.WriteLine("Write the file name:");

                    fileName = Console.ReadLine();

                    fileContents = File.ReadAllText(fileName);
                    isFileRead = true;
                }

                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("File name can't be null.");
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine("File name cannot be empty.");
                }

                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("There is no file with the provided name.");
                }


            }
            while (!isFileRead);
            {

                List<VideoGame> videoGames = default;
                try
                {
                    videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
                }

                catch (JsonException ex)
                {
                    var originalColour = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"JSON in {fileName} file was not " + "in a valid format. JSON body");
                    Console.ForegroundColor = originalColour;

                    throw new JsonException($"{ex.Message} The file name is {fileName}", ex);
                }
                if (videoGames.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Loaded games are:");

                    foreach (var videoGame in videoGames)
                    {
                        Console.WriteLine(videoGame);
                    }
                }




                else
                {
                    Console.WriteLine("No games in file.");
                }
            }





        }
    }
}
