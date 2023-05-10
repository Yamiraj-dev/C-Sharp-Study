

Console.Write("What is your first name: ");
string firstName = Console.ReadLine();

Console.Write("What is your last name: ");
string lastName = Console.ReadLine();

/*if (firstName.ToLower() == "mus" &&
    lastName.ToLower() == "gonzales")
{
    Console.WriteLine("Hello Mr. Gonzales");
}
else if (firstName.ToLower() == "tim")
{
    Console.WriteLine("Hello, cool first name.");
}
else if (lastName.ToLower() == "gonzales")
{
    Console.WriteLine("That's a cool last name");
}
else
{
    Console.WriteLine($"Hello, {firstName} {lastName}.");
}
*/

/* chaining if statements one after the other
runs both if statements, which is why we use else if */

// be careful with the if conditions, especially using ==, <, <=, >=, >, != 

if (firstName.ToLower() == "mus" ||
    lastName.ToLower() == "gonzales") // || means or, with && meaning and
{
    Console.WriteLine("You have a great part in your name.");
}
else
{
    Console.WriteLine("Hello my dude.");
}

int age = 34;

if ((age >= 30 && age < 40) || (age >= 60 && age < 70))
{
    Console.WriteLine("You are in your 30's or 60's");
}
