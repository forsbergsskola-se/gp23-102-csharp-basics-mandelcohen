// mandel

Console.WriteLine("What is your age: ");
var age = int.Parse(Console.ReadLine());

switch (age) {
    case < 13:
        Console.WriteLine("You are a child.");
        break;
    case <= 19:
        Console.WriteLine("You are a teenager.");
        break;
    default:
        Console.WriteLine("You are an adult.");
        break;
}

Console.WriteLine("Give me another integer. ");
var number = int.Parse(Console.ReadLine());

var max = age > number ? age : number;
Console.WriteLine($"The maximum is {max}");

Console.WriteLine(max % 2 == 0 ? "Your number is even." : "Your number is odd.");
