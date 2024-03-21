class Calculator
{
    public void Sum(List<int> nums)
    {
        int sum = 0;
        string equation = "";
        // loop through the entire list of nums and calculate the sum    
        foreach (int num in nums)
        {
            equation += " + " +  num;
            sum += num;
        }

        Console.WriteLine(equation + " = " + sum);
    }
}