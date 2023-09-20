// mandel

Console.WriteLine("Input first number:");
var inputA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input second number:");
var inputB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input third number:");
var inputC = int.Parse(Console.ReadLine()!);

int max;
int min;

if (inputA > inputB && inputA > inputC) {
    max = inputA;
}
else if (inputB > inputC) {
    max = inputB;
}
else {
    max = inputC;
}

if (inputA < inputB && inputA < inputC) { 
    min = inputA;
}
else if (inputB < inputC) { 
    min = inputB;
}
else { 
    min = inputC;
}

Console.WriteLine($"{min},{max}");