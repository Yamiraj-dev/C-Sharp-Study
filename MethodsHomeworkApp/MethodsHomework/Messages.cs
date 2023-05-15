using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomework
{
    internal class Messages
    {
        public static void Greeting()
        {
            Console.WriteLine("Greetings!");
        }

        public static string GetFirstName()
        {
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            return firstName;
        }

        public static void GreetUser(string firstName)
        {
            Console.WriteLine($"Hello {firstName}!");
        }
    }
}
