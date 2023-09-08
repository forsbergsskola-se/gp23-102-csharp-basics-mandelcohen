// mandel

gameStart: ;
var myNumber = Random.Shared.Next(0, maxValue:100);
Console.WriteLine("I have picked a number (0-100) It's your turn to guess it!");

userTurn: ;
var userNumber = int.Parse(Console.ReadLine());  

if (myNumber > userNumber) {
    Console.WriteLine("Nope! My number is greater.");
    goto userTurn;
}
else if (myNumber < userNumber) {
    Console.WriteLine("Nope! My number is smaller.");
    goto userTurn;
}
else {
    Console.WriteLine(@"That's the number! Well played.

Go again!
");
    goto gameStart;
}
