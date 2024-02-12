//The C# language supports a wide range of operators (such as equality, comparison, and Boolean operators).

//What is an expression ?
//An expression is any combination of values(literal or variable), operators, and methods that return a single value.

//Boolean expressions are important because your code can use these expressions to decide which block of code to execute.

//There are many different kinds of expressions that evaluate to either true or false.
//Evaluate equality using the == operator.
//Evaluating equality of strings requires you to consider the possibility that the strings have different case and leading or trailing spaces.Depending on your situation, use the ToLower() or ToUpper() helper methods, and the Trim() helper method to improve the likelihood that two strings are equal.
//Evaluate inequality using the != operator.
//Evaluate greater than, less than and similar operations using comparison operators like >, <, >=, and <=.
//If a method returns a bool, it can be used as a Boolean expression.
//Use the logical negation operator ! to evaluate the opposite of a given expression.


//Use the equality operator
using System.Runtime.Intrinsics.X86;

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string varValue = "a";
Console.WriteLine(varValue == "a");
Console.WriteLine("a" == "a ");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//Use the inequality operator
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string varvlue2 = "a";
Console.WriteLine(varvlue2 != "a");

//Use the Comparison operators
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 2);
Console.WriteLine(1 <= 2);

//Use a method that returns a Boolean
string stringData = "A quick brown fox jumps over the lazy dog";
Console.WriteLine(stringData.Contains("fox"));
Console.WriteLine(stringData.Contains("cow"));

//Use the Logical Negation operator
string stringData2 = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!stringData2.Contains("fox"));
Console.WriteLine(!stringData2.Contains("cow"));

//What is the conditional operator?
//The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on whether the Boolean expression evaluates to true or false.
int saleAmmount  = 999;
int discount = saleAmmount >= 1000 ? 100 : 50;
Console.WriteLine($"Your discount ammount is {discount}");

//Use the Random class to generate a value.
//Consider the range of numbers that is required.
//Based on the value generated, use the conditional operator to display either heads or tails.
//There should be a 50% chance that the result is either heads or tails.

Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "Heads" : "Tails");

string permission = "Admin | Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome super admin user.");
    }
    else
    {
        Console.WriteLine("Welcome admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
}
else {
    Console.WriteLine("You do not have sufficient privileges");
}