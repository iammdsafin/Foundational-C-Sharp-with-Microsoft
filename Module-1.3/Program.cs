//Console.WriteLine("Planet \nEarth");
//Console.WriteLine("Planet \tMoon");
//Console.WriteLine("Planet \"Saturn\"!");
//Console.WriteLine("c:\\source\\repose");


//Console.WriteLine("Generating invoices for customer \"Contoso Crop\" ...\n");
//Console.WriteLine("Invoice: 0121 \t\tComplete!");
//Console.WriteLine("Invoice: 0122 \t\tComplete!\n");
//Console.WriteLine("Output Directory:");
//Console.Write("c:\\invoices\\\n\n");

//Console.Write("\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a");
//Console.WriteLine("\n\tc:\\invoices\\app.exe -j");

//Console.WriteLine(@"    c:\source\repos    
//        (this is the palce for code)");

//String Concatenation
string pl_1 = "Planet";
string pl_2 = "Earth";
string intro = "This is " + pl_1 + " " + pl_2;

//Avoiding Intermediate variables
Console.WriteLine("Well well" + " Hi!" + " " + pl_1 + " " +pl_2);
Console.WriteLine(intro);
string intro_1 = string.Concat(pl_1, pl_2);

//String Interpolation
string intro_2 = $"My full name is {pl_1} {pl_2}";
Console.WriteLine(intro_2);

//Accessing String Characters
Console.WriteLine(pl_1[2]);
Console.WriteLine(pl_2.IndexOf("E"));

string project = "AIUB";
Console.WriteLine("View output message:");
Console.WriteLine($"\tc:\\Exercise\\{project}\\data.txt");