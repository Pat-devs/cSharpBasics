class Dog
{
    private int dogId;
    public string Name;
    public int Age;

    // getter (reading things) and setter (updating/writing things back) methods
    public int DogId
    {
        get 
        {
            return dogId;
        }
        set
        {
            dogId = value;
        }
    }

    // the constructor method (it runs whenever we run new Dog command)
    public Dog(string name, int age, int id)
    {
        // first we update the public "Fields" (Name and Name)
        // and set them to the values received during "construction"
        Name = name;
        Age = age;
        dogId = id;
        Console.WriteLine($"Creating a dog named {name}, who is {age} years old. with id {dogId}");
    }
    // Makes the dog bark
    public void Bark()
    {
        Console.WriteLine("Bark");
    }
    // Makes the dog run a fetch an argument
    public void Fetch(string itemName) 
    {
        Console.WriteLine($"{Name} with id {dogId} fetches the {itemName}");
    }
}