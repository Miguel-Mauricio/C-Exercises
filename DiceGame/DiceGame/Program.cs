using DiceGame;

var random = new Random();

var dice = new Dice(random);
var guessingGame = new Game(dice);


guessingGame.play();

Console.ReadKey();

