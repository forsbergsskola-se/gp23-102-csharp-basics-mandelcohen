// mandel

// exercise 1 
/*
Console.WriteLine("Input km/h to convert to m/s");
var userInput = double.Parse(Console.ReadLine());;

var convertMs = userInput / 3.6;

Console.WriteLine($@"That's {convertMs} m/s.");
*/

// exercise 1.2
/*
Console.WriteLine("Please enter number of minutes you want to convert to seconds."); 
var userInput = int.Parse(Console.ReadLine());

var y = userInput * 60;
Console.WriteLine($"There are {y} seconds in {userInput} minutes.");    
*/

// exercise 2 

/*
Console.WriteLine("Enter first value:");
var inputA = float.Parse(Console.ReadLine());
Console.WriteLine("Enter second value:");
var inputB = float.Parse(Console.ReadLine());

var result = inputA / inputB;
Console.WriteLine($@"Result: {result}");
*/
// exercise 3

/*
Console.WriteLine("Enter first value:");
var inputA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second value:");
var inputB = int.Parse(Console.ReadLine());

float result = (float)inputA / inputB;

Console.WriteLine(result);
*/

// exercise 4
/*
Console.WriteLine("Enter radius in meters:");
double r = double.Parse(Console.ReadLine());

double a = r * r * Math.PI;
Console.WriteLine($"Area = {a} m2");
*/

//exercise 5
/*
Console.WriteLine("Enter number to negate:");
var input = int.Parse(Console.ReadLine());

Console.WriteLine($"{-input}");
*/

// exercise 6
/*
Console.WriteLine("Enter first value:");
var inputA = float.Parse(Console.ReadLine());
Console.WriteLine("Enter second value:");
var inputB = float.Parse(Console.ReadLine());

Console.WriteLine( inputA * inputB );
*/

// exercise 7
/*
Console.WriteLine("Enter your weight in kg:");
var inputA = float.Parse(Console.ReadLine());
Console.WriteLine("Enter your height in meters:");
var inputB = float.Parse(Console.ReadLine());

float BMI = inputA / (inputB * inputB);
Console.WriteLine($"Your BMI = {BMI}");
*/

// exercise 8

Console.WriteLine("Enter side A:");
var inputA = float.Parse(Console.ReadLine());
Console.WriteLine("Enter side B:");
var inputB = float.Parse(Console.ReadLine());

var h = (inputA * inputA) + (inputB * inputB);
var answer = MathF.Sqrt(h);

Console.WriteLine($"The Hypotenuse is: {answer}");


// exercise 9

Console.WriteLine("Enter number of seconds to covert to minutes:");
var userInput = int.Parse(Console.ReadLine());

int s = (userInput % 60);
int m = (userInput - s) / 60;

Console.WriteLine($"That'll be {m} minutes and {s} seconds");
    





