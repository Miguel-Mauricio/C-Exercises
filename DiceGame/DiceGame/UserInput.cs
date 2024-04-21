namespace DiceGame;

public static class UserInput
{
    public static int ReadNumber()
    {
        int input;

        while (!int.TryParse(Console.ReadLine(), out input)) ;
        return input ;
    }
}
