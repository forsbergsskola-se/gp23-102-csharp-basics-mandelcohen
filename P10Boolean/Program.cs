// mandel

Console.WriteLine("What is your age: ");
var age = int.Parse(Console.ReadLine());

bool isChild = age <= 12;
bool isTeen = age <= 19;
bool isAdult = age > 19;

Console.WriteLine($"You are a child!: {isChild}");
Console.WriteLine($"You are a teenager!: {isTeen}");
Console.WriteLine($"You are an adult!: {isAdult}");

