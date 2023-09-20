// mandel

Console.WriteLine("Input your grades:");
var grade = int.Parse(Console.ReadLine());

if (grade < 60) {
    Console.WriteLine("F");
}
else if (grade is >= 60 and <= 69) {
    Console.WriteLine("D");
}
else if (grade is >= 70 and <= 79) {
    Console.WriteLine("C");
}
else if (grade is >= 80 and <= 89) {
    Console.WriteLine("B");
}
else {
    Console.WriteLine("A");
}

