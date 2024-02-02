Console.WriteLine("Helo, what is your name???");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("---------------------------------");
Console.WriteLine($"Welcome {name}. It's {date}, welcome to my math's game!\n");
Console.WriteLine(@$"What kind of math's game would you like to play today?? Please choose from the following choices below:
A - Addition Game
S - Subtraction Game 
M - Multipication Game
D - Division Game
Q - Quit the programe");
Console.WriteLine("---------------------------------");
