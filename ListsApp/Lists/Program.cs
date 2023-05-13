// lists are an upgrade to arrays, they are a more modern way of storing data


// string[] firstNames = new string[5];
List<string> firstNames = new List<string>(); // list of T, T means any type you want

firstNames.Add("Mus");
firstNames.Add("Jaysea");
firstNames.Add("Pia");
firstNames.Add("Mulan");

// it is also 0 based counting like arrays
Console.WriteLine(firstNames[firstNames.Count - 1]);

List<int> ages = new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);

// List<T> - generic

string data = "Gonzales, Ocares, Po";
List<string> lastNames = data.Split(',').ToList(); // we convert the data split from an array to list
lastNames.Add("Jaafar"); // and then add a last name to the end of the list of last names

