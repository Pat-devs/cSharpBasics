/* using System.ComponentModel;

int x = 1;
while (x <= 5) {
    Console.WriteLine(x);
    x++;
} */

// for loop:

//for ("initial statemement"; "condition to evaluate"; "updating function")

for (int i = 1; i <= 50; i++) {

    if (i == 3) continue; // continue prevents code below from running
    Console.WriteLine(i);
    if (i >= 10) break; // to break out of the loop
}

/* 
// basic calculator
// declare two number variables and a sum variable

// new features and how it should work:
// 1. Show the welcome message
// 2. Ask user to provide a number
// 3. Ask user to provide a mathematical operator (+,-,/,*)
// 4. Ask user to provide another number
// 5. Check which operator the user typed
// 6. Based on #4 calculate the equation, and display the result

using System.Security.Cryptography.X509Certificates;

int num1;
int num2;
int result;

Console.WriteLine("Welcome to my calculator\nEnter a number:");
// 1. Wait for user to enter the first number
// Convert the user input into a number, using the Convert-class
num1 = Convert.ToInt32(Console.ReadLine());

// 2. Wait for user to enter an operator:
Console.WriteLine("Enter either +,-,/,* operator:");
string mathOperator = Console.ReadLine();



// check if the user entered a valid operator
if (mathOperator == "+") 
{
    // 3. Run the math operation and display the result
    //  Wait for user to enter the second number
    Console.WriteLine("Enter another number:");
    // Convert user input into a number, using the Convert-class
    num2 = Convert.ToInt32(Console.ReadLine());

    // Calculate the sum of two numbers and store it in the sum variable
    result = Add(num1,num2);
    // Display the result to the user
    Console.WriteLine($"{num1} + {num2} = {result}");
}
else if (mathOperator == "-") 
{
    // 3. Run the math operation and display the result
    //  Wait for user to enter the second number
    Console.WriteLine("Enter another number:");
    // Convert user input into a number, using the Convert-class
    num2 = Convert.ToInt32(Console.ReadLine());

    // Calculate the sum of two numbers and store it in the sum variable
    result = Sub(num1,num2);
    // Display the result to the user
    Console.WriteLine($"{num1} - {num2} = {result}");
}
else if (mathOperator == "/") 
{
    // 3. Run the math operation and display the result
    //  Wait for user to enter the second number
    Console.WriteLine("Enter another number:");
    // Convert user input into a number, using the Convert-class
    num2 = Convert.ToInt32(Console.ReadLine());

    if (num2 != 0) 
    {
        // Calculate the sum of two numbers and store it in the sum variable
        result = Div(num1,num2);
        // Display the result to the user
        Console.WriteLine($"{num1} / {num2} = {result}");
    }
    else
    {
        Console.WriteLine("Cannot divide by 0!");
    }
}
else if (mathOperator == "*") 
{
    // 3. Run the math operation and display the result
    //  Wait for user to enter the second number
    Console.WriteLine("Enter another number:");
    // Convert user input into a number, using the Convert-class
    num2 = Convert.ToInt32(Console.ReadLine());

    // Calculate the sum of two numbers and store it in the sum variable
    result = Mul(num1,num2);
    // Display the result to the user
    Console.WriteLine($"{num1} * {num2} = {result}");
}
else
{
    Console.WriteLine("You entered an invalid operator!");
}


// Math functions:

// Return the sum of two numbers:
int Add(int a, int b) => a + b;
int Sub(int a, int b) => a - b;
int Div(int a, int b) => a / b;
int Mul(int a, int b) => a * b;
 */