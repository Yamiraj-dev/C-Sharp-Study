using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods;

// we add static before class to work with our program.cs console app

// public - anyone can call this method
// internal - anyone inside the project can call this method
// private - anyone inside this scope can call this method
public static class ConsoleMessages
{
    // naming a method uses Pascal Casing (every word's first letter is capitalized)
    public static void SayHello(string firstName)
    {
        Console.WriteLine($"Hello {firstName}!");
    }
    
    // instead of void, we set the value to the data type we give out and also return that value 
    public static string GetUserName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // if you want to return 2 or more values, we use a tuple
    public static (string firstName, string lastName) GetFullName()
    {
        Console.Write("What is your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name: ");
        string lastName = Console.ReadLine();

        return (firstName, lastName);
    }

    public static void SayGoodbye()
    {
        Console.WriteLine("Goodbye my dude.");
    }
}

