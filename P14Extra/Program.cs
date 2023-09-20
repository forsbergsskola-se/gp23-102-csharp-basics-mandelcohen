// mandel

// Toggle 0/1
/*
goStart: ;
Console.WriteLine($"Enter 1 or 0");
var userInput = int.Parse(Console.ReadLine());

Console.WriteLine(1 - userInput);
goto goStart;
*/
 
// Maximum

goStart: ;
Console.WriteLine($"Enter first value)");
var userInput1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Enter second value)");
var userInput2 = int.Parse(Console.ReadLine());

int max = userInput1 > userInput2 ? userInput1 : userInput2;

Console.WriteLine($"The maximum is {max}.");