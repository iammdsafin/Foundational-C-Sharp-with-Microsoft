//IndexOf() gives you the first position of a character or string inside of another string.
//IndexOf() returns -1 if it can't find a match.
//Substring() returns just the specified portion of a string, using a starting position and optional length.
//There's often more than one way to solve a problem. You used two separate techniques to find all instances of a given character or string.
//Avoid hardcoded magic values. Instead, define a const variable. A constant variable's value can't be changed after initialization.

//LastIndexOf() returns the last position of a character or string inside of another string.
//IndexOfAny() returns the first position of an array of char that occurs inside of another string.


//The Remove() method works like the Substring() method, except that it deletes the specified characters in the string.
//The Replace() method swaps all instances of a string with a new string.


string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');
//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition + 1, length - 1));


string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int a = message.LastIndexOf('(');
int b = message.LastIndexOf(')');
Console.WriteLine(message.Substring(a + 1, 17));


string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');
openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    Note the overload of the Substring to return only the remaining
     unprocessed message:
    message = message.Substring(closingPosition + 1);
}

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(0, 5);
Console.WriteLine(updatedData);
Console.WriteLine(updatedData.Length);

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

//Extract the quantity.
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan ) + (openSpan.Length);
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;

quantity = input.Substring(quantityStart, quantityLength);

Console.WriteLine(quantity);
Console.WriteLine(output);