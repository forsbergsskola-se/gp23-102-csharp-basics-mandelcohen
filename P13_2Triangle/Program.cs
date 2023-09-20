// mandel

Console.WriteLine("How big do you want your triangle to be?");
int userInput = int.Parse(Console.ReadLine());

for (int rows = userInput ; rows <= userInput && rows > 0 ; rows--) {
    for (int draw = 1; draw <= rows ; draw++) {
        Console.Write('#');    
    }
    Console.WriteLine();
}








