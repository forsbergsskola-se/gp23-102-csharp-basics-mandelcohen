// mandel
gameStart: ;

Console.WriteLine("Welcome to NIM!");

int matches = 24;

userTurn: ;
Console.WriteLine("How many matches do you want to draw?");
int userDraw = int.Parse(Console.ReadLine());
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





goto userTurn;

