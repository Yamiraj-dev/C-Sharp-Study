

string data = "Mus,Mulan,Jaysea,Pia";
List<string> firstNames = data.Split(',').ToList();

/*for (int i = 0; i < firstNames.Count; i++)
{

}*/

// creates a string variable firstName for every element in the list of firstNames
foreach (string firstName in firstNames)
{
    Console.WriteLine(firstName);
}
