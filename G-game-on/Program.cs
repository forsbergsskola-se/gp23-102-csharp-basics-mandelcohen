// mandel

Console.WriteLine("Welcome to NIM!");

gameStart: ;
Console.WriteLine("|||||||||||||||||||||||| (24)");  
int matches = 24;
bool playerTurn = true;

drawPhase: ;

if (playerTurn){
    Console.WriteLine("How many matches do you want to draw?");
    int userDraw = int.Parse(Console.ReadLine());
    
    if (userDraw is > 3 or < 1) {
        Console.Write("You can only draw 1,2 or 3 matches at time! ");
        goto drawPhase;
    }
    if (matches < userDraw) {
        Console.WriteLine("You can't draw more matches than there's left!");
        goto drawPhase;
    }
    matches -= userDraw;
}

if (!playerTurn)
{
    int maxDraw = matches > 4 ? 4 : matches;
    int aiDraw = Random.Shared.Next(1, maxDraw);
    matches -= aiDraw;
    Console.WriteLine($"The AI draws {aiDraw}");

    if (matches > 0) {
        int matchPrint = matches;
        printMatches: ;
        Console.Write('|');
        if (matchPrint > 1)
        {
            matchPrint--;
            goto printMatches;
        }

        Console.WriteLine($"({matches})");
    }
}

if (matches < 1 && playerTurn) {
    Console.WriteLine(@"You lose!
");
    goto gameStart;
}
if (matches < 1 && !playerTurn){
    Console.WriteLine(@"You win!
");
    goto gameStart;
}

playerTurn = !playerTurn;
goto drawPhase ;

