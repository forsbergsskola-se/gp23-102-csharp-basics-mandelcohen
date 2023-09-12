// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me an integer:");
int userInput = int.Parse(Console.ReadLine());

Console.WriteLine(userInput % 2 == 0 ? "Your number is even." : "Your number is odd.");