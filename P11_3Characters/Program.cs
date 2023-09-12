// mandel

Console.WriteLine("Type a single character:");
char userInput = char.Parse(Console.ReadLine());

if (userInput is 'a' or 'e' or 'i' or 'o' or 'u' or 'y') {
    Console.WriteLine("That's a vowel!");
}
else if (userInput is '0' or '1' or '2' or '3' or '4' or '5' or '6' or '7' or '8' or '9'){
    Console.WriteLine("That's a digit!");
}
else {
    Console.WriteLine("That's a consonant!");
}