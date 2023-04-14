using System;

Console.Write("Enter a number between 1 and 100: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 1 && number < 60)
{
    Console.WriteLine($"{number} is odd and less than 60.");
}
else if (number % 2 == 0 && (number >= 2 && number <= 24))
{
    Console.WriteLine($"{number} is even and less than 25.");
}
else if (number % 2 == 0 && (number >= 26 && number <= 60))
{
    Console.WriteLine($"{number} is even and between 26 and 60 inclusively.");
} 
else if (number % 2 == 0 && number > 60)
{
    Console.WriteLine($"{number} is even and greater that 60.");
}
else if (number % 2 == 1 && number > 60)
{
    Console.WriteLine($"{number} is odd and greater that 60");
}