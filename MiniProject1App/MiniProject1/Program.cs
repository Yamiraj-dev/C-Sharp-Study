/*
using System.Runtime.CompilerServices;

Console.Write("Please enter your first name: ");
string firstName = Console.ReadLine();

Console.Write("Please enter your age: ");
string? age = Console.ReadLine();

int ageNumber = int.Parse(age);


if (firstName.ToLower() == "bob" || 
    firstName.ToLower() == "sue")
{
    Console.WriteLine($"Hello, Professor {firstName}.");
}
else
{
    Console.WriteLine("Hello, student.");
}

switch (ageNumber)
{
    case < 21:
        ageNumber = 21 - ageNumber;
        Console.WriteLine("You should wait " + ageNumber + " years.");
        break;
    case >= 21:
        Console.WriteLine("You should be starting your class.");
        break;
    default:
        Console.WriteLine("You did not enter a number.");
        break;

}*/

Console.Write("Please enter your first name: ");
string firstName = Console.ReadLine();

Console.Write("Please enter your age: ");
string ageText = Console.ReadLine();

string formattedName;

if (int.TryParse(ageText, out int age) == false || age <= 0)
{
    Console.WriteLine("You did enter a valid age.");
    return;
}

if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    formattedName = $"Professor {firstName}";
}
else
{
    formattedName = firstName;
}

if (age < 21)
{
    Console.WriteLine($"I recommend you wait {21 - age} years, {formattedName}.");
}
else
{
    Console.WriteLine($"Welcome to class {formattedName}");
}


/*if (int.TryParse(ageText, out int age))
{
    if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
    {
        formattedName = $"Professor {firstName}";
    }
    else
    {
        formattedName = firstName;
    }

    if (age > 21)
    {
        Console.WriteLine($"I recommend you wait {21 - age} years, {formattedName}.");
    }
    else
    {
        Console.WriteLine($"Welcome to class {formattedName}");
    }
}
else
{
    Console.WriteLine("You did enter a valid age.");
}*/
