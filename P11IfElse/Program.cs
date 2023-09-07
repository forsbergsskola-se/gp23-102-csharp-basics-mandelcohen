// mandel

Console.WriteLine("What is your age: ");
var age = int.Parse(Console.ReadLine());

if (age < 13) {
    Console.WriteLine("You are a child.");
}
else if (age is >= 13 and <= 19) {
    Console.WriteLine("You are a teenager.");
}
else {
    Console.WriteLine("You are an adult.");
}

Console.WriteLine("Type another integer: ");
var number = int.Parse(Console.ReadLine());

var max = age > number ? age : number;
Console.WriteLine($"The maximum is: {max}");

if (max%2 == 0) {
    Console.WriteLine("Your number is even.");
}
else {
    Console.WriteLine("Your number is odd.");
}
