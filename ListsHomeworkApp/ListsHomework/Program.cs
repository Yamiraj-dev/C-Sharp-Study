/*Console.Write("Please enter your first name: ");
string firstName = Console.ReadLine();

List<string> firstNames = new List<string>();
string data = firstName;
firstNames = data.Split(',').ToList();

Console.WriteLine(firstNames.Count);*/

List<string> firstNames = new List<string>();
string firstName;
do
{
    Console.Write("Exit or add name: ");
    firstName = Console.ReadLine();

    if (firstName.ToLower() == "exit")
    {
        Console.WriteLine(firstNames.Count);
    }
    else
    {
        firstNames.Add(firstName); 
    }



} while (firstName.ToLower() != "exit");

