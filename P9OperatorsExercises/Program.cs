// See https://aka.ms/new-console-template for more information

// exercise 1

Console.WriteLine(@"Welcome! 
Please enter a value in km/h.");
string input = Console.ReadLine();

float number = float.Parse(input);
float x = number / 60 / 60 * 1000;
Console.WriteLine($"That would be {x} m/s");


// excercise 2