Random myRng = new Random();

// dice gives random number between 1-6
int dice1 = myRng.Next(1,7);
int dice2 = myRng.Next(1,7);
int dice3 = myRng.Next(1,7);
int dice4 = myRng.Next(1,7);
int dice5 = myRng.Next(1,7);

//myRng.NextDouble
// double luckyNum = myRng.NextDouble(); // returns a rng num between 0.0 - 1.0

// 0.0 - 0.5

// print a random number
Console.WriteLine(dice1);
Console.WriteLine(dice2);
Console.WriteLine(dice3);
Console.WriteLine(dice4);
Console.WriteLine(dice5);
