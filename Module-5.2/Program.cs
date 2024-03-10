//Variables declared inside of a method are only accessible to that method.
//Variables declared in top-level statements are accessible throughout the program.
//Methods don't have access to variables defined within different methods.
//Methods can call other methods.

//Value types such as int, bool, float, double, and char directly contain values. 
//Reference types such as string, array, and objects (such as instances of Random) don't store their values directly. 
//Instead, reference types store an address where their value is being stored.
//It is important to remember that string is a reference type, but it is immutable. That means once it has been assigned a value, it can't be altered. 

//Variables can be categorized as value types and reference types.
//Value types directly contain values, and reference types store the address of the value.
//Methods using value type arguments create their own copy of the values.
//Methods that perform changes on an array parameter affect the original input array.
//String is an immutable reference type.
//Methods that perform changes on a string parameter don't affect the original string.

//Parameters are made optional by setting a default value in the method signature.
//Named arguments are specified with the parameter name, followed by a colon and the argument value.
//When combining named and positional arguments, you must use the correct order of parameters.


void Count(int max)
{
    for (int i = 0; i < max; i ++)
    {
        Console.WriteLine(i);
    }
}
Count(5);



int[] schedule = { 800, 1200, 1600, 2000 };
void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}
DisplayAdjustedTimes(schedule, 6, -6);


string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };
void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}
DisplayStudents(students);
DisplayStudents(new string[] { "Robert", "Vanya" });



double pi = 3.1416;
PrintCircleInfo(12);
PrintCircleInfo(24);
void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}


int a = 3;
int b = 4;
int c = 0;

Console.WriteLine($"global statement: {a} x {b} = {c}");
void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}
Multiply(a, b, c);


int[] array = { 1, 2, 3, 4, 5 };
void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine();
}
void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}
PrintArray(array);
Clear(array);
PrintArray(array);


string status = "Healthy";
void SetHealth(string status, bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}
SetHealth(status, false);


string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;

void RSVP(string name, int partySize, string allergies, bool inviteOnly)
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Sorry the name {name} can not found in the guest list.");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}

RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
RSVP("Nadia", 2, "Nuts", true);
RSVP("Linh", 2, "none", false);
RSVP("Tony", 1, "Jackfruit", true);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();


//Code challenge: Add a method to display email addresses
string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    DisplayEmail(first: corporate[i, 0] , last: corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    DisplayEmail(first: corporate[i, 0], last: corporate[i, 1], domain: externalDomain);
}

void DisplayEmail(string first, string last, string domain = "contoso.com")
{
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}