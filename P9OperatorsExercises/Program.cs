// mandel

// exercise 1 

Console.WriteLine(@"Welcome! 
Please enter a value in km/h.");
String userInput = Console.ReadLine();

float userNumber = float.Parse(userInput);
float x = userNumber / 60 / 60 * 1000;
Console.WriteLine($"That would be {x} m/s");


// exercise 2

Console.WriteLine("Please enter number of minutes you want to convert to seconds.");
userInput = Console.ReadLine();

userNumber = float.Parse(userInput);
float y = userNumber * 60;
Console.WriteLine($"There are {y} seconds in {userInput} minutes.");    

// exercise 3




