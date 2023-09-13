// mandel

Console.WriteLine("Welcome to NIM!");
Console.WriteLine("|||||||||||||||||||||||| (24)");

gameStart: ;
int matches = 24;

userTurn: ;
Console.WriteLine("How many matches do you want to draw?");
int userDraw = int.Parse(Console.ReadLine());

if (userDraw > 3) {
    Console.Write("You can only draw 1,2 or 3 matches at time! ");
    goto userTurn;
} 
matches -= userDraw;

if (matches <= 0) {
    Console.WriteLine("You lose!");
    goto gameStart;
}

Random random = new Random();
int aiTurn = random.Next(1, 4);

Console.WriteLine($"The AI draws {aiTurn}");
matches -= aiTurn;

if (matches <= 0) {
    Console.WriteLine("You won!");
    goto gameStart;
}

int matchPrint = matches;
printMatches: ;
Console.Write('|');
if (matchPrint > 1)
{
    matchPrint--;
    goto printMatches;
}
Console.WriteLine($"({matches})");

goto userTurn;

