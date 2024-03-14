using System;

public class Dog
{
    // Properties
    public string Name { get; set; }
    public int Age { get; set; }
    public string Breed { get; set; }

    // Constructor
    public Dog(string name, int age, string breed)
    {
        Name = name;
        Age = age;
        Breed = breed;
    }

    // Bark Method:
    public void Bark() 
    {
        Console.WriteLine("BARK, BARK!!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a new instance of the Dog class
        Dog myDog = new Dog("Buddy", 3, "Golden Retriever");

        Dog mySecondDog = new Dog("Bob", 4, "Husky");
        // 1. type (name of the class, ie: Dog).
        // 2. name of the variable (that holds an instance of a Dog)
        // after = sign:
        // new (means create a new instance of the given class)
        // NameOfClass (plus any paramteres)

        Console.WriteLine("I have one dog called " + myDog.Name);

        Console.WriteLine("And I have another one called " + mySecondDog.Name);

        mySecondDog.Bark();
    }
}
