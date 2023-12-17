//C# is a case-sensitive language, meaning that the C# compiler considers the words console and Console.
//Common mistakes like entering lower-case letters instead of capitalizing C in Console, or the letters W or L in WriteLine.
//Similarly, single-quotation marks (') to surround the literal string Hello World! like so:
//error CS1012: Too many characters in character literal

//The difference between Console.Write and Console.WriteLine is that Console.WriteLine adds a new line character ( \n ) at the end of the output, and Console.Write does not.
//To print an entire message to the output console, you used the first technique, Console.WriteLine(). At the end of the line, it added a line feed similar to how to create a new line of text by pressing Enter or Return.
//To print to the output console, but without adding a line feed at the end, you used the second technique, Console.Write(). So, the next call to Console.Write() prints another message to the same line.

#region Use_Of_WriteLine
Console.WriteLine("Hello Planet Earth!");
Console.WriteLine("Hello Planet Earth!");

//Output: Hello Planet Earth!
//Output: Hello Planet Earth!
#endregion

#region Use_of_Write
Console.Write("Hey It's me again!");
Console.Write(" ");
Console.Write("from planet Earth.");

//Output: Hey It's me again! from planet Earth. 
#endregion
