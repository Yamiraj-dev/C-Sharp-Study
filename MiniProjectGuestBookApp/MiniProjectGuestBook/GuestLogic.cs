using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectGuestBook
{
    internal class GuestLogic
    {
        public static void GreetingMessage()
        {
            Console.WriteLine("Welcome to my Guest Book App");
            Console.WriteLine("****************************");
            Console.WriteLine();
        }

        public static string GetPartyName()
        {
            Console.Write("Please enter your party name: ");
            string output = Console.ReadLine();

            return output;
        }

        public static int GetPartySize() 
        {
            bool isValidNumber;
            int output;
            do
            {
                Console.Write("Please enter the number of people in your party: ");
                string partySizeText = Console.ReadLine();
                isValidNumber = int.TryParse(partySizeText, out output); 

            } while (isValidNumber == false);

            return output;
        }

        public static (List<string> guests, int total) GetAllGuests()
        {
            int totalGuests = 0;
            List<string> guests = new List<string>();   

            do
            {
                //GetPartyName
                guests.Add(GetPartyName());

                //GetPartySize
                totalGuests += GetPartySize();

            } while (ToContinue());

            return (guests, totalGuests);
        }

        public static bool ToContinue() 
        {
            Console.Write("Anymore guests? (yes/no): ");
            string continueLooping = Console.ReadLine();
            Console.WriteLine();

            bool output = (continueLooping == "yes"); // gives us true if it is yes or false for everything else

            return output;
        }

        public static void DisplayGuests(List<string> guests)
        {
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
            Console.WriteLine();
        }

        public static void DisplayGuestCount(int totalGuests)
        {
            Console.WriteLine("Thank you for attending the event!");
            Console.WriteLine($"The total guests count is: {totalGuests}");
        }
    }
}
