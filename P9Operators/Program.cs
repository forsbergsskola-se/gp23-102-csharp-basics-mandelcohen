// mandel


Console.WriteLine("Give me a number of seconds: ");
var userInput = int.Parse(Console.ReadLine());

var days = Math.DivRem(userInput, 86400, out int remainingH);
var hours = Math.DivRem(remainingH, 3600, out int remainingM);
var minutes = Math.DivRem(remainingM, 60, out int remainingS);

Console.WriteLine($"Seconds: {remainingS}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Days: {days}");

Console.WriteLine($"{days}.{hours}:{minutes}:{remainingS}");

var total = Convert.ToDecimal(userInput) / 86400;
Console.WriteLine($"In total, that's {total}");





