// mandel

Console.WriteLine("Give me a number of seconds: ");
int userInput = int.Parse(Console.ReadLine());

/*
int days = userInput / 86400;
int remainingH = userInput % 86400;
int hours = remainingH / 3600;
int remainingM = remainingH % 3600;
int min = remainingM / 60;
int remainingS = remainingM % 60;
*/

int days = Math.DivRem(userInput, 86400, out int remainingH);
int hours = Math.DivRem(remainingH, 3600, out int remainingM);
int min = Math.DivRem(remainingM, 60, out int remainingS);

Console.WriteLine($"Seconds: {remainingS}");
Console.WriteLine($"Minutes: {min}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Days: {days}");

Console.WriteLine($"{days}.{hours}:{min}:{remainingS}");

decimal total = Convert.ToDecimal(userInput) / 86400;
Console.WriteLine($"In total, that's {total}");





