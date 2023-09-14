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
    matches -= userDraw;
}
if (!playerTurn) {
    Random random = new Random();
    int aiTurn = random.Next(1, 4);
    
    matches -= aiTurn;
    Console.WriteLine($"The AI draws {aiTurn}");
    
    int matchPrint = matches;
    printMatches: ;
    Console.Write('|');
    if (matchPrint > 1) { 
        matchPrint--; 
        goto printMatches;
    }
    Console.WriteLine($"({matches})");
}

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

