// mandel

Console.WriteLine("Input first number:");
var inputA = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number:");
var inputB = int.Parse(Console.ReadLine());
Console.WriteLine("Input third number:");
var inputC = int.Parse(Console.ReadLine());

if (inputA > inputB && inputA > inputC) {
    Console.WriteLine($"{inputA},");
}
else if (inputB > inputA && inputB > inputC) {
    Console.WriteLine($"{inputB},");
}
else {
    Console.WriteLine($"{inputC},");
}
if (inputA < inputB && inputA < inputC) {
    Console.WriteLine($"{inputA}");
}
else if (inputB < inputA && inputB < inputC) {
    Console.WriteLine($"{inputB}");
}
else {
    Console.WriteLine($"{inputC}");
}
