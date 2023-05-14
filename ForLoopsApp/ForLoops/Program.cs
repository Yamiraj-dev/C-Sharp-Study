

// int i is a counter, which starts at position 0
// second condition checks if i is less than the length of something
// add 1 to i is the last condition

/*for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"The value of i is {i}");
}*/

/*string data = "Mus,Mulan,Jaysea,Pia,Juno";
List<string> firstNames = data.Split(',').ToList();

for (int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine($"{firstNames[i]} is present.");
}*/

List<decimal> charges = new();

charges.Add(23.78M);
charges.Add(19.98M);
charges.Add(194M);

decimal total = 0;

for (int i = 0; i < charges.Count; i++)
{
    total += charges[i];
    Console.WriteLine(charges[i]);
}

Console.WriteLine($"Our total charges is {total}");
