//------------------------Print literal values------------------------
//What is a literal value?
//A literal value is a constant value that naver changes.
//Double quotes are used for string data type and single quotes are used for char literal.
Console.WriteLine('A');
Console.WriteLine(123);

//Float Type    Precision
//----------------------------
//float         ~6-9 digits
//double        ~15-17 digits
//decimal        28-29 digits
Console.WriteLine(3.1416);

//string for words, phrases, or any alphanumeric data for presentation, not calculation
//char for a single alphanumeric character
//int for a whole number
//decimal for a number with a fractional component
//bool for a true/false value
//------------------------Print literal values end------------------------


//------------------------Declare variables------------------------
//Variables are temporary values you store in the computer's memory.
//Before you can use a variable, you have to declare it.
//To declare a variable, you first select a data type for the kind of data you want to store, and then give the variable a name that follows the rules.
string thisIsCamelCase;


//You must assign (set) a value to a variable before you can retrieve (get) a value from a variable.
//You can initialize a variable by assigning a value to the variable at the point of declaration.
//Assignment happens from right to left.
//You use a single equals character as the assignment operator.
//To retrieve the value from the variable, you merely use the variable's name.
string firstname;
firstname = "Planet Earth";
Console.WriteLine(firstname);

string lastName = "Planet Moon";
Console.WriteLine(lastName);
//------------------------Declare variables End------------------------


//------------------------Declare implicitly typed local variables------------------------
//An implicitly typed local variable is created by using the var keyword followed by a variable initialization.
//The var keyword tells the compiler to infer the data type of the variable based on the value it is initialized to.
//You'll likely see the var keyword as you read other people's code; however, you should use the data type when possible.
var message = "Hello planet Moon";
//message = 123;
Console.WriteLine(message);

string name = "Bob";
int messageCount = 3;
decimal temparature = 34.4m;
Console.Write("Hello, ");
Console.Write(name);
Console.Write("! ");
Console.Write("You have ");
Console.Write(messageCount);
Console.Write(" messages in your inbox. The temparature is ");
Console.Write(temparature);
Console.Write(" celcius");

//string name = "Bob";
//int messageCount = 3;
//decimal temparature = 34.4m;
//Console.WriteLine($"Hello, {name}! You have {messageCount} messages in your inbox. The temparature is {temparature} celcius");
//------------------------Declare implicitly typed local variables End------------------------