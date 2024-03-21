class Calculator
{
    public void Sum(List<int> nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Count(); i++)
        {
            sum += nums[i];
        }
        Console.WriteLine(sum);
    }
}