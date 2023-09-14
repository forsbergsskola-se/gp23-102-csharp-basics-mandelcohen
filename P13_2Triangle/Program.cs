// mandel

Console.WriteLine("How big do you want your triangle to be?");
int rows = int.Parse(Console.ReadLine());

for (int i = 1 ; i <= rows ; i++) {
    for (int draw = 1; draw <= i; draw++) {
        Console.Write('#');    
    }
    Console.WriteLine();
}








