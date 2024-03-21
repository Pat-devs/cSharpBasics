class Dog
{
    private int dogId;
    public string Name;
    public void Bark(int numBarks, string someMessage)
    public int Age;

    // alternative to getter / setter methods:
    public void setDogId(int newId)
    {
        dogId = newId;
    }
    public int getDogId() {
        return dogId;
    }
    ///////////////////////////////////

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
    public void Bark(string barkMessage)
    {
        Console.WriteLine("Dog barks with message: " + barkMessage);
    }
    public void Bark(int numBarks)
    {
        while (numBarks > 0)
        {
            Console.WriteLine("Bark");
            numBarks--;
        }
    }
    // Makes the dog run a fetch an argument
    public void Fetch(string itemName) 
    {
        Console.WriteLine($"{Name} with id {dogId} fetches the {itemName}");
    }
}