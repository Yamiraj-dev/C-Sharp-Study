// See https://aka.ms/new-console-template for more information

/*-Welcome user to application
- Ask for their first name
- Greet them by their first name*/


//Welcoming the user
Console.WriteLine("Welcome to the Greeting App");
Console.WriteLine("This is my second project");
Console.WriteLine("---------------------------");
Console.WriteLine();

//Ask for first name
Console.Write("Please enter your first name: "); //Console.Write does not use a separate line for the next code 
string firstName;
firstName = Console.ReadLine();

//Greet user by their input
Console.WriteLine(); //leave space between input and output
Console.WriteLine("Greetings " + firstName + "!");

Console.WriteLine("Thank you for testing my application!");
Console.ReadLine();