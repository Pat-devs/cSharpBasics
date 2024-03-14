
// Loop through numbers 0 through 100
// And display if the number is even or odd

for(int number = 0; number <= 100; number++)
{
    // example:
    // 2 / 2 ... 0
    // 5 / 2 = ... 1 leftover
    if (number % 2 == 0) // if i divide i by 2, there will be no remainder left.
    {
        Console.WriteLine($"The number {number} is Even");
    }
    else{
        Console.WriteLine($"The number {number} is Odd");
    }
}