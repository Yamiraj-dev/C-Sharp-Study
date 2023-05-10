
Console.Write("Please enter your first name: ");
string firstName = Console.ReadLine();

if (firstName.ToLower() == "mus" || firstName.ToLower() == "mustafa")
{
    Console.WriteLine("Hello Yamiraj Dev.");
}
else
{
    Console.WriteLine("Hello, user.");
}

switch (firstName.ToLower())    
{
    case "mus" or "mustafa":
        Console.WriteLine("Hello there developer.");
        break;
    default:
        Console.WriteLine("Hello there user.");
        break;
}