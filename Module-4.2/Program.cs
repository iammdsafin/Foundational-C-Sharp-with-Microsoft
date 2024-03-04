using System.Numerics;
using System.Runtime.Intrinsics.X86;

int firstValue = 2;
string secondValue = "4";
//int result = first + second;
//Error CS0029	Cannot implicitly convert type 'string' to 'int
string result = firstValue + secondValue;
Console.WriteLine(result);
Console.WriteLine("");

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

//int first = 5;
//int second = 7;
//string message = first.ToString() + second.ToString();
//Console.WriteLine(message);

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int res = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(res);


//string name = "iammdsafin";
//Console.WriteLine(int.Parse(name));

//Use TryParse()
//The TryParse() method does several things simultaneously:

//It attempts to parse a string into the given numeric data type.
//If successful, it stores the converted value in an out parameter, explained in following section.
//It returns a bool to indicate whether the action succeeded or failed.

string value = "101";
int feedback = 0;
if (int.TryParse(value, out feedback))
{
    Console.WriteLine($"Measurement: {feedback}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (feedback > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + feedback}");


////Exercise - Complete a challenge to combine string array values as strings and as integers.
string[] givenArray = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string fullMessage = "";

foreach (var item in givenArray)
{
    decimal number;
    if (decimal.TryParse(item, out number))
    {
        total += number; ;
    }
    else
    {
        fullMessage += item;
    }
}
Console.WriteLine(fullMessage);
Console.WriteLine(total);



//Exercise - Complete a challenge to output math operations as specific number types

int valueOne = 12;
decimal valueTwo = 6.2m;
float valueThree = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = valueOne/(int)valueTwo;
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = valueTwo/(decimal)valueThree;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = valueThree/(float)valueOne;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");