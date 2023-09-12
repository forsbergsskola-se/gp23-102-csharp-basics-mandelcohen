// mandel

Console.WriteLine("Enter first value:");
var inputA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the operand:");
var inputO = char.Parse(Console.ReadLine());
Console.WriteLine("Enter the second value:");
var inputB = int.Parse(Console.ReadLine());

if (inputO == '+') {
    Console.WriteLine(inputA + inputB);
}
else if (inputO == '-') {
    Console.WriteLine(inputA - inputB);
}
else if (inputO == '*') {
    Console.WriteLine(inputA * inputB);
}
else {
    Console.WriteLine(inputA / inputB);
}

