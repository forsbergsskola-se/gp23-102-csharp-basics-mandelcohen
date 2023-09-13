// mandel

gameStart: ;
int myNumber = Random.Shared.Next(0, 101);
Console.WriteLine("I have picked a number (0-100) It's your turn to guess it!");

int counter = 10; 

userTurn: ;
int userNumber = int.Parse(Console.ReadLine());

if (myNumber == userNumber)
{
    Console.WriteLine(@"That's the number! Well played.
Go again!
");
    goto gameStart;
}
if (myNumber != userNumber && (counter <= 1)) {
    Console.WriteLine(@"You are out of tries :(
Go again!
");
    goto gameStart;
}    

string guess = myNumber > userNumber && (counter > 1) ? "greater" : "smaller";
Console.WriteLine($@"Nope! My number is {guess}.
You have {--counter} tries left, guess again!");
goto userTurn;









