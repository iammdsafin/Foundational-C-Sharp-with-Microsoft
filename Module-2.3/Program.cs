//Some methods don't rely on the current state of the application to work properly. In other words, stateless methods are implemented so that they can work without referencing or
//changing any values already stored in memory. Stateless methods are also known as static methods.

//Stateful (instance) methods keep track of their state in fields, which are variables defined on the class.
//Each new instance of the class gets its own copy of those fields in which to store state.

//A single class can support both stateful and stateless methods. However, when you need to call stateful methods, you must first create an instance of the class so that the method can access state.
//An instance of a class is called an object. To create a new instance of a class, you use the new operator.

//Try to can attempt to access the method directly from the class itself. If it works, you know that it's a stateless method.

//Random random = new Random();
//or
using static System.Runtime.InteropServices.JavaScript.JSType;

Random random = new();
int roll = random.Next(1, 7);
Console.WriteLine(roll);

//Error CS0120	An object reference is required for the non-static field, method, or property 'Random.Next()'
int result = Random.Next();

//To call methods of a class in the .NET Class Library, you use the format ClassName.MethodName(), where the . symbol is the member access operator to access a method defined on the class, and the () symbols are the method invocation operators.
//When calling a stateless method, you don't need to create a new instance of its class first.
//When calling a stateful method, you need to create an instance of the class, and access the method on the object.
//Use the new operator to create a new instance of a class.
//An instance of a class is called an object.
