// mandel

Console.WriteLine("Welcome to NIM!");

// playerTurn, toggle player and ai until one win or lose


gameStart: ;
Console.WriteLine("|||||||||||||||||||||||| (24)");  
int matches = 24;

playerTurn: ;
Console.WriteLine("How many matches do you want to draw?");
int userDraw = int.Parse(Console.ReadLine());

if (userDraw is > 0 and > 3) {
    Console.Write("You can only draw 1,2 or 3 matches at time! ");
    goto playerTurn;
} 
matches -= userDraw;

if (matches <= 0) {
    Console.WriteLine("You lose!");
    goto playerTurn;
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

goto playerTurn ;

