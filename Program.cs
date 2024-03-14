/*
In the FizzBuzz game, you count from 1 to 100. For each number:

If it's divisible by 3, you say "Fizz".
If it's divisible by 5, you say "Buzz".
If it's divisible by both 3 and 5, you say "FizzBuzz".
Otherwise, you just say the number.
*/

for(int number = 1; number <= 100; number++)
{
    if (number % 3 == 0 && number % 5 == 0) // If it's divisible by both 3 and 5, you say "FizzBuzz".
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (number % 3 == 0) // If it's divisible by 3, you say "Fizz".
    {
        Console.WriteLine("Fizz");
    }
    else if (number % 5 == 0) // If it's divisible by 5, you say "Fizz".
    {
        Console.WriteLine("Buzz");
    }
    
    else // Otherwise, you just say the number.
    {
        Console.WriteLine(number);
    }
}