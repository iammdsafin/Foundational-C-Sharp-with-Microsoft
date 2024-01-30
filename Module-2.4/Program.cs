//Arrays can be used to store multiple values of the same type in a single variable. The values stored in an array are generally related. 
//For example, a list of student names could be stored in a string array named students.
//What is an array ?
//An array is a sequence of individual data elements accessible through a single variable name. You use a zero-based numeric index to access each element of an array. 

//string[] fradulentOrderIds = new string[3];

//fradulentOrderIds[0] = "A2R1";
//fradulentOrderIds[1] = "A2R2";
//fradulentOrderIds[2] = "A2R3";

//OR

using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using static System.Collections.Specialized.BitVector32;

string[] fradulentOrderIds = { "A123", "B456", "C789" };

Console.WriteLine($"First room number: {fradulentOrderIds[0]}");
Console.WriteLine($"Second room number: {fradulentOrderIds[1]}");
Console.WriteLine($"Thrid room number: {fradulentOrderIds[2]}");

fradulentOrderIds[0] = "AA!!!";
Console.WriteLine($"Reasign room number to the first room {fradulentOrderIds[0]}");
Console.WriteLine($"There are total {fradulentOrderIds.Length} elements in the array");


//Use the foreach statement to iterate through each element in an array, executing the associated code block once for each element in the array.
//The foreach statement sets the value of the current element in the array to a temporary variable, which you can use in the body of the code block.
//Use the ++ increment operator to add 1 to the current value of a variable.
string[] names = { "Rowena", "Robin", "Bao" };

foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} (Running total: {sum})");
}
Console.WriteLine($"The total sum is {sum}");


//for nested iteration and selection statements
string[] elements = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string element in elements)
{
    if (element.StartsWith("B"))
    {
        Console.WriteLine(element);
    }
}