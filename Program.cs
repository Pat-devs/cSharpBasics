//int myNum = 2;

// Create an instance of a "Dog"
Dog myFirstDog = new Dog("Spot", 2, 1234); // a name, an ac
//myFirstDog.name = "Spot";
//myFirstDog.age = 2;

Dog mySecondDog = new Dog("Buddy", 4, 12345); // a name, an age
//mySecondDog.name = "Buddy";
//myFirstDog.age = 3;

// with a constructor method, we can send multiple arguments while we instantiate the class:
//Dog myFirstDog = new Dog("Spot", 2); // new dog, name: spot, age: 2


//Console.WriteLine(myFirstDog);



//Console.WriteLine($"My name is {myFirstDog.name}");
//myFirstDog.Bark();
//Console.WriteLine($"My name is {mySecondDog.name}");
//mySecondDog.Bark();


myFirstDog.Fetch("paper");

//Console.WriteLine("Hey dog, gimme your id!" + myFirstDog.dogId);

// read value from a get method:
Console.WriteLine(myFirstDog.DogId);
// set a value with a setter method:
myFirstDog.DogId = 9876;
Console.WriteLine(myFirstDog.DogId);