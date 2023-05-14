

using System.ComponentModel;

string firstNamesText;
Console.WriteLine("Enter a list of names separated by a comma with no spaces.");
Console.Write("Please enter the names: ");
firstNamesText = Console.ReadLine();

List<string> firstNames = firstNamesText.Split(',').ToList();

for (int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine($"Hello, {firstNames[i]}.");
}
