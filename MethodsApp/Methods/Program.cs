using Methods;
using System.Transactions;
// we can shorthen samplemethods.sayhello by adding :
// using static Methods.SampleMethods; however we might run into ambiguous calls the more we shorten calls

// the context of this is in static void main
// static allows us to call methods without having to instatiate 


// DRY - Don't Repeat Yourself 
// Instead of copying code logic in multiple areas and it bugs out, we can refactor the code in one place so it works out in other areas
// Working on a method is better than fixing copied code in multiple areas

// SOLID - S (SRP) single responsbility principle 
/*string name = ConsoleMessages.GetUserName();

ConsoleMessages.SayHello(name);
ConsoleMessages.SayGoodbye();

double result = MathShortcuts.Add(5, 7);
Console.WriteLine($"The result is {result}");

double[] vals = new double[] { 2, 7, 4, 3, 5, 7, 8, 6, 3, 2, 1, 9, 4 };
MathShortcuts.AddAll(vals);*/


//Discard character is an underscore "_", which we can use like (string firstName, _) to ignore one of the called types 
(string firstName, string lastName) = ConsoleMessages.GetFullName(); // can use var instead of (string, string) instead

Console.WriteLine($"First Name: {firstName}");
Console.WriteLine($"Last Name: {lastName}" );

