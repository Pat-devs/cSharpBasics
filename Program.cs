/*
In the FizzBuzz game, you count from 1 to 100. For each number:

If it's divisible by 3, you say "Fizz".
If it's divisible by 5, you say "Buzz".
If it's divisible by both 3 and 5, you say "FizzBuzz".
Otherwise, you just say the number.
*/
for(int number = 1; number <= 100; number++)
{
    string message = "";
    if (number % 3 == 0) // If it's divisible by 3, you say "Fizz".
    {
        message += "Fizz";
    }
    if (number % 5 == 0) // If it's divisible by 3, you say "Fizz".
    {
        message += "Buzz";
    }
    else if (number % 3 != 0 && number % 5 != 0) // Otherwise, you just say the number.
    {
        message = Convert.ToString(number);
    }

    Console.WriteLine(message);

    /* if (number % 3 == 0 && number % 5 == 0) // If it's divisible by both 3 and 5, you say "FizzBuzz".
    {
        message = "FizzBuzz";
    }
    else if (number % 3 == 0) // If it's divisible by 3, you say "Fizz".
    {
        message = "Fizz";
    }
    else if (number % 5 == 0) // If it's divisible by 5, you say "Buzz".
    {
        message = "Buzz";
    }
    else // Otherwise, you just say the number.
    {
        message = Convert.ToString(number);
    }

    Console.WriteLine(message); */
}