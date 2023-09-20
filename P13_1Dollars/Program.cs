// mandel

Console.WriteLine("How many dollars do you want?");
int userInput = int.Parse(Console.ReadLine());

int dollars = userInput;
    Console.Write("Here's your dollars: ");
printDollars: ;
if (dollars > 0)
{
    dollars--;
    Console.Write('$');
    goto printDollars;
}

    

    