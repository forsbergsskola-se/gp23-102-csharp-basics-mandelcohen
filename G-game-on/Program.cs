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

    if (matches >= userDraw) {
        matches -= userDraw;
    }
    else
    {
        Console.WriteLine("You can't draw more matches than there's left!");
        goto drawPhase;
    }
}
if (!playerTurn) {
    Random random = new Random();
    int aiDraw = random.Next(1, 4);
    
    if (matches >= aiDraw) {
        matches -= aiDraw;
    }
    else {
        goto drawPhase;
    }
    Console.WriteLine($"The AI draws {aiDraw}");
    
    int matchPrint = matches;
    printMatches: ;
    Console.Write('|');
    if (matchPrint > 1) { 
        matchPrint--; 
        goto printMatches;
    }
    Console.WriteLine($"({matches})");
}

gameOver: ; 
if (matches < 1 && playerTurn) {
    Console.WriteLine("You lose!");
    goto gameStart;
}
if (matches < 1 && !playerTurn){
    Console.WriteLine("You win!");
    goto gameStart;
}

playerTurn = !playerTurn;
goto drawPhase ;

