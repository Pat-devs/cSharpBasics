Calculator calc = new Calculator();



// array of nums:
//int[] myNums = { 1, 2, 3, 4, 5 };
//Console.WriteLine(myNums[3]);

// Lists
//List<int> myNums2 = new List<int>  { 1, 2, 3, 4, 5 };

// add an item to the list:
//myNums2.Add(13);

//Console.WriteLine(myNums2[5]);

//List<int> myNums2 = new List<int>  { 2, 2, 5, 5, 90, 90 };
//calc.Sum(myNums2);

//string message = Console.ReadLine();

//int userNum = Convert.ToInt32(Console.ReadLine());

// ask the user for some numbers, we can sum together:

// list with users numbers:
List<int> userNums = new List<int>();

while (true) 
{
    string input = Console.ReadLine();
    if (input == "done")
    {
        break;
    }

    userNums.Add(Convert.ToInt32(input));

    Console.WriteLine("Added nr " + input + " to the list.");
}

// Try to sum the numbers user provided:

calc.Sum(userNums);