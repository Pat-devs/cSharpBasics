class Dog
{
    public string Name;
    public int Age;
    // the constructor method (it runs whenever we run new Dog command)
    public Dog(string name, int age)
    {
        // first we update the public "Fields" (Name and Name)
        // and set them to the values received during "construction"
        Name = name;
        Age = age;
        Console.WriteLine($"Creating a dog named {name}, who is {age} years old.");
    }
    // Makes the dog bark
    public void Bark()
    {
        Console.WriteLine("Bark");
    }
    // Makes the dog run a fetch an argument
    public void Fetch(string itemName) 
    {
        Console.WriteLine($"{Name} fetches the {itemName}");
    }
}