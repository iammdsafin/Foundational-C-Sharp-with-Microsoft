//Use if to specify a block of code to be executed, if a specified condition is true
//Use else to specify a block of code to be executed, if the same condition is false
//Use else if to specify a new condition to test, if the first condition is false
//Use switch to specify many alternative blocks of code to be executed

using Microsoft.VisualBasic;

int a = 100;
int b = 15;

if (a > b)
{
    Console.WriteLine("the value of a is greater than b");
}
else if (a == b)
{
    Console.WriteLine("The value of a and b is equal");
}
else
{
    Console.WriteLine("The value of a is smaller than the value of b");
}

//Short hand if else
int time = 2;
string finalTime = (time < 18) ? "Good day." : "Good evening";
Console.WriteLine(finalTime);

//The switch expression is evaluated once
//The value of the expression is compared with the values of each case
//If there is a match, the associated block of code is executed
//The break Keyword
//When C# reaches a break keyword, it breaks out of the switch block.
//This will stop the execution of more code and case testing inside the block.
//When a match is found, and the job is done, it's time for a break. There is no need for more testing.
//The default keyword is optional and specifies some code to run if there is no case match.
int day = 5;

switch (day)
{
    case 0:
        Console.WriteLine("Day 1");
        break;
    case 1:
        Console.WriteLine("Day 2");
        break;
    case 3:
        Console.WriteLine("Day 3");
        break;
    case 4:
        Console.WriteLine("Day 4");
        break;
    case 5:
        Console.WriteLine("Day 5");
        break;
    case 6:
        Console.WriteLine("Day 6");
        break;
    case 7:
        Console.WriteLine("Day 7");
        break;
    default:
        Console.WriteLine("sorry dear no day found");
        break;
}

//The while loop loops through a block of code as long as a specified condition is True.
//Note: Do not forget to increase the variable used in the condition, otherwise the loop will never end!
int i = 0;
while (i <= 100)
{
    Console.WriteLine(i);
    i++;
}

int k = 0;
do
{
    Console.WriteLine(k);
    k++;
}
while (k < 500);

//Statement 1 is executed (one time) before the execution of the code block.
//Statement 2 defines the condition for executing the code block.
//Statement 3 is executed (every time) after the code block has been executed.
for (a = 0; a <= 50; a++)
{
    Console.WriteLine(a);
}

//It is also possible to place a loop inside another loop. This is called a nested loop.
//The "inner loop" will be executed one time for each iteration of the "outer loop".
for (int outer = 1; outer <= 1; ++outer)
{
    Console.WriteLine("I am from outer loop");

    for (int innner = 1; innner <= 3; innner++)
    {
        Console.WriteLine("I am from inner loop" + innner);
    }
}

//There is also a foreach loop, which is used exclusively to loop through elements in an array.
string[] direction = { "East", "West", "North", "South" };
foreach (string d in direction)
{
    Console.WriteLine(d);
}

//The break statement can also be used to jump out of a loop.
//The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.
for (int p = 0; p <= 10; p++)
{
    if (p == 8)
    {
        continue;
    }
    Console.WriteLine(p);
}

//Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
//To declare an array, define the variable type with square brackets.
string[] t = { "East", "West", "North", "South" };

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
for (int c = 0; c < cars.Length; c++)
{
    Console.WriteLine(cars[c]);
}

// Sort a string
string[] car = { "Volvo", "BMW", "Ford", "Mazda" };
Array.Sort(car);
foreach (string u in cars)
{
    Console.WriteLine(u);
}

// Sort an int
int[] myNumbers = { 5, 1, 8, 9 };
Array.Sort(myNumbers);
foreach (int num in myNumbers)
{
    Console.WriteLine(num);
}

//Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace.
int[] numhub = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine(numhub.Max());
Console.WriteLine(numhub.Min());
Console.WriteLine(numhub.Sum());


//A method is a block of code which only runs when it is called and we can pass data, known as parameters, into a method.
//A method is defined with the name of the method, followed by parentheses ().
//To call(execute) a method, write the method's name followed by two parentheses () and a semicolon;
static void printMessage()
{
    Console.WriteLine("Hi I am from printmessage");
}
printMessage();


//Information can be passed to methods as parameter. Parameters act as variables inside the method.
//When a parameter is passed to the method, it is called an argument.
static void functionWithParameter(string name)
{
    Console.WriteLine($"Hey! {name}");
}
functionWithParameter("Safin");

static void functionWithTwoParameter(string name, int age)
{
    Console.WriteLine($"Hey! {name}, i am {age} years old.");
}
functionWithTwoParameter("Ahmed Shafin", 24);


//Use a default parameter value, by using the equals sign(=).
static void defaultParameterValue(string defaultValue = "Ahmed Shafin")
{
    Console.WriteLine($"I am {defaultValue} and i am from default parameter value");
}
defaultParameterValue();

static int returnFunction(int return_numbers)
{
    return return_numbers + 5;
}
Console.WriteLine($"The sum is {returnFunction(10)}");


static int sumFuction(int value_1, int value_2)
{
    return value_1 + value_2;
}
Console.WriteLine($"The addition is {sumFuction(500, 500)}");

static void namedArguments(string arg1, string arg2, string arg3)
{
    Console.WriteLine($"This is argument3 {arg3}");
}
namedArguments("ahmed", "shafin", "shafi");
namedArguments(arg1: "shafi", arg2: "shafin", arg3: "ahmed");

//With method overloading, multiple methods can have the same name with different parameters
namespace MyApplication
{
    class Program
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int myIntSum = PlusMethod(8, 5);
            double myDoubleSum = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myIntSum);
            Console.WriteLine("Double: " + myDoubleSum);
        }
    }
}


//To create an object of Car, specify the class name, followed by the object name, and use the keyword new
//Use the dot syntax (.) to access variables/fields inside a class.
class TestTypeClass
{
    public string tyoeOfTest = "Unit Test";

    static void TestTypeFunction()
    {
        TestTypeClass testtype = new TestTypeClass();
        Console.WriteLine(testtype.tyoeOfTest);
    }
}


//Did you notice the public keyword? It is called an access modifier, which specifies that the color variable/field of Car is accessible for other classes as well.
class AnotherTestTypeClass
{
    public string testtype = "red";
}
class ProgramClass
{
    static void Main(string[] args)
    {
        AnotherTestTypeClass anothertesttype = new AnotherTestTypeClass();
        Console.WriteLine(anothertesttype.testtype);
    }
}