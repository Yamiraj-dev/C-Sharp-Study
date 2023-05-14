/*
string idText;
int id;
bool isValidID;
string employeeName;
string lookup;
Dictionary<int, string> employees = new Dictionary<int, string>();

do
{
    Console.Write("Please enter your ID: ");
    idText = Console.ReadLine();

    isValidID = int.TryParse(idText, out id);

    if (isValidID == false)
    {
        Console.WriteLine("Sorry, that is not a valid ID.");
    }
    else if (isValidID == true)
    {
        Console.Write("Please enter your name: ");
        employeeName = Console.ReadLine(); 
        employees.Add(id, employeeName);
    }

    Console.Write("Exit or lookup for ID: ");
    lookup = Console.ReadLine();

    bool isValidLookup = int.TryParse(lookup, out id);

    do
    {
        if (isValidLookup == false)
        {
            Console.WriteLine("Please enter a valid ID");
        }
        else
        {
            Console.WriteLine($"The employee name for this ID is {employees[id]}");
        }
    } while (isValidLookup == false);


} while (lookup.ToLower() != "exit");*/

string idText;
int id;
bool isValidID;
string fullName;
string lookup;
Dictionary<int, string> employees = new Dictionary<int, string>();

do
{
    Console.Write("Please enter your ID: ");
    idText = Console.ReadLine();

    isValidID = int.TryParse(idText, out id);

    do 
    { 
        if (isValidID == false)
        {
            Console.WriteLine("Please enter a valid ID.");
        }
        else 
        {
            Console.WriteLine("Please enter your full name: ");
            fullName = Console.ReadLine();
            employees.Add(id, fullName);
        }
    } while (isValidID == false);

    Console.WriteLine("Do you want to add more users or lookup?");
    lookup = Console.ReadLine();

} while (lookup.ToLower() != "lookup");


do
{
    Console.Write("Enter employee ID for their name: ");
    idText = Console.ReadLine();    

    isValidID = int.TryParse(idText, out id);

    if (isValidID == false)
    {
        Console.WriteLine("Please enter a valid employee ID");
    }
    else
    {
        Console.WriteLine($"The employee name for this ID is {employees[id]}");
    }
} while (isValidID == false);


// there must be a better way of restarting the program and not using as many do/while loops 

