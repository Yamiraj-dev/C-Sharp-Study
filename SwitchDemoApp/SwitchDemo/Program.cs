// with switch, we have to iterate every case and the default acts like an else statement in if loops

string firstName = "Mus";
int age = 24    ;

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a youngling");
        break;
    case >= 18 and < 50:
        Console.WriteLine("You gotta be working");
        break;
    case >= 50 and < 76:
        Console.WriteLine("Hopefully you are retired.");
        break;
    default:
        Console.WriteLine("You must be an ancient being.");
        break;
}

/*switch (firstName.ToLower())
{
 // case "mus":  this would fall through and execute the next case code
    case "Mus" or "mus":
        Console.WriteLine("Hello Mussolini");
        break;
    case "moose":
        Console.WriteLine("You are an animal now.");
        break;
    default:
        Console.WriteLine("Wait a minute, who are you?");
        break;
}*/
