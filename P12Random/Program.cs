// mandel

using System.Numerics;
using System.Security.Cryptography;

Console.WriteLine("Please pass me a seed (integer)");
var seed = int.Parse(Console.ReadLine());

var random = new Random(seed);
Console.WriteLine(random.Next(0, 5));
Console.WriteLine(random.Next(0, 5));
Console.WriteLine(random.Next(0, 5));

Console.WriteLine("Three numbers between 0.0 and 0.5:");

Console.WriteLine(random.NextDouble()*0.5);
Console.WriteLine(random.NextDouble()*0.5);
Console.WriteLine(random.NextDouble()*0.5);

Console.WriteLine("Three numbers between 0.2 and 0.7:");

Console.WriteLine(random.NextDouble()*(0.7 - 0.2)+0.2);
Console.WriteLine(random.NextDouble()*(0.7 - 0.2)+0.2);
Console.WriteLine(random.NextDouble()*(0.7 - 0.2)+0.2);

Console.WriteLine("Give me a crit chance between 0.0 (0%) and 1.0 (100%)");
var chance = double.Parse(Console.ReadLine());

Console.WriteLine(random.NextDouble() < chance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() < chance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() < chance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() < chance ? "Crit" : "No Crit");
Console.WriteLine(random.NextDouble() < chance ? "Crit" : "No Crit");