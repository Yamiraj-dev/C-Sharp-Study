
string firstName; 

do 
{
    Console.Write("What is your first name or type exit to quit: ");
    firstName = Console.ReadLine();

    if (firstName.ToLower() == "tim")
    {
        Console.WriteLine($"Welcome Professor {firstName}");
    }
    else if (firstName.ToLower() != "exit")
    {
        Console.WriteLine($"Welcome {firstName}");
    }
} while (firstName.ToLower() != "exit");


