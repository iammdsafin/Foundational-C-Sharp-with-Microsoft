//The switch statement chooses one section of code to execute from a list of possible switch sections.
//The default keyword acts as the matching value when none of the supplied case values is a match.

string fruit = "";
Console.WriteLine("Enter the fruit name");
fruit = Console.ReadLine();

switch (fruit)
{
    case "Apple":
        Console.WriteLine("You have entered Apple");
        break;
    case "Banana":
        Console.WriteLine("You have entered Banana");
        break;
    case "Papaya":
        Console.WriteLine("You have entered Papaya");
        break;
}

int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

string sku = "01-MN-L";
string[] product = sku.Split('-');
string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "Other";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");