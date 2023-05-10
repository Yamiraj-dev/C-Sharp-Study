
using System.Data;
bool isValidAge;
int age;
int testNumber = 0;

do
{
    Console.WriteLine(testNumber);
    testNumber += 3;
} while (testNumber != 10); // this is an infinite loop, it will clog memory. Be very careful in this condition

/*do
{
    Console.Write("What is your age: ");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);

    if (isValidAge == false)
    {
        Console.WriteLine("That was an invalid age.");
    }
} while (isValidAge == false);

Console.WriteLine($"Your age is {age}");*/

/*if (isValidAge == false)
{
    Console.WriteLine("That was an invalid age.");
    return;
}
*/

/*do 
{
    // runs code at least once
} while (true);

while (true)
{
    // runds the code 0 or more times, because we check conditions first
}
*/

