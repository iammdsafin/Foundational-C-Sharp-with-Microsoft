//What is a data type?
//A data type is a way a programming language defines how much memory to save for a value.

//Value vs. reference types
//Variables of reference types store references to their data (objects), that is they point to data values stored somewhere else. In comparison, variables of value types directly contain their data.


Console.WriteLine("Signed intregral types");
Console.WriteLine($"sbyte :{sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short :{short.MinValue} to {short.MinValue}");
Console.WriteLine($"int :{int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long :{long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");
Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");



////How reference types are different from value types

////A value type variable stores its values directly in an area of storage called the stack. 
////The stack is memory allocated to the code that is currently running on the CPU (also known as the stack frame, or activation frame). 
////When the stack frame has finished executing, the values in the stack are removed.

////A reference type variable stores its values in a separate memory region called the heap. 
////The heap is a memory area that is shared across many applications running on the operating system at the same time. 
////The .NET Runtime communicates with the operating system to determine what memory addresses are available, and requests an address where it can store the value. 
////The .NET Runtime stores the value, and then returns the memory address to the variable. 
////When code uses the variable, the .NET Runtime seamlessly looks up the address stored in the variable, and retrieves the value that's stored there.


int[] data = new int[3];

//Value types can hold smaller values and are stored in the stack. 
//    Reference types can hold large values, and a new instance of a reference type is created using the new operator. Reference type variables hold a reference (the memory address) to the actual value stored in the heap.
//        Reference types include arrays, strings, and classes.