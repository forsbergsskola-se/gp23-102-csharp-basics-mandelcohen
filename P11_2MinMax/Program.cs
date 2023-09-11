// mandel

Console.WriteLine("Input first number");
var inputA = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number");
var inputB = int.Parse(Console.ReadLine());
Console.WriteLine("Input third number");
var inputC = int.Parse(Console.ReadLine());

List<int> inputs = new List<int>(){inputA, inputB, inputC};

Console.WriteLine("Max:" + inputs.Max());
Console.WriteLine("Min:" + inputs.Min());