//Add two numaric values
using System.Runtime.CompilerServices;

int num1 = 10;
int num2 = 20;
Console.WriteLine(num1+num2);

string planet_name= "Planet Earth";
int total_days = 365;
Console.WriteLine(planet_name + " have " + (total_days) + " days.");

//The parentheses symbol () becomes another overloaded operator. 
Console.WriteLine(planet_name + " have " + (total_days - 1) + " days.");


decimal decimalQuotient = 7 / 5.0m;
decimal decimalQuotient1 = 7.0m / 5.0m;
Console.WriteLine($"Decimal quotient: {decimalQuotient} and {decimalQuotient1}");

//The division of two int values will result in the truncation of any values after the decimal point and
//need to cast the divisor or dividend (or both) from int into a floating point number like decimal first, then the quotient must be of the same floating point type as well in order to avoid truncation.
int a = 10;
int b = 3;
decimal result = (decimal)a / (decimal)b;
Console.WriteLine(result);

//The += operator adds and assigns the value on the right of the operator to the value on the left of the operator. 
int inc = 0;
inc = inc + 5;
inc += 5;
Console.WriteLine(inc);

//The ++ operator increments the value of the variable by 1.
int inc_1 = 0;
inc_1 = inc_1 + 1;
inc_1++;
Console.WriteLine(inc_1);

//Increment and Decrement
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);


//Challenge: Calculate Celsius given the current temperature in Fahrenheit
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine($"In Fahrenheit the teparature is {fahrenheit} and in Celsius the temparature is {celsius}");
Console.WriteLine(5 / 10);