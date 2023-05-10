

/*bool isComplete = false;

if (isComplete)
{
    Console.WriteLine("The statement was true.");
}
else 
{
    Console.WriteLine("The statement was false.");
}
*/

Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "mus") // this is to avoid user error in the case the capitalise wrong letters
{
    Console.WriteLine("Hello Mr. Gonzales");
}
else
{
    Console.WriteLine($"Hello {firstName}");
}

Console.WriteLine("End of program.");


