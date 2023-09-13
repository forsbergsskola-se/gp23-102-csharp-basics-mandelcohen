// mandel

Console.WriteLine("How big do you want your triangle to be?");
int userInput = int.Parse(Console.ReadLine());

int triangle = userInput;

printTriangle: ;
if (triangle > 0) {
    Console.Write('#');
    triangle--;
    goto printTriangle;
}






