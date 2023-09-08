// mandel

// Toggle 0/1

goStart: ;
Console.WriteLine($"Enter 1 or 0");
var userInput = int.Parse(Console.ReadLine());

Console.WriteLine(1 - userInput);
goto goStart;