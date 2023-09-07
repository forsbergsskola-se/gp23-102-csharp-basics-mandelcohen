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


