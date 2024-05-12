using GameDataParser;
using System.Text.Json;

var app = new GameDataParserApp();
var logger = new Logger("log.txt");
var videoGame= new VideoGame();


try
{
    app.Run();
}

catch (Exception ex)
{
    Console.WriteLine("Unexpected error has ocorred.");
    logger.Log(ex);
}
Console.WriteLine("Press any key to close.");
Console.ReadKey();







