//The for statement iterates through a code block a specific number of times. This level of control makes the for statement unique among the other iteration statements. 
//The foreach statement iterates through a block of code once for each item in a sequence of data like an array or collection. 
//The while statement iterates through a block of code until a condition is met.

//The for statement includes the following six parts:
//1. The for keyword.
//2. A set of parentheses that defines the conditions of for iteration. The parentheses contain three distinct parts, separated by the end of statement operator, a semi-colon.
//3. The first part defines and initializes the iterator variable. In this example: int i = 0.This section is referred to as the initializer.
//4. The second part defines the completion condition. In this example: i < 10.In other words, the runtime will continue to iterate over the code in the code block below the for statement while i is less than 10. When i becomes equal to 10, the runtime stops executing the for statement's code block. The docs refer to this section as the condition.
//5. The third part defines the action to take after each iteration. In this case, after each iteration, i++ will increment the value of i by 1. The docs refer to this section as the iterator.
//6. Finally, the code block. The code block contains the code that will be executed for each iteration. Notice that the value of i is referenced inside of the code block. The docs refer to this section as the body.

for (int i =0; i<10; i++)
{
    Console.WriteLine(i);
}


for (int j = 10; j >= 0; j--)
{
    Console.WriteLine(j);
}


for (int k = 0; k < 10; k +=3)
{
    Console.WriteLine(k);
}


//Use of break keyword
for (int m = 0; m < 100; m++)
{
    Console.WriteLine(m);
    if (m==50) break;
}


string[] names = {"Ahmed", "Shafin", "Shafi" };
//using Array.Length property to get the numbers of elements in the array
for (int y = names.Length -1; y >=0; y--)
{
    Console.WriteLine(names[y]);
}

string[] namesArray = { "Ahmed", "Shafin", "Shafi" };
for (int iterate = 0; iterate < namesArray.Length; iterate++)
{
    if (namesArray[iterate] == "Ahmed")
    {
        namesArray[iterate] = "Mohammad";
    }
    foreach ( var name in namesArray)
    {
        Console.WriteLine(name);
    }
}


//FizzBuzz Challange
for (int a = 1; a <= 100; a++)
{
    if (a % 3 == 0 && a % 5 == 0)
    {
        Console.WriteLine($"{a} - FizzBuzz");
    }
    else if (a % 3 == 0)
    {
        Console.WriteLine($"{a} - Fizz");
    }
    else if (a % 5 == 0)
    {
        Console.WriteLine($"{a} - Buzz");
    }
    else
    {
        Console.WriteLine(a);
    }
}