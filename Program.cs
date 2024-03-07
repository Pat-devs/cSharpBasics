// conditional statements
int userAge = 55;

bool isUserAnAdult = userAge >= 18;

// message to user
string message;

// check if user is an adult and update the message variable

/* // Example 1. using if-else statements:
if (isUserAnAdult)
{
    message = "User is an adult";
}
else
{
    message = "User is not an adult";
} */

// Example 2. using "conditional operator" (also known as ternary operator)

// condtion expression ? if true : if false;
message = isUserAnAdult ? "User is an adult" : "User is not an adult";



// output the message to the user
Console.WriteLine(message);


/* // basic calculator
// declare two number variables and a sum variable
int num1;
int num2;
int sum;
// user input variables (strings)
string userInput1;
string userInput2;

Console.WriteLine("Welcome to my calculator\nEnter a number:");
// Wait for user to enter the first number
userInput1 = Console.ReadLine();

// Convert a string into a number, using the Convert-class
num1 = Convert.ToInt32(userInput1);

//  Wait for user to enter the second number
Console.WriteLine("Enter another number:");
userInput2 = Console.ReadLine();
// Convert userInput2 into a number, using the Convert-class
num2 = Convert.ToInt32(userInput2);

// Calculate the sum of two numbers and store it in the sum variable
sum = num1 + num2;

//Console.WriteLine(num1 + " + " + num2 + " = " + sum);

Console.WriteLine($"{num1} + {num2} = {sum}"); */