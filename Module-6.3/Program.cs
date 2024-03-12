// //The try code block contains the guarded code that may cause an exception. If the code within a try block causes an exception, the exception is handled by a corresponding catch block.
// //The catch code block contains the code that's executed when an exception is caught. The catch block can handle the exception, log it, or ignore it. A catch block can be configured to execute when any exception type occurs, or only when a specific type of exception occurs.
// //The finally code block contains code that executes whether an exception occurs or not. The finally block is often used to clean up any resources that are allocated in a try block. For example, ensuring that a variable has the correct or required value assigned to it.

// //Exception handling in a C# application is generally implemented using one or more of the following patterns:
// //The try-catch pattern consists of a try block followed by one or more catch clauses. Each catch block is used to specify handlers for different exceptions.
// //The try-finally pattern consists of a try block followed by a finally block. Typically, the statements of a finally block run when control leaves a try statement.
// //The try-catch-finally pattern implements all three types of exception handling blocks. A common scenario for the try-catch-finally pattern is when resources are obtained and used in a try block, exceptional circumstances are managed in a catch block, and the resources are released or otherwise managed in the finally block.

// //Execution begins in the code block of the outer try statement.
// //An exception is thrown in the code block of the inner try statement.
// //The runtime finds the catch clause associated with the outer try statement.
// //Before the runtime transfers control to the first line of the catch code block, it executes the finally clause associated with the inner try statement.
// //The runtime then transfers control to the first line of the catch code block and executes the code that handles the exception.\


//ArrayTypeMismatchException
string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;
Object obj = (Object)13;
objs[2] = obj; // ArrayTypeMismatchException occurs


//DivideByZeroException
int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2); // DivideByZeroException occurs


//FormatException
int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); // FormatException occurs


//IndexOutOfRangeException
int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];

values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs


//InvalidCastException
object obj = "This is a string";
int num = (int)obj;


//NullReferenceException
int[] values = null;
for (int i = 0; i <= 9; i++)
    values[i] = i * 2;

string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());


//OverflowException
decimal x = 400;
byte i;

i = (byte)x; // OverflowException occurs
Console.WriteLine(i);

try
{
    int num1 = int.MaxValue;
    int num2 = int.MaxValue;
    int result = num1 + num2;
    Console.WriteLine("Result: " + result);

    string str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);

    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);

    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (OverflowException ex)
{
    Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null." + ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range." + ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}

Console.WriteLine("Exiting program.");