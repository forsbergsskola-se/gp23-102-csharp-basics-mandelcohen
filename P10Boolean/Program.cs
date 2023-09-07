// mandel

Console.WriteLine("What is your age: ");
var age = int.Parse(Console.ReadLine());

bool isChild = age < 13;
bool isTeen = age is >= 13 and >= 19;
bool isAdult = age > 19;

Console.WriteLine(@$"You are a child!: {isChild}
You are a teenager!: {isTeen}
You are an adult!: {isAdult}");



