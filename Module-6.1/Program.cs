//Testing, debugging, and exception handling are all important tasks for software developers.
//Testing can be categorized into functional and nonfunctional testing, and developers are expected to perform some level of testing.
//Code debugging is the process of isolating issues and identifying ways to fix them, and it's a developer responsibility.
//Exception handling is the process of managing errors that occur during runtime, and developers are responsible for handling exceptions by using "try" and "catch" statements in their code.

//Exceptions are used in C# to propagate errors at runtime, and are represented by classes derived from the Exception class.
//Exceptions are thrown by code that encounters an error and caught by code that can correct the error.
//When an exception is caught, code can access its contents and take corrective action to mitigate the error.
//The .NET runtime generates exceptions when it detects an error and the exception contains information about the type of error that occurred.

string[] students = new string[] { "Sophia", "Nicolas", "Zahirah", "Jeong" };
int studentCount = students.Length;
Console.WriteLine("The final name is: " + students[studentCount]);