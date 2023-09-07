// mandel

Console.WriteLine("Give me a number of seconds: ");
var userInput = int.Parse(Console.ReadLine());

int remainingH;
var days = Math.DivRem(userInput, 86400, out remainingH);

int remainingM;
var hours = Math.DivRem(remainingH, 3600, out remainingM);

int remainingS;
var minutes = Math.DivRem(remainingM, 60, out remainingS);


Console.WriteLine($"Seconds: {remainingS}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Days: {days}");


TimeSpan ts = new TimeSpan(1, 10, 17, 36);
Console.WriteLine(ts.ToString(@"d\.hh\:mm\:ss"));

var total = Convert.ToDecimal(userInput) / 86400;
Console.WriteLine($"In total, that's {total}");

