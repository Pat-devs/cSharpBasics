// Greeting message
// string greeting = "Hi there!";

// PascalCase
// For: Interface, Classes, Methods etc.
// Console.WriteLine(greeting);

/* int firstNum = 2;
int secondNum = 8; */

//int sum = firstNum + secondNum;

//Console.WriteLine(sum);

//sum = firstNum + firstNum + firstNum + 500;

//Console.WriteLine(sum);

//Console.WriteLine(firstNum + firstNum + firstNum + 500);

//Console.WriteLine(10 % 2);
// math: 10 / 2 = whole number without any remainder
//Console.WriteLine(9 % 2); // 9 / 2 = 4 ... remainder: 1

/* int row = 1;

Console.WriteLine(row % 3);
row = row + 1;
Console.WriteLine(row % 3);
row = row + 1;
Console.WriteLine(row % 3);
row = row + 1;
Console.WriteLine(row % 3);
row = row + 1;
Console.WriteLine(row % 3);
row = row + 1;
Console.WriteLine(row % 3);
row = row + 1;
Console.WriteLine(row % 3); */

/* int myNum = 5;

int anotherNum = 100;

Console.WriteLine(myNum); */

// myNum += 1;
/* myNum++;
myNum++;
myNum++;

Console.WriteLine(myNum); */

//myNum = 2 + ((5 * 100) / 3); 
//Console.WriteLine(myNum);

// float, double, decimal

/* double myShare = 0.05123;

Console.WriteLine(100.0 * myShare); */


/* Console.WriteLine("Enter your username:");

string userName = Console.ReadLine();

Console.WriteLine("...........................");
Console.WriteLine("...........................");
Console.WriteLine("...........................");
Console.WriteLine("...........................");


Console.WriteLine("You entered the username: " + userName); */

// basic calculator
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

Console.WriteLine($"{num1} + {num2} = {sum}");