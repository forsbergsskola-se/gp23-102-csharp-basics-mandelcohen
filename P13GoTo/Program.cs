// mandel

using System.ComponentModel.Design;

var random = new Random();

Console.WriteLine("I have picked a number (0-100) It's your turn to guess it!");
var UserNumber = int.Parse(Console.ReadLine());

userTurn:
if (random > UserNumber) {
    Console.WriteLine("Nope! My number is greater.");
    goto userTurn;
}
else if (random < UserNumber) {
    Console.WriteLine("Nope! My number is smaller.");
    goto userTurn;
}

else (random = UserNumber){
    Console.WriteLine("That's the number! Well played.");
}
