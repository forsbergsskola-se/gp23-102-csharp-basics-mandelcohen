// mandel

Console.WriteLine("Welcome to NIM!");
Console.WriteLine("|||||||||||||||||||||||| (24)");
Console.WriteLine("How many matches do you want to draw?");

int matches = 24;

userTurn: ;
if (matches )
int userDraw = int.Parse(Console.ReadLine());
matches -= userDraw;

Console.WriteLine("Draw matches here later: " + matches);

Random random = new Random();
int aiTurn = random.Next(1, 4);

Console.Write($"The AI draws {aiTurn}");
matches -= aiTurn;

