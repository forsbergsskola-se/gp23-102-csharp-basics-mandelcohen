// mandel

using System.Security.Cryptography;

Console.WriteLine("Please pass me a sees (integer)");
var seed = int.Parse(Console.ReadLine());

var random = new Random(seed);
var number = random.Next(0, 5);




