public class Program
{
    public static int MultiplyNumbers(int num1, int num2)
    {
        return num1 * num2;
    }

    public static void Main(string[] args)
    {
        int result = MultiplyNumbers(3, 4);
        Console.WriteLine("Result: " + result);
    }
}



int x = 5;
int y = 2;
int result = x / y;
Console.WriteLine(result);


int y = 5;
void PrintValue()
{
    int y = 10;
    Console.WriteLine(y);
}
PrintValue();


void DisplayFullName(string firstName, string lastName)
{
    Console.WriteLine("Full Name: " + firstName + " " + lastName);
}
DisplayFullName("Ahmed", "Shafin");


int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int num in numbers)
{
    Console.WriteLine(num);
}