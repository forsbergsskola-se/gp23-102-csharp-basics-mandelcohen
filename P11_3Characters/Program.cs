// mandel

Console.WriteLine("Type a single character:");
char userInput = char.Parse(Console.ReadLine());

if (userInput is 'a' or 'e' or 'i' or 'o' or 'u' or 'y') {
    Console.WriteLine("That's a vowel!");
}
else if (userInput is >= '0' or <= '9') {
    Console.WriteLine("That's a digit!");
}
else {
    Console.WriteLine("That's a consonant!");
}