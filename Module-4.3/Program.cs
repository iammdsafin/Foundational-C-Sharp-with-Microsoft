string[] testArray = { "A2R3", "A2R2", "A2R1", "A2R5", "A2R4" };

Console.WriteLine("The sorted room numbers are: ");
Array.Sort(testArray);
foreach (var roomNumbers in testArray)
{
    Console.WriteLine(roomNumbers);
}


Console.WriteLine("");


Console.WriteLine("The reversed room numbers are: ");
Array.Reverse(testArray);
foreach (var roomNumbers in testArray)
{
    Console.WriteLine(roomNumbers);
}


Console.WriteLine("");


Console.WriteLine("Use of Clear() method");
Array.Clear(testArray, 0, 1);
Console.WriteLine($"Clearing 1 ...count: {testArray.Length}");
foreach (var roomNumbers in testArray)
{
    Console.WriteLine(roomNumbers);
}


string dummyValue = ".NET";
char[] dummyArray = dummyValue.ToCharArray();
Array.Reverse(dummyArray);
//string result = new string(dummyArray);
string result = String.Join(",", dummyArray);
Console.WriteLine(result);

//REVERSE EACH WORD IN A MESSAGE CHALLANGE
Console.WriteLine("");
string givenSentence = "A quick brown fox jumps over the lazy dog";

Console.WriteLine("Given sentence is: ");
Console.WriteLine(givenSentence);

Console.WriteLine("The sentence with reversed words is: ");
string[] message = givenSentence.Split(' ');

string[] splitedMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    splitedMessage[i] = new string(letters);
}

string res = string.Join(" ", splitedMessage);
Console.WriteLine(res);


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}