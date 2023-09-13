// mandel

Console.WriteLine("Welcome to NIM!");
Console.WriteLine("|||||||||||||||||||||||| (24)");

int matches = 24;

// add for loop for matches count |||
// add if matches = 0 you lose under user and AI.


userTurn: ;
Console.WriteLine("How many matches do you want to draw?");
int userDraw = int.Parse(Console.ReadLine());
matches -= userDraw;

if (matches == 0) {
    Console.WriteLine("You lose!");
}

Random random = new Random();
int aiTurn = random.Next(1, 4);

Console.WriteLine($"The AI draws {aiTurn}");
matches -= aiTurn;

if (matches == 0) {
    Console.WriteLine("You won!");
}

else {
    Console.WriteLine("Draw matches here later: " + matches);
}

goto userTurn;

