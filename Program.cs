// conditional statements



int score = 51; // 0-100
int experience = 3;

// check of score is between 50 to 60 ?
if (score >= 50 && score <= 60)
{
    // code written here will only execute if the above condition is "truthy"
    Console.WriteLine("score between 50 to 60");
    if (experience > 5) {
        Console.WriteLine("and experience is greater than 5");
    }

    string message = "HI";
    Console.WriteLine(message);
}
else
{
    Console.WriteLine("score is outside of the range 50 to 60");
}

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