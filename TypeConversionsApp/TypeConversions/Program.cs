// Type conversions for changing one data type to another


Console.Write("What is your age: ");
string? ageText = Console.ReadLine();

Console.WriteLine(ageText + 15); // this results in whatever the user enters with 15 at the end (xx15), this is not the desired outcome

//int age = int.Parse(ageText); // takes in the string and identifies the integer, however if a number is spelt out this does not work either

bool isValidInt = int.TryParse(ageText, out int age); // we made the variable age here, we can state it earlier but this becomes a two-step process

Console.WriteLine($"This is valid: {isValidInt}. The number was {age}");

Console.WriteLine(age + 15);

double testDouble = age;
decimal testDecimal = (decimal)testDouble; // converting using casting so the double is treated as a decimal 

