// mandel

Console.WriteLine("Give me a number of seconds: ");
var userInput = int.Parse(Console.ReadLine());

int remainingSeconds;
var days = Math.DivRem(userInput, 86400, out remainingSeconds);

int remainingHours;
var hours = Math.DivRem(remainingSeconds, 3600, out remainingHours);

int remainingMinutes;
var minutes = Math.DivRem(remainingHours, 60, out remainingMinutes);

var seconds = Math.DivRem(remainingMinutes, 60 out )







Console.WriteLine("Give me a number of seconds: ");
Console.WriteLine("Give me a number of seconds: ");


//$ Console.WriteLine($@"Seconds: {}"); Console.WriteLine($@"Minutes: {minutes}"); Console.WriteLine($@"Hours: {hours}"); Console.WriteLine($@"Days: {days}");
