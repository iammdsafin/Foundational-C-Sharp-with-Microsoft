Random random = new ();

int roll1 = random.Next(1, 7);
int roll2 = random.Next(100);
int roll3 = random.Next(500);

Console.WriteLine($"First roll is {roll1}");
Console.WriteLine($"Second roll is {roll2}");
Console.WriteLine($"Third roll is {roll3}");