//Recap
//Here are most important takeaways from this unit about string formatting:
//You can use composite formatting or string interpolation to format strings.
//With composite formatting, you use a string template containing one or more replacement tokens in the form {0}. You also supply a list of arguments that are matched with the replacement tokens based on their order. Composite formatting works when using string.Format() or Console.WriteLine().
//With string interpolation, you use a string template containing the variable names you want replaced surrounded by curly braces. Use the $ directive before the string template to indicate you want the string to be interpolated.
//Format currency using a :C specifier.
//Format numbers using a :N specifier. Control the precision (number of values after the decimal point) using a number after the :N like { myNumber:N3 }.
//Format percentages using the :P format specifier.
//Formatting currency and numbers depend on the end user's culture, a five character code that includes the user's country/region and language (per the settings on their computer).

//What is Composite Formatting ?
//Composite formatting uses numbered placeholders within a string. 
//At run time, everything inside the braces is resolved to a value that is also passed in based on their position.
using System.Numerics;
using System.Security.AccessControl;

string first = "Hello";
string second = "World";

string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

string resultOne = string.Format("{0} {0} {0}!", first, second);
Console.WriteLine(resultOne);


//What is string interpolation ?
//String interpolation is a technique that simplifies composite formatting.
//Instead of using a numbered token and including the literal value or variable name in a list of arguments to String.Format() or Console.WriteLine()
string resultThree = ($"{first} {second}!");
Console.WriteLine(resultThree);

//To add dollar sign used the :C currency format specifier.
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price is: {price:C} and Save is: {discount:C}");

//Included commas to delineate thousands, millions, billions
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement is: {measurement:N} unit.");


//Used the P format specifier to format percentages.
decimal tax = .12385m;
Console.WriteLine($"Tax rate is: {tax:P2}");

// Define two decimal variables representing the actual price and sale price
decimal actualPrice = 67.55m;
decimal salePrice = 59.99m;
// Use String.Format to create a formatted string that includes information about the discount
// {0:C2} is a format specifier that formats the first argument (actualPrice - salePrice) as currency with 2 decimal places
// {1:C2} is a format specifier that formats the second argument (actualPrice) as currency with 2 decimal places
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (actualPrice - salePrice), actualPrice);
// Print the formatted string to the console
Console.WriteLine(yourDiscount);


decimal actualPrice1 = 67.55m;
decimal salePrice1 = 59.99m;
string yourDiscount1 = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (actualPrice1 - salePrice1), actualPrice1);
yourDiscount1 += $"A discount of {((actualPrice1 - salePrice1) / actualPrice1):P2}!"; //inserted
Console.WriteLine(yourDiscount1);


Console.WriteLine("C110".PadLeft(6, '0'));


Console.WriteLine("");
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;
Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"Shares: {productShares:N3} Product");
Console.WriteLine($"Sub Total: {subtotal:C}");
Console.WriteLine($"Tax: {taxPercentage:P2}");
Console.WriteLine($"Total Billed: {total:C}");

//The PadLeft() method adds blank spaces to the left-hand side of the string 
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentId = "769C";
string formattedString = paymentId.PadLeft(12);
Console.WriteLine($"The formatted string looks like {formattedString}");


//Exercise - Complete a challenge to apply string interpolation to a form letter
string customerName = "Ms. Barros";
string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;
string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;
string comparisonMessage = "Here's a quick comparison:";

Console.WriteLine($"Dear {customerName}");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\r\n");

Console.WriteLine("");
Console.WriteLine($"Currently we own {currentShares:N} shares at a return of {currentReturn:P}.");

Console.WriteLine("");
Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\r\n");
comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

Console.WriteLine("Here's a quick comparison:\n");
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);
Console.WriteLine(comparisonMessage);
