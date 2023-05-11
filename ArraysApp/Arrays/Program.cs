
// 0 based counting - 0, 1, 2, 3, 4


/*string[] firstNames = new string[5]; // this array now holds 5 first names

firstNames[0] = "Tim"; // position 0 refers to the first item in an array
firstNames[1] = "Mus";
firstNames[2] = "Pia";
firstNames[4] = "Jaysea";

Console.WriteLine($"The firstNames are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[4]}");

firstNames[0] = "Bob";

Console.WriteLine(firstNames[0]);*/

// we cannot go to store [5] as this exceeds our array size 


string data = "Tim,Mus,Pia,Jaysea,Juno";
string[] firstNames = data.Split(','); // you should use single quotes for identifying a char, double quotes are for string values

Console.WriteLine(firstNames[4]);

Console.WriteLine(firstNames.Length);

// another way of declaring an array

string[] lastNames = new string[] { "Corey", "Gonzales", "Po" };
int[] ages = new int[] { 2, 3, 4 };