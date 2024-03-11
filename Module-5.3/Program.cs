//Methods can return a value by specifying the return data type, or void for no return value
//The return keyword can be used with variables, literals, and expressions
//The value returned from a method must match the specified return type
//Data returned from methods can be captured and used by the caller of the method

double total = 0;
double minimumspend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    //total += getdiscountedprice(i);
    total = total + GetDiscountedPrice(i);
}
if (TotalMeetsMinimum())
{
    //total -= 5.00;
    total = total - 5.00;
}
Console.WriteLine($"Total: ${FormatDecimal(total)}");
double GetDiscountedPrice(int itemIndex)
{
    double result = items[itemIndex] * (1 - discounts[itemIndex]);
    return result;
}
bool TotalMeetsMinimum()
{
    return total >= minimumspend;
}
string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}


double usd = 0;
int vnd = UsdToVnd(23.73);

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int)(rate * usd);
}
Console.WriteLine($"${usd} USD = ${vnd} VND");

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");


string word = "iammdsafin";
string ReverseChar(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result = result + word[i];
    }
    return result;
}
Console.WriteLine(ReverseChar(word));


string inputSentence = "hello planet earth";
string ReverseSentence(string inputSentence)
{
    string result = "";
    string[] words = inputSentence.Split(" ");
    foreach (string word in words)
    {
        result = result+ ReverseWord(word) + " ";
    }
    return result.Trim();
}
string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result = result+ word[i];
    }
    return result;
}
Console.WriteLine(inputSentence);
Console.WriteLine(ReverseSentence(inputSentence));


string[] words = { "racecar", "talented", "deified", "tent", "tenet" };
Console.WriteLine("Is it a palindrome?");

foreach (string _word in words)
{
    Console.WriteLine($"{_word}: {IsPalindrome(_word)}");
}
bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}