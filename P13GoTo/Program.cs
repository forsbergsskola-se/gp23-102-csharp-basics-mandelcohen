// mandel

gameStart: ;
int myNumber = Random.Shared.Next(0, maxValue:100);
Console.WriteLine("I have picked a number (0-100) It's your turn to guess it!");

int counter = 10; 

userTurn: ;
int userNumber = int.Parse(Console.ReadLine());

if (myNumber > userNumber && (counter > 0)) {
    Console.WriteLine($"""
                       Nope! My number is greater.
                       You have {--counter} tries left, guess again!
                       """);
    goto userTurn;
}
if (myNumber < userNumber && (counter > 0)) {
    Console.WriteLine($"""
                       Nope! My number is smaller.
                       You have {--counter} tries left, guess again!
                       """);
    goto userTurn;
}
if (myNumber == userNumber) {
    Console.WriteLine("""
                      That's the number! Well played.
                                                                                          
                      Go again!

                      """);                                                                 
    goto gameStart;                                                 
}
if (myNumber != userNumber || (counter == 0)) {
       Console.WriteLine("""
                         You are out of tries :(

                         Go again!

                         """);
       goto gameStart;
}    







