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
    public static void SayHello()
    {
        Console.WriteLine("Hello there!");
    }

    public static void SayGoodbye()
    {
        Console.WriteLine("Goodbye my dude.");
    }
}

