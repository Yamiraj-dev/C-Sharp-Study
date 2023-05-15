
string firstName;
List<string> firstNames = new();

do
{
    Console.Write("Please enter your first name or type exit: ");
    firstName = Console.ReadLine();

    firstNames.Add(firstName);

} while (firstName.ToLower() != "exit");

foreach (string name in firstNames)
{
    Console.WriteLine($"Hello, {name}");
}
