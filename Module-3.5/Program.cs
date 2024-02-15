//What is the do -while statement ?
//The do -while statement executes a statement or a block of statements while a specified Boolean expression evaluates to true. 
//Because that expression is evaluated after each execution of the loop, a do-while loop executes one or more times.

//The do-while statement iterates through a code block at least once, and might continue to iterate based on a Boolean expression. The evaluation of the Boolean expression usually depends on some value generated or retrieved inside of the code block.
//The while statement evaluates a Boolean expression first, and continues to iterate through the code block as long as the Boolean expression evaluates to true.
//The continue keyword to step immediately to the Boolean expression.

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine($"The current value genarated from Random class is {current}");
}
while (current != 7);


Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);
    if (current >= 10) continue;

    {
        Console.WriteLine(current);
    }
}
while (current != 7);

//Role playing game battle challenge

int heroHealthScore = 10;
int monsterHealthScore = 10;
Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monsterHealthScore -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealthScore} health.");

    if (monsterHealthScore <= 0) continue;
    {
        roll = dice.Next(1, 11);
        heroHealthScore -= roll;
        Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroHealthScore} health.");
    }
}
while (heroHealthScore > 0 && monsterHealthScore > 0);
{
    Console.WriteLine(heroHealthScore > monsterHealthScore ? "Hero wins!" : "Monster wins!");
}

//The for statement: executes its body while a specified Boolean expression (the 'condition') evaluates to true.
//    The foreach statement: enumerates the elements of a collection and executes its body for each element of the collection.
//        The do-while statement: conditionally executes its body one or more times.
//            The while statement: conditionally executes its body zero or more times.

//The for and foreach iterations seem to be clearly differentiated from each other and from the do-while and while iterations. 
//The definitions for the do-while and while statements, however, appear to be quite similar. 
//Knowing when to choose between a do-while and a while seems more arbitrary, and can even be a bit confusing. 
//Some challenge projects may help to make the differences clear.

string? readFromUser;
Console.WriteLine("Enter Something");

do
{
    readFromUser = Console.ReadLine();
    Console.WriteLine($"Entered Something is {readFromUser}");
}
while (readFromUser == null);


//Code project 1 - write code that validates integer input
Console.WriteLine("Enter an integer value between 5 and 10:");
int userInput;

do
{
    string inputString = Console.ReadLine();

    if (int.TryParse(inputString, out userInput))
    {
        if (userInput >= 5 && userInput <= 10)
        {
            Console.WriteLine($"Your input value ({userInput}) has been accepted.");
            break;
        }
        else
        {
            Console.WriteLine($"You entered {userInput}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number. Please try again:");
    }
} while (true);



//Code project 2 - write code that validates string input
Console.WriteLine("Enter your role (Administrator, Manager, or User):");
string userRole;

do
{
    userRole = Console.ReadLine().Trim().ToLower();
    switch (userRole)
    {
        case "administrator":
        case "manager":
        case "user":
            Console.WriteLine($"Your input value ({userRole}) has been accepted.");
            break;
        default:
            Console.WriteLine($"The role name that you entered, \"{userRole}\", is not valid. Enter your role (Administrator, Manager, or User):");
            break;
    }
} while (userRole != "administrator" && userRole != "manager" && userRole != "user");



//Code project 3 - Write code that processes the contents of a string array
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string originalString in myStrings)
{
    string myString = originalString;
    int periodLocation = myString.IndexOf(".");

    if (periodLocation != -1)
    {
        do
        {
            string sentence = myString.Substring(0, periodLocation).TrimStart();
            Console.WriteLine(sentence);

            myString = myString.Remove(0, periodLocation + 1);

            periodLocation = myString.IndexOf(".");
        } while (periodLocation != -1);

        Console.WriteLine(myString.Trim());
    }
    else
    {
        Console.WriteLine(myString);
    }
}