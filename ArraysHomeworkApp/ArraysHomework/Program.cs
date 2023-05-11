
bool isValidIndex;
int indexNumber = 0;
string[] firstNames = new string[3];
firstNames[0] = "Mus";
firstNames[1] = "Jaysea";
firstNames[2] = "Pia";



do {
    Console.Write("Please enter an index: ");
    string indexText = Console.ReadLine();
    isValidIndex = int.TryParse(indexText, out indexNumber);

    if (isValidIndex == false || (indexNumber > 2 || indexNumber < 0))

    {
        Console.WriteLine("Please enter a valid index number within range (0-2)");
    }

} while ((isValidIndex == false) || (indexNumber > 2 || indexNumber < 0));

Console.WriteLine($"The first name of this index is: {firstNames[indexNumber]}");